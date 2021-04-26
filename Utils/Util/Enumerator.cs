using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Enumerator
    {

        /// <summary>
        /// Enumerator do tipo do banco
        /// </summary>
        public enum BancoDados
        {
            SQL_SERVER = 0,
            SQLite = 1,
            ORACLE = 2
        }

        /// <summary>
        /// Enum referente à tela a ser aberta
        /// </summary>
        public enum Telas
        {
            CADASTRO_ENTRADA = 0,
            CADASTRO_TABELAS = 1,
            CADASTRO_CAMPOS = 2,
            CONTROLE_TABELAS = 3,
            CADASTRO_RELATORIO = 4,
            CADASTRO_ROTA_REPOSITORY = 5,
            CADASTRO_METODO_ROTA_REPOSITORY = 6,
            CADASTRO_CAMPOS_ENTRADA = 7,
            CADASTRO_CLASSE_ENTRADA = 8,
            CADASTRO_CLASSE_CLASSE_FILHA = 9,
            CADASTRO_CAMPO_CLASSE = 10,
            CADASTRO_TIPO_SAIDA = 11,
            CADASTRO_CLASSE_SAIDA = 12,
            CADASTRO_CAMPO_SAIDA = 14,
            CADASTRO_CAMPO_SAIDA_CLASSE = 15
        }

        /// <summary>
        /// Tarefa sendo executada na tela
        /// </summary>
        public enum Tarefa
        {
            INCLUIR = 0,
            EDITAR = 1,
            EXCLUIR = 2,
            VISUALIZAR = 3
        }

        /// <summary>
        /// Enumerator for type of data
        /// </summary>
        public enum DataType
        {
            DATE = 1,
            INT = 2,
            STRING = 3,
            CHAR = 4,
            DECIMAL
        }

        public enum Status
        {
            // Status desativado
            DESATIVADO = 0,
            // Status ativado
            ATIVO = 1
        }

        public enum ArquivosGerados
        {
            // Arquivos da UTIL
            UTIL = 0,
            // Arquivos do Model
            MODEL = 1
        }

        public enum ClassesApi
        {
            GERENCIADOR = 0,
            REPOSITORY = 1
        }

        public enum MetodoApi
        {
            POST = 0,
            GET = 1,
            DELETE = 2,
            PUT = 3
        }

    }
}
