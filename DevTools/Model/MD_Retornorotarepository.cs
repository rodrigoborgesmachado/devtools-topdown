using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [RETORNOROTAREPOSITORY] Tabela da classe
    /// </summary>
    public class MD_RetornoRotaRepository 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_RetornoRotaRepository DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_RetornoRotaRepository(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Retornorotarepository()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_RetornoRotaRepository( codigo);
        }


        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que retorna todas as rotas
        /// </summary>
        /// <param name="projeto">Código do projeto</param>
        /// <returns>Lista das tabelas</returns>
        public static List<MD_RetornoRotaRepository> RetornaRetornosRotas(int rota)
        {
            string sentenca = new DAO.MD_RetornoRotaRepository().table.CreateCommandSQLTable() + " WHERE CODIGOROTAREPOSITORY = " + rota + " ORDER BY TIPORETORNO";

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            List<MD_RetornoRotaRepository> campos = new List<MD_RetornoRotaRepository>();

            while (reader.Read())
            {
                campos.Add(new MD_RetornoRotaRepository(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return campos;
        }

        #endregion Métodos

    }
}
