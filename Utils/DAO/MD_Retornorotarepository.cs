using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DAO
{

    /// <summary>
    /// [RETORNOROTAREPOSITORY] Tabela RETORNOROTAREPOSITORY
    /// </summary>
    public class MD_Retornorotarepository : MDN_Model
    {
        #region Atributos e Propriedades

        private int codigo;
        /// <summary>
        /// [CODIGO] 
        /// <summary>
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        private int codigorotarepository;
        /// <summary>
        /// [CODIGOROTAREPOSITORY] 
        /// <summary>
        public int Codigorotarepository
        {
            get
            {
                return this.codigorotarepository;
            }
            set
            {
                this.codigorotarepository = value;
            }
        }

        private int codigoclasseretorno;
        /// <summary>
        /// [CODIGOCLASSERETORNO] Código da classe de retorno (quando preencher pegar informações da classe)
        /// <summary>
        public int Codigoclasseretorno
        {
            get
            {
                return this.codigoclasseretorno;
            }
            set
            {
                this.codigoclasseretorno = value;
            }
        }

        private string tiporetorno;
        /// <summary>
        /// [TIPORETORNO] tipo de retorno
        /// <summary>
        public string Tiporetorno
        {
            get
            {
                return this.tiporetorno;
            }
            set
            {
                this.tiporetorno = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_Retornorotarepository()
            : base()
        {
            base.table = new MDN_Table("RETORNOROTAREPOSITORY");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", false, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOROTAREPOSITORY", true, Util.Enumerator.DataType.INT, 0, false, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOCLASSERETORNO", true, Util.Enumerator.DataType.INT, 0, false, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("TIPORETORNO", false, Util.Enumerator.DataType.STRING, "", false, false, 100, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGO">
        public MD_Retornorotarepository(int codigo)
            :this()
        {
            this.codigo = codigo;
            this.Load();
        }


		#endregion Construtores

        #region Métodos

		/// <summary>
        /// Método que faz o load da classe
        /// </summary>
        public override void Load()
        {
            Util.CL_Files.WriteOnTheLog("MD_Retornorotarepository.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo + "";
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.Codigorotarepository = int.Parse(reader["CODIGOROTAREPOSITORY"].ToString());
                this.Codigoclasseretorno = int.Parse(reader["CODIGOCLASSERETORNO"].ToString());
                this.Tiporetorno = reader["TIPORETORNO"].ToString();

                this.Empty = false;
                reader.Close();
            }
            else
            {
                this.Empty = true;
                reader.Close();
            }
        }

        /// <summary>
        /// Método que faz o delete da classe
        /// </summary>
        /// <returns>True - sucesso; False - erro</returns>
        public override bool Delete()
        {
            string sentenca = "DELETE FROM " + this.table.Table_Name + " WHERE CODIGO = " + Codigo + "";
            return DataBase.Connection.Delete(sentenca);
        }

        /// <summary>
        /// Método que faz o insert da classe
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            string sentenca = string.Empty;

            sentenca = "INSERT INTO " + table.Table_Name + " (" + table.TodosCampos() + ")" + 
                              " VALUES (" + this.codigo + ", " + this.codigorotarepository + ", " + this.codigoclasseretorno + ",  '" + this.tiporetorno + "')";
            if (DataBase.Connection.Insert(sentenca))
            {
                Empty = false;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método que faz o update da classe
        /// </summary>
        /// <returns>True - sucesso; False - erro</returns>
        public override bool Update()
        {
            string sentenca = string.Empty;

            sentenca = "UPDATE " + table.Table_Name + " SET " + 
                        "CODIGO = " + Codigo + ", CODIGOROTAREPOSITORY = " + Codigorotarepository + ", CODIGOCLASSERETORNO = " + Codigoclasseretorno + ", TIPORETORNO = '" + Tiporetorno + "'" + 
                        " WHERE CODIGO = " + Codigo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
