using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [CLASSERETORNOREPOSITORY] Tabela da classe
    /// </summary>
    public class MD_Classeretornorepository 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Classeretornorepository DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_Classeretornorepository(int codigo, string nome)
        {
            Util.CL_Files.WriteOnTheLog("MD_Classeretornorepository()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_Classeretornorepository( codigo,  nome);
        }


        #endregion Construtores

        #region Métodos

        #endregion Métodos

    }
}
