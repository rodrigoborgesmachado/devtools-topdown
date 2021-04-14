using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [CAMPOSENTRADA] Tabela da classe
    /// </summary>
    public class MD_CamposEntrada 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_CamposEntrada DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_CamposEntrada(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Camposentrada()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_CamposEntrada( codigo);
        }


        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que retorna todos os campos de entrada do método
        /// </summary>
        /// <param name="rota"></param>
        /// <returns></returns>
        public static List<MD_CamposEntrada> RetornaCamposEntradaRota(int metodoRota)
        {
            string sentenca = new DAO.MD_CamposEntrada().table.CreateCommandSQLTable() + " WHERE CODITOROTAREPOSITORY = " + metodoRota + " ORDER BY NOMECAMPOENTRADA";

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            List<MD_CamposEntrada> camposEntrada = new List<MD_CamposEntrada>();

            while (reader.Read())
            {
                camposEntrada.Add(new MD_CamposEntrada(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return camposEntrada;
        }

        #endregion Métodos

    }
}
