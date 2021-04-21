using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [CLASSERETORNOREPOSITORY] Tabela da classe
    /// </summary>
    public class MD_ClasseRetornoRepository 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_ClasseRetornoRepository DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_ClasseRetornoRepository(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Classeretornorepository()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_ClasseRetornoRepository( codigo);
        }


        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que retorna todas as rotas
        /// </summary>
        /// <param name="projeto">Código do projeto</param>
        /// <returns>Lista das tabelas</returns>
        public static List<MD_ClasseRetornoRepository> RetornaRetornosClasses(int codigoClasseRetorno)
        {
            string sentenca = new DAO.MD_ClasseRetornoRepository().table.CreateCommandSQLTable() + " WHERE (ROTARETORNO = " + codigoClasseRetorno + " AND CLASSEMAE = -1) OR (CLASSEMAE = " + codigoClasseRetorno + " AND ROTARETORNO = -1)";

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            List<MD_ClasseRetornoRepository> campos = new List<MD_ClasseRetornoRepository>();

            while (reader.Read())
            {
                campos.Add(new MD_ClasseRetornoRepository(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return campos;
        }

        #endregion Métodos

    }
}
