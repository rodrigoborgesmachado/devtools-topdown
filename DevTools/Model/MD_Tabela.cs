﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [TABELA] Classe de controle da tabela "tabela"
    /// </summary>
    public class MD_Tabela
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Tabela DAO = null;

        #endregion Atributos e Propriedades

        #region Contrutores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="codigo">Código da tabela</param>
        /// <param name="projeto">Código do projeto</param>
        public MD_Tabela(int codigo, int projeto)
        {
            Util.CL_Files.WriteOnTheLog("MD_Tabela()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_Tabela(codigo, projeto);
        }

        #endregion Contrutores

        #region Métodos

        /// <summary>
        /// Método que retorna uma lista com os campos que pertencem à tabela
        /// </summary>
        /// <returns>Lista com os campos</returns>
        public List<Model.MD_Campos> CamposDaTabela()
        {
            Util.CL_Files.WriteOnTheLog("MD_Tabela.CamposDaTabela()", Util.Global.TipoLog.DETALHADO);

            List<Model.MD_Campos> campos = new List<Model.MD_Campos>();

            string sentenca = "SELECT CODIGO FROM CAMPOS WHERE CODIGOTABELA = " + this.DAO.Codigo;
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            while (reader.Read())
            {
                campos.Add(new Model.MD_Campos(int.Parse(reader["codigo"].ToString()), this.DAO.Codigo, this.DAO.Projeto.Codigo));
            }

            return campos;
        }

        /// <summary>
        /// Método que valida se a tabela já existe no projeto
        /// </summary>
        /// <param name="tabela">nome da tabela</param>
        /// <param name="projeto">Código do projeto</param>
        /// <returns></returns>
        public static bool ValidaExisteTabelaProjeto(string tabela, int projeto)
        {
            bool retorno = false;

            string sentenca = "SELECT COUNT(1) AS QT FROM TABELA WHERE UPPER(NOME) = UPPER('" + tabela + "') AND PROJETO = " + projeto + "";

            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader.Read())
            {
                // Se o retorno for diferente de 0 então existe coluna na tabela com o mesmo nome
                retorno = !reader["QT"].ToString().Equals("0");
            }

            return retorno;
        }

        /// <summary>
        /// Método que retorna todas as tabelas
        /// </summary>
        /// <param name="projeto">Código do projeto</param>
        /// <returns>Lista das tabelas</returns>
        public static List<MD_Tabela> RetornaTabelasProjeto(int projeto)
        {
            string sentenca = new DAO.MD_Tabela().table.CreateCommandSQLTable() + " WHERE PROJETO = " + projeto + " ORDER BY NOME";

            List<MD_Tabela> tabelas = new List<MD_Tabela>();
            Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(15000, "Carregando tabela");
            barra.Show();

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            while (reader.Read())
            {
                barra.AvancaBarra(1);
                tabelas.Add(new MD_Tabela(int.Parse(reader["CODIGO"].ToString()), projeto));
            }
            reader.Close();

            barra.Dispose();
            return tabelas;
        }

        /// <summary>
        /// Método que retorna todas as tabelas
        /// </summary>
        /// <param name="projeto">Código do projeto</param>
        /// <returns>Lista das tabelas</returns>
        public static List<MD_Tabela> RetornaTabelasProjeto(string tabela, int projeto)
        {
            string sentenca = new DAO.MD_Tabela().table.CreateCommandSQLTable() + " WHERE PROJETO = " + projeto + " ORDER BY NOME";

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            List<MD_Tabela> tabelas = new List<MD_Tabela>();

            while (reader.Read())
            {
                if (reader["NOME"].ToString().ToUpper().Contains(tabela.ToUpper())
                    || reader["CODIGO"].ToString().Equals(tabela))
                {
                    tabelas.Add(new MD_Tabela(int.Parse(reader["CODIGO"].ToString()), projeto));
                }
            }
            reader.Close();

            return tabelas;
        }

        #endregion Métodos
    }
}
