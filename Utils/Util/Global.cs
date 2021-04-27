using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class Global
    {
        /// <summary>
        /// Método que valida as tabelas que já foram verificadas
        /// </summary>
        public static List<string> tabelasVerificadas = new List<string>();

        public static string tempTable = "TESTE";

        // Caminho principal da aplicação
        public static string app_main_directoty = System.IO.Directory.GetCurrentDirectory() + "\\";

        // Caminho da pasta de logs do sistema
        public static string app_logs_directoty = app_main_directoty + "Log\\";

        // Caminho da pasta de arquivos temporários
        public static string app_temp_directory = app_main_directoty + "TEMP\\";

        // Nome do diretório de saída
        public static string app_out_directory = app_main_directoty + "OUT\\";

        // Nome do diretório do banco de dados
        public static string app_base_directory = app_main_directoty + "BASE\\";

        // Nome do diretório do DER
        public static string app_DER_directory = app_main_directoty + "DER\\";

        // Nome do diretório dos scripts
        public static string app_Script_directory = app_main_directoty + "Script\\";

        // Nome do diretório do Img do html
        public static string app_Img_directory = app_main_directoty + "Img\\";

        // Nome do diretório de EXPORTAÇÃO
        public static string app_exportacao_directory = app_main_directoty + "EXPORTACAO\\";

        // Nome do diretório de Classes
        public static string app_classesSaida_directory = app_main_directoty + "Classes Saída\\";

        // Nome do diretório das Classes Saida - Controller
        public static string app_classesSaidaController_directory = app_classesSaida_directory + "Controller\\";

        // Nome do diretório das Classes Saida - Controller
        public static string app_classesSaidaControllerFile = app_classesSaidaController_directory + "Controller.cs";

        // Nome do diretório das Classes Saida - Controller
        public static string app_classesSaidaControllerMetodosFile = app_classesSaidaController_directory + "METODOS.cs";

        // Nome do diretório das Classes Saida - DTO
        public static string app_classesSaidaDto_directory = app_classesSaida_directory + "DTO\\";

        // Nome do diretório das Classes Saida - DTO
        public static string app_classesSaidaDtoFile = app_classesSaidaDto_directory + "Repository.cs";

        // Nome do diretório das Classes Saida - Entity
        public static string app_classesSaidaEntity_directory = app_classesSaida_directory + "Entity\\";

        // Nome do diretório das Classes Saida - Entity
        public static string app_classesSaidaEntityFile = app_classesSaidaEntity_directory + "Entity.cs";

        // Nome do diretório das Classes Saida - Query
        public static string app_classesSaidaQuery_directory = app_classesSaida_directory + "Query\\";

        // Nome do diretório das Classes Saida - Query
        public static string app_classesSaidaQueryFile = app_classesSaidaQuery_directory + "Query.cs";

        // Nome do diretório das Classes Saida - Query
        public static string app_classesSaidaQueryMetodosFile = app_classesSaidaQuery_directory + "METODOS.cs";

        // Nome do diretório das Classes Saida - Query - Interface
        public static string app_classesSaidaQueryInterface_directory = app_classesSaida_directory + "Query - Interface\\";

        // Nome do diretório das Classes Saida - Query - Interface
        public static string app_classesSaidaQueryInterfaceFile = app_classesSaidaQueryInterface_directory + "IQuery.cs";

        // Nome do diretório das Classes Saida - Query - Interface
        public static string app_classesSaidaQueryInterfaceMetodosFile = app_classesSaidaQueryInterface_directory + "METODOS.cs";

        // Nome do diretório das Classes Saida - Repository
        public static string app_classesSaidaRepository_directory = app_classesSaida_directory + "Repository\\";

        // Nome do diretório das Classes Saida - Repository
        public static string app_classesSaidaRepositoryFile = app_classesSaidaRepository_directory + "Repository.cs";

        // Nome do diretório das Classes Saida - Repository
        public static string app_classesSaidaRepositoryMetodosFile = app_classesSaidaRepository_directory + "METODOS.cs";

        // Nome do diretório das Classes Saida - Repository - Interface
        public static string app_classesSaidaRepositoryInterface_directory = app_classesSaida_directory + "Repository - Interface\\";

        // Nome do diretório das Classes Saida - Repository - Interface
        public static string app_classesSaidaRepositoryInterfaceFile = app_classesSaidaRepositoryInterface_directory + "IRepository.cs";

        // Nome do diretório das Classes Saida - Repository - Interface
        public static string app_classesSaidaRepositoryInterfaceMetodosFile = app_classesSaidaRepositoryInterface_directory + "METODOS.cs";

        // Nome do diretório das Classes Saida - Validations
        public static string app_classesSaidaValidations_directory = app_classesSaida_directory + "Validations\\";

        // Nome do diretório das Classes Saida - Validations
        public static string app_classesSaidaValidationFile = app_classesSaidaValidations_directory + "Validation.cs";

        // Nome do diretório das Classes base
        public static string app_classesBase_directory = app_main_directoty + "Classes Base\\";

        // Nome do diretório das Classes base - Controller
        public static string app_classesBaseController_directory = app_classesBase_directory + "Controller\\";

        // Nome do diretório das Classes base - Controller
        public static string app_classesBaseControllerFile = app_classesBaseController_directory + "Controller.cs";

        // Nome do diretório das Classes base - Controller
        public static string app_classesBaseControllerMetodosFile = app_classesBaseController_directory + "METODOS.cs";

        // Nome do diretório das Classes base - DTO
        public static string app_classesBaseDto_directory = app_classesBase_directory + "Controller\\";

        // Nome do diretório das Classes base - DTO
        public static string app_classesBaseDtoFile = app_classesBaseDto_directory + "Repository.cs";

        // Nome do diretório das Classes base - Entity
        public static string app_classesBaseEntity_directory = app_classesBase_directory + "Entity\\";

        // Nome do diretório das Classes base - Entity
        public static string app_classesBaseEntityFile = app_classesBaseEntity_directory + "Entity.cs";

        // Nome do diretório das Classes base - Query
        public static string app_classesBaseQuery_directory = app_classesBase_directory + "Query\\";

        // Nome do diretório das Classes base - Query
        public static string app_classesBaseQueryFile = app_classesBaseQuery_directory + "Query.cs";

        // Nome do diretório das Classes base - Query
        public static string app_classesBaseQueryMetodosFile = app_classesBaseQuery_directory + "METODOS.cs";

        // Nome do diretório das Classes base - Query - Interface
        public static string app_classesBaseQueryInterface_directory = app_classesBase_directory + "Query - Interface\\";

        // Nome do diretório das Classes base - Query - Interface
        public static string app_classesBaseQueryInterfaceFile = app_classesBaseQuery_directory + "IQuery.cs";

        // Nome do diretório das Classes base - Query - Interface
        public static string app_classesBaseQueryInterfaceMetodosFile = app_classesBaseQuery_directory + "METODOS.cs";

        // Nome do diretório das Classes base - Repository
        public static string app_classesBaseRepository_directory = app_classesBase_directory + "Repository\\";

        // Nome do diretório das Classes base - Repository
        public static string app_classesBaseRepositoryFile = app_classesBaseRepository_directory + "Repository.cs";

        // Nome do diretório das Classes base - Repository
        public static string app_classesBaseRepositoryMetodosFile = app_classesBaseRepository_directory + "METODOS.cs";

        // Nome do diretório das Classes base - Repository - Interface
        public static string app_classesBaseRepositoryInterface_directory = app_classesBase_directory + "Repository - Interface\\";

        // Nome do diretório das Classes base - Repository - Interface
        public static string app_classesBaseRepositoryInterfaceFile = app_classesBaseRepositoryInterface_directory + "IRepository.cs";

        // Nome do diretório das Classes base - Repository - Interface
        public static string app_classesBaseRepositoryInterfaceMetodosFile = app_classesBaseRepositoryInterface_directory + "METODOS.cs";

        // Nome do diretório das Classes base - Validations
        public static string app_classesBaseValidations_directory = app_classesBase_directory + "Validations\\";

        // Nome do diretório das Classes base - Validations
        public static string app_classesBaseValidationFile = app_classesBaseValidations_directory + "Validation.cs";

        // Nome do diretório de relatórios
        public static string app_rel_directory = app_main_directoty + "Relatorios\\";

        // Nome do diretório do Img do html
        public static string app_Files_directory = app_rel_directory + "Files\\";

        // Nome do arquivo de EXPORTAÇÃO 
        public static string app_exportacao_tabela_file = app_exportacao_directory + "tabela.json";

        // Nome do arquivo de EXPORTAÇÃO 
        public static string app_exportacao_campos_file = app_exportacao_directory + "campos.json";

        // Nome do arquivo de EXPORTAÇÃO 
        public static string app_exportacao_relacionamentos_file = app_exportacao_directory + "relacionamentos.json";

        // Nome do diretório de IMPORTACAO
        public static string app_importacao_directory = app_main_directoty + "IMPORTACAO\\";

        // Nome do aruqivo do DER
        public static string app_DER_file_TableB = app_DER_directory + "TableB.html";

        // Nome do aruqivo do DER
        public static string app_DER_file_TableR = app_DER_directory + "TableR.html";

        // Nome do aruqivo do DER
        public static string app_DER_file_Table = app_DER_directory + "Table.html";

        // Nome do programa de importação
        public static string app_IMPORT_file = app_main_directoty + "DbExtractor.exe";

        // Nome do arquivo CSS
        public static string app_DERCSS_file = app_DER_directory + "DER.css";

        // Nome do arquivo sqlite de configuração
        public static string app_base_file = app_base_directory + "pckdb.db3";

        // Nome do arquivo html temporário
        public static string app_temp_html_file = app_temp_directory + "file_html.html";

        // Nome da classe de CL_File
        public static string app_claseCLFile_file = "CL_File.cs";

        // Nome da classe DataBase
        public static string app_claseDataBase_file = "DataBase.cs";

        // Nome da classe Enumerator
        public static string app_claseEnumerator_file = "Enumerator.cs";

        // Nome da classe Global
        public static string app_claseGlobal_file = "Global.cs";

        // Nome da classe de MDN_Model
        public static string app_claseMDNModel_file = "MDN_Model.cs";

        // Nome da classe de MDN_Table
        public static string app_claseMDNTable_file = "MDN_Table.cs";

        // Nome da classe de MDN_Campo
        public static string app_claseMDNCampo_file = "MDN_Campo.cs";

        public static string usuarioFtp = "ph20598337134";
        public static string senhaFtp = "qbj1ACjd**";
        public static string caminhoFtp = "ftp://50.62.169.121/sunsale/";

        /// <summary>
        /// Enumerador referente ao tipo de log que o sistema irá persistir
        /// </summary>
        public enum TipoLog
        {
            DETALHADO = 0,
            SIMPLES = 1
        }

        /// <summary>
        /// Enum responsável por verificar se deve carregar o tree view automaticamente ou não
        /// </summary>
        public enum Automatico
        {
            Automatico = 0,
            Manual = 1
        }

        /// <summary>
        /// Enum responsável por verificar se deve carregar o tree view automaticamente ou não
        /// </summary>
        public enum Informacao
        {
            NAOAPRESENTAR = 0,
            APRESETAR = 1
        }

        /// <summary>
        /// Tipo mde log que o sistema está utilizando
        /// </summary>
        public static TipoLog log_system = TipoLog.SIMPLES;

        /// <summary>
        /// Carregar automaticamente ou não o tree view da tela principal
        /// </summary>
        public static Automatico CarregarAutomaticamente = Automatico.Automatico;

        /// <summary>
        /// Método que valida se deve apresentar mensagem de apresentação ou não 
        /// </summary>
        public static Informacao ApresentaInformacao = Informacao.APRESETAR;

        #region Métodos globais

        /// <summary>
        /// Método que insere os dados iniciais
        /// </summary>
        public static void InsereDadosIniciais()
        {
        }

        #endregion Métodos globais

    }
}
