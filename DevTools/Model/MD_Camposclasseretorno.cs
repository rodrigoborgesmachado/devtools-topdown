using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [CAMPOSCLASSERETORNO] Tabela da classe
    /// </summary>
    public class MD_CamposClasseRetorno 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_CamposClasseRetorno DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_CamposClasseRetorno(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Camposclasseretorno()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_CamposClasseRetorno( codigo);
        }


        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que retorna todas as rotas
        /// </summary>
        /// <param name="projeto">Código do projeto</param>
        /// <returns>Lista das tabelas</returns>
        public static List<MD_CamposClasseRetorno> RetornaRetornosCampoClasses(int codigoClasseRetorno)
        {
            string sentenca = new DAO.MD_CamposClasseRetorno().table.CreateCommandSQLTable() + " WHERE CODIGOCLASSE = " + codigoClasseRetorno;

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            List<MD_CamposClasseRetorno> campos = new List<MD_CamposClasseRetorno>();

            while (reader.Read())
            {
                campos.Add(new MD_CamposClasseRetorno(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return campos;
        }

        /// <summary>
        /// Método que retorna todas as rotas
        /// </summary>
        /// <param name="projeto">Código do projeto</param>
        /// <returns>Lista das tabelas</returns>
        public static List<MD_CamposClasseRetorno> RetornaRetornosCampoRota(int codigoClasseRetorno)
        {
            string sentenca = new DAO.MD_CamposClasseRetorno().table.CreateCommandSQLTable() + " WHERE CODIGOCLASSEREFERENTE = " + codigoClasseRetorno;

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            List<MD_CamposClasseRetorno> campos = new List<MD_CamposClasseRetorno>();

            while (reader.Read())
            {
                campos.Add(new MD_CamposClasseRetorno(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return campos;
        }

        #endregion Métodos

    }
}
