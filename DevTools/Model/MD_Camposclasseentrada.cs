using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [CAMPOSCLASSEENTRADA] Tabela da classe
    /// </summary>
    public class MD_CamposClasseEntrada 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_CamposClasseEntrada DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_CamposClasseEntrada(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Camposclasseentrada()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_CamposClasseEntrada( codigo);
        }


        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que retorna todas as rotas
        /// </summary>
        /// <param name="projeto">Código do projeto</param>
        /// <returns>Lista das tabelas</returns>
        public static List<MD_CamposClasseEntrada> RetornaMetodosApi(int rota)
        {
            string sentenca = new DAO.MD_CamposClasseEntrada().table.CreateCommandSQLTable() + " WHERE CLASSEREFERENTE = " + rota + " ORDER BY NOMECAMPO";

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            List<MD_CamposClasseEntrada> campos = new List<MD_CamposClasseEntrada>();

            while (reader.Read())
            {
                campos.Add(new MD_CamposClasseEntrada(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return campos;
        }

        #endregion Métodos

    }
}
