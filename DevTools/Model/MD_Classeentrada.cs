using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [CLASSEENTRADA] Tabela da classe
    /// </summary>
    public class MD_ClasseEntrada 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_ClasseEntrada DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_ClasseEntrada(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Classeentrada()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_ClasseEntrada( codigo);
        }


        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que retorna todos os campos de entrada do método
        /// </summary>
        /// <param name="rota"></param>
        /// <returns></returns>
        public static List<MD_ClasseEntrada> RetornaClassesEntradaRota(int metodoRota)
        {
            string sentenca = new DAO.MD_ClasseEntrada().table.CreateCommandSQLTable() + " WHERE CODIGOROTAREPOSITORY = " + metodoRota + " ORDER BY NOMECLASSE";

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            List<MD_ClasseEntrada> classesEntradas = new List<MD_ClasseEntrada>();

            while (reader.Read())
            {
                classesEntradas.Add(new MD_ClasseEntrada(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return classesEntradas;
        }

        /// <summary>
        /// Método que retorna todos os campos de entrada do método
        /// </summary>
        /// <param name="rota"></param>
        /// <returns></returns>
        public static List<MD_ClasseEntrada> RetornaClassesFilhas(int classeMae)
        {
            string sentenca = new DAO.MD_ClasseEntrada().table.CreateCommandSQLTable() + " WHERE CLASSEMAE = " + classeMae + " ORDER BY NOMECLASSE";

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            List<MD_ClasseEntrada> classesEntradas = new List<MD_ClasseEntrada>();

            while (reader.Read())
            {
                classesEntradas.Add(new MD_ClasseEntrada(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return classesEntradas;
        }

        #endregion Métodos

    }
}
