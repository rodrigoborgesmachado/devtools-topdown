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
    /// [CAMPOSCLASSERETORNO] Tabela CAMPOSCLASSERETORNO
    /// </summary>
    public class MD_Camposclasseretorno : MDN_Model
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

        private string codigoclasse;
        /// <summary>
        /// [CODIGOCLASSE] 
        /// <summary>
        public string Codigoclasse
        {
            get
            {
                return this.codigoclasse;
            }
            set
            {
                this.codigoclasse = value;
            }
        }

        private string tipocampo;
        /// <summary>
        /// [TIPOCAMPO] 
        /// <summary>
        public string Tipocampo
        {
            get
            {
                return this.tipocampo;
            }
            set
            {
                this.tipocampo = value;
            }
        }

        private string nomecampo;
        /// <summary>
        /// [NOMECAMPO] 
        /// <summary>
        public string Nomecampo
        {
            get
            {
                return this.nomecampo;
            }
            set
            {
                this.nomecampo = value;
            }
        }

        private string comentariocampo;
        /// <summary>
        /// [COMENTARIOCAMPO] 
        /// <summary>
        public string Comentariocampo
        {
            get
            {
                return this.comentariocampo;
            }
            set
            {
                this.comentariocampo = value;
            }
        }

        private string codigoclassereferente;
        /// <summary>
        /// [CODIGOCLASSEREFERENTE] 
        /// <summary>
        public string Codigoclassereferente
        {
            get
            {
                return this.codigoclassereferente;
            }
            set
            {
                this.codigoclassereferente = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_Camposclasseretorno()
            : base()
        {
            base.table = new MDN_Table("CAMPOSCLASSERETORNO");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", false, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOCLASSE", true, Util.Enumerator.DataType.CHAR, "", false, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("TIPOCAMPO", true, Util.Enumerator.DataType.STRING, "", false, false, 50, 0));
            this.table.Fields_Table.Add(new MDN_Campo("NOMECAMPO", true, Util.Enumerator.DataType.STRING, "", false, false, 150, 0));
            this.table.Fields_Table.Add(new MDN_Campo("COMENTARIOCAMPO", true, Util.Enumerator.DataType.STRING, "", false, false, 250, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOCLASSEREFERENTE", false, Util.Enumerator.DataType.CHAR, "", false, false, 0, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGO">
        public MD_Camposclasseretorno(int codigo)
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
            Util.CL_Files.WriteOnTheLog("MD_Camposclasseretorno.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo + "";
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.Codigoclasse = reader["CODIGOCLASSE"].ToString();
                this.Tipocampo = reader["TIPOCAMPO"].ToString();
                this.Nomecampo = reader["NOMECAMPO"].ToString();
                this.Comentariocampo = reader["COMENTARIOCAMPO"].ToString();
                this.Codigoclassereferente = reader["CODIGOCLASSEREFERENTE"].ToString();

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
                              " VALUES (" + this.codigo + ",  '" + this.codigoclasse + "',  '" + this.tipocampo + "',  '" + this.nomecampo + "',  '" + this.comentariocampo + "',  '" + this.codigoclassereferente + "')";
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
                        "CODIGO = " + Codigo + ", CODIGOCLASSE = '" + Codigoclasse + "', TIPOCAMPO = '" + Tipocampo + "', NOMECAMPO = '" + Nomecampo + "', COMENTARIOCAMPO = '" + Comentariocampo + "', CODIGOCLASSEREFERENTE = '" + Codigoclassereferente + "'" + 
                        " WHERE CODIGO = " + Codigo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
