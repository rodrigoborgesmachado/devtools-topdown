using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [RETORNOROTAREPOSITORY] Tabela da classe
    /// </summary>
    public class MD_Retornorotarepository 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Retornorotarepository DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_Retornorotarepository(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Retornorotarepository()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_Retornorotarepository( codigo);
        }


        #endregion Construtores

        #region Métodos

        #endregion Métodos

    }
}
