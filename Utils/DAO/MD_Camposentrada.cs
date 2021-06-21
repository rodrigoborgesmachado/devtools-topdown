using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DAO
{

    /// <summary>
    /// [CAMPOSENTRADA] Tabela CAMPOSENTRADA
    /// </summary>
    public class MD_CamposEntrada : MDN_Model
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

        private int coditorotarepository;
        /// <summary>
        /// [CODITOROTAREPOSITORY] 
        /// <summary>
        public int CoditoRotaRepository
        {
            get
            {
                return this.coditorotarepository;
            }
            set
            {
                this.coditorotarepository = value;
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

        private string tipocampoentrada;
        /// <summary>
        /// [TIPOCAMPOENTRADA] 
        /// <summary>
        public string TipoCampoEntrada
        {
            get
            {
                return this.tipocampoentrada;
            }
            set
            {
                this.tipocampoentrada = value;
            }
        }

        private string nomecampoentrada;
        /// <summary>
        /// [NOMECAMPOENTRADA] 
        /// <summary>
        public string NomeCampoEntrada
        {
            get
            {
                return this.nomecampoentrada;
            }
            set
            {
                this.nomecampoentrada = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_CamposEntrada()
            : base()
        {
            base.table = new MDN_Table("CAMPOSENTRADA");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", false, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CODITOROTAREPOSITORY", true, Util.Enumerator.DataType.INT, 0, false, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("TIPOENTRADA", true, Util.Enumerator.DataType.STRING, "", false, false, 150, 0));
            this.table.Fields_Table.Add(new MDN_Campo("TIPOCAMPOENTRADA", true, Util.Enumerator.DataType.STRING, "", false, false, 250, 0));
            this.table.Fields_Table.Add(new MDN_Campo("NOMECAMPOENTRADA", true, Util.Enumerator.DataType.STRING, "", false, false, 50, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGO">
        public MD_CamposEntrada(int codigo)
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
            Util.CL_Files.WriteOnTheLog("MD_Camposentrada.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo + "";
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.CoditoRotaRepository = int.Parse(reader["CODITOROTAREPOSITORY"].ToString());
                this.TipoEntrada = reader["TIPOENTRADA"].ToString();
                this.TipoCampoEntrada = reader["TIPOCAMPOENTRADA"].ToString();
                this.NomeCampoEntrada = reader["NOMECAMPOENTRADA"].ToString();

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
                              " VALUES (" + this.codigo + ", " + this.coditorotarepository + ",  '" + this.tipoentrada + "',  '" + this.tipocampoentrada + "',  '" + this.nomecampoentrada + "')";
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
                        "CODIGO = " + Codigo + ", CODITOROTAREPOSITORY = " + CoditoRotaRepository + ", TIPOENTRADA = '" + TipoEntrada + "', TIPOCAMPOENTRADA = '" + TipoCampoEntrada + "', NOMECAMPOENTRADA = '" + NomeCampoEntrada + "'" + 
                        " WHERE CODIGO = " + Codigo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
