using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [ROTASREPOSITORY] Tabela da classe
    /// </summary>
    public class MD_RotasRepository 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_RotasRepository DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_RotasRepository(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Rotasrepository()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_RotasRepository( codigo);
        }


        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que retorna todas as rotas
        /// </summary>
        /// <param name="projeto">Código do projeto</param>
        /// <returns>Lista das tabelas</returns>
        public static List<MD_RotasRepository> RetornaMetodosApi(int rota)
        {
            string sentenca = new DAO.MD_RotasRepository().table.CreateCommandSQLTable() + " WHERE CODIGOAPIREPOSITORY = " + rota + " ORDER BY NOMEMETODO";

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            List<MD_RotasRepository> metodos = new List<MD_RotasRepository>();

            while (reader.Read())
            {
                metodos.Add(new MD_RotasRepository(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return metodos;
        }

        #endregion Métodos

    }
}
