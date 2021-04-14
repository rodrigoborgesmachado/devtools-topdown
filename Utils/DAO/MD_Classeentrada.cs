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
    /// [CLASSEENTRADA] Tabela CLASSEENTRADA
    /// </summary>
    public class MD_ClasseEntrada : MDN_Model
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

        private int classeMae;
        /// <summary>
        /// [CLASSEMAE] 
        /// <summary>
        public int ClasseMae
        {
            get
            {
                return this.classeMae;
            }
            set
            {
                this.classeMae = value;
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

        private string nomeclasse;
        /// <summary>
        /// [NOMECLASSE] 
        /// <summary>
        public string NomeClasse
        {
            get
            {
                return this.nomeclasse;
            }
            set
            {
                this.nomeclasse = value;
            }
        }

        private string tipoentrada;
        /// <summary>
        /// [TIPOENTRADA] 
        /// <summary>
        public string TipoEntrada
        {
            get
            {
                return this.tipoentrada;
            }
            set
            {
                this.tipoentrada = value;
            }
        }

        private string tipoclasse;
        /// <summary>
        /// [TIPOCLASSE] 
        /// <summary>
        public string TipoClasse
        {
            get
            {
                return this.tipoclasse;
            }
            set
            {
                this.tipoclasse = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_ClasseEntrada()
            : base()
        {
            base.table = new MDN_Table("CLASSEENTRADA");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", false, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CLASSEMAE", true, Util.Enumerator.DataType.INT, -1, false, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODIGOROTAREPOSITORY", true, Util.Enumerator.DataType.INT, 0, false, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("NOMECLASSE", true, Util.Enumerator.DataType.STRING, "", false, false, 250, 0));
            this.table.Fields_Table.Add(new MDN_Campo("TIPOENTRADA", true, Util.Enumerator.DataType.STRING, "", false, false, 150, 0));
            this.table.Fields_Table.Add(new MDN_Campo("TIPOCLASSE", true, Util.Enumerator.DataType.STRING, "", false, false, 150, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGO">
        public MD_ClasseEntrada(int codigo)
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
            Util.CL_Files.WriteOnTheLog("MD_Classeentrada.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo + "";
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.Codigorotarepository = int.Parse(reader["CODIGOROTAREPOSITORY"].ToString());
                this.ClasseMae = int.Parse(reader["CLASSEMAE"].ToString());
                this.NomeClasse = reader["NOMECLASSE"].ToString();
                this.TipoEntrada = reader["TIPOENTRADA"].ToString();
                this.TipoClasse = reader["TIPOCLASSE"].ToString();

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
                              " VALUES (" + this.codigo + ", " + this.classeMae + ", " + this.codigorotarepository + ",  '" + this.nomeclasse + "',  '" + this.tipoentrada + "',  '" + this.tipoclasse + "')";
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
                        "CODIGO = " + Codigo  + ", CLASSEMAE = " + ClasseMae + ", CODIGOROTAREPOSITORY = " + Codigorotarepository + ", NOMECLASSE = '" + NomeClasse + "', TIPOENTRADA = '" + TipoEntrada + "', TIPOCLASSE = '" + TipoClasse + "'" + 
                        " WHERE CODIGO = " + Codigo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
