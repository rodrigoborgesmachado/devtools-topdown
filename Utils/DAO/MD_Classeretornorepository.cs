using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DAO
{

    /// <summary>
    /// [CLASSERETORNOREPOSITORY] Tabela CLASSERETORNOREPOSITORY
    /// </summary>
    public class MD_ClasseRetornoRepository : MDN_Model
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

        private string nome;
        /// <summary>
        /// [NOME] 
        /// <summary>
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        private string comentario;
        /// <summary>
        /// [COMENTARIO] 
        /// <summary>
        public string Comentario
        {
            get
            {
                return this.comentario;
            }
            set
            {
                this.comentario = value;
            }
        }

        private int classemae;
        /// <summary>
        /// [CLASSEMAE] 
        /// <summary>
        public int Classemae
        {
            get
            {
                return this.classemae;
            }
            set
            {
                this.classemae = value;
            }
        }

        private int rotaretorno;
        /// <summary>
        /// [ROTARETORNO] 
        /// <summary>
        public int RotaRetorno
        {
            get
            {
                return this.rotaretorno;
            }
            set
            {
                this.rotaretorno = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_ClasseRetornoRepository()
            : base()
        {
            base.table = new MDN_Table("CLASSERETORNOREPOSITORY");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", true, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("NOME", true, Util.Enumerator.DataType.CHAR, "", false, false, 100, 0));
            this.table.Fields_Table.Add(new MDN_Campo("COMENTARIO", true, Util.Enumerator.DataType.STRING, "", false, false, 50, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CLASSEMAE", true, Util.Enumerator.DataType.INT, -1, false, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("ROTARETORNO", false, Util.Enumerator.DataType.INT, -1, false, false, 0, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGO">
        public MD_ClasseRetornoRepository(int codigo)
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
            Util.CL_Files.WriteOnTheLog("MD_Classeretornorepository.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo + "";
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.Nome = reader["NOME"].ToString();
                this.Comentario = reader["COMENTARIO"].ToString();
                this.Classemae = int.Parse(reader["CLASSEMAE"].ToString());
                this.RotaRetorno = int.Parse(reader["ROTARETORNO"].ToString());

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
                              " VALUES (" + this.codigo + ",  '" + this.nome + "',  '" + this.comentario + "', " + this.classemae + ", " + this.rotaretorno + ")";
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
                        "CODIGO = " + Codigo + ", NOME = '" + Nome + "', COMENTARIO = '" + Comentario + "', CLASSEMAE = " + Classemae + ", ROTARETORNO = " + RotaRetorno + "" + 
                        " WHERE CODIGO = " + Codigo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
