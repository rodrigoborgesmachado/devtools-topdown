using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DAO
{

    /// <summary>
    /// [ROTASREPOSITORY] Tabela ROTASREPOSITORY
    /// </summary>
    public class MD_RotasRepository : MDN_Model
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

        private int codigoapirepository;
        /// <summary>
        /// [CODIGOAPIREPOSITORY] Código referente a qual rota está associada
        /// <summary>
        public int CodigoApiRepository
        {
            get
            {
                return this.codigoapirepository;
            }
            set
            {
                this.codigoapirepository = value;
            }
        }

        private string rota;
        /// <summary>
        /// [ROTA] Defini a rota de acesso ao método
        /// <summary>
        public string Rota
        {
            get
            {
                return this.rota;
            }
            set
            {
                this.rota = value;
            }
        }

        private string nomemetodo;
        /// <summary>
        /// [NOMEMETODO] Nome do método
        /// <summary>
        public string NomeMetodo
        {
            get
            {
                return this.nomemetodo;
            }
            set
            {
                this.nomemetodo = value;
            }
        }

        private string tipometodo;
        /// <summary>
        /// [TIPOMETODO] 
        /// <summary>
        public string TipoMetodo
        {
            get
            {
                return this.tipometodo;
            }
            set
            {
                this.tipometodo = value;
            }
        }

        private string consulta;
        /// <summary>
        /// [CONSULTA] 
        /// <summary>
        public string Consulta
        {
            get
            {
                return this.consulta;
            }
            set
            {
                this.consulta = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_RotasRepository()
            : base()
        {
            base.table = new MDN_Table("ROTASREPOSITORY");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", false, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOAPIREPOSITORY", true, Util.Enumerator.DataType.INT, 0, false, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("ROTA", false, Util.Enumerator.DataType.STRING, "", false, false, 350, 0));
            this.table.Fields_Table.Add(new MDN_Campo("NOMEMETODO", true, Util.Enumerator.DataType.STRING, "", false, false, 200, 0));
            this.table.Fields_Table.Add(new MDN_Campo("TIPOMETODO", true, Util.Enumerator.DataType.STRING, "", false, false, 50, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CONSULTA", false, Util.Enumerator.DataType.STRING, "", false, false, 5000, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGO">
        public MD_RotasRepository(int codigo)
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
            Util.CL_Files.WriteOnTheLog("MD_Rotasrepository.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo + "";
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.CodigoApiRepository = int.Parse(reader["CODIGOAPIREPOSITORY"].ToString());
                this.Rota = reader["ROTA"].ToString();
                this.NomeMetodo = reader["NOMEMETODO"].ToString();
                this.TipoMetodo = reader["TIPOMETODO"].ToString();
                this.Consulta = reader["CONSULTA"].ToString();

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
                              " VALUES (" + this.codigo + ", " + this.codigoapirepository + ",  '" + this.rota + "',  '" + this.nomemetodo + "',  '" + this.tipometodo + "',  '" + this.consulta + "')";
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
                        "CODIGO = " + Codigo + ", CODIGOAPIREPOSITORY = " + CodigoApiRepository + ", ROTA = '" + Rota + "', NOMEMETODO = '" + NomeMetodo + "', TIPOMETODO = '" + TipoMetodo + "', CONSULTA = '" + Consulta + "'" + 
                        " WHERE CODIGO = " + Codigo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
