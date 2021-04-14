using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [APIREPOSITORY] Tabela da classe
    /// </summary>
    public class MD_ApiRepository 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_ApiRepository DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_ApiRepository(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Apirepository()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_ApiRepository( codigo);
        }


        #endregion Construtores

        #region Métodos

        #endregion Métodos

    }
}
