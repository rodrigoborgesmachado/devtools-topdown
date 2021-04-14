using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [CAMPOSCLASSERETORNO] Tabela da classe
    /// </summary>
    public class MD_Camposclasseretorno 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Camposclasseretorno DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_Camposclasseretorno(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Camposclasseretorno()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_Camposclasseretorno( codigo);
        }


        #endregion Construtores

        #region Métodos

        #endregion Métodos

    }
}
