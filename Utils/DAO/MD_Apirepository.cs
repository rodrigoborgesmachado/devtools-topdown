using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DAO
{

    /// <summary>
    /// [APIREPOSITORY] Tabela APIREPOSITORY
    /// </summary>
    public class MD_ApiRepository : MDN_Model
    {
        #region Atributos e Propriedades

        private int codigo;
        /// <summary>
        /// [CODIGO] Código da rota
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

        private string descricao;
        /// <summary>
        /// [DESCRICAO] Descreve o objetivo da rota (Gerenciar transações de proposta PF)
        /// <summary>
        public string Descricao
        {
            get
            {
                return this.descricao;
            }
            set
            {
                this.descricao = value;
            }
        }

        private string rota;
        /// <summary>
        /// [ROTA] Rota para acesso ao controller
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

        private string nomerota;
        /// <summary>
        /// [NOMEROTA] Nome da rota para nomear as classes
        /// <summary>
        public string NomeRota
        {
            get
            {
                return this.nomerota;
            }
            set
            {
                this.nomerota = value;
            }
        }

        private int codigoprojeto;
        /// <summary>
        /// [CODIGOPROJETO] Código do projeto que a rota está associada
        /// <summary>
        public int CodigoProjeto
        {
            get
            {
                return this.codigoprojeto;
            }
            set
            {
                this.codigoprojeto = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_ApiRepository()
            : base()
        {
            base.table = new MDN_Table("APIREPOSITORY");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", false, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("DESCRICAO", true, Util.Enumerator.DataType.STRING, "", false, false, 250, 0));
            this.table.Fields_Table.Add(new MDN_Campo("ROTA", true, Util.Enumerator.DataType.STRING, "", false, false, 350, 0));
            this.table.Fields_Table.Add(new MDN_Campo("NOMEROTA", true, Util.Enumerator.DataType.STRING, "", false, false, 100, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOPROJETO", true, Util.Enumerator.DataType.INT, 0, false, false, 0, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGO">Código da rota
        public MD_ApiRepository(int codigo)
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
            Util.CL_Files.WriteOnTheLog("MD_Apirepository.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo + "";
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.Descricao = reader["DESCRICAO"].ToString();
                this.Rota = reader["ROTA"].ToString();
                this.NomeRota = reader["NOMEROTA"].ToString();
                this.CodigoProjeto = int.Parse(reader["CODIGOPROJETO"].ToString());

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
                              " VALUES (" + this.codigo + ",  '" + this.descricao + "',  '" + this.rota + "',  '" + this.nomerota + "', " + this.codigoprojeto + ")";
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
                        "CODIGO = " + Codigo + ", DESCRICAO = '" + Descricao + "', ROTA = '" + Rota + "', NOMEROTA = '" + NomeRota + "', CODIGOPROJETO = " + CodigoProjeto + "" + 
                        " WHERE CODIGO = " + Codigo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
