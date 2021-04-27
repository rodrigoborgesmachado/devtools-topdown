
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras.ClassesRotasApi
{
    class ClasseCreatorRepository : ClasseCreatorGeneric
    {

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="rota"></param>
        public ClasseCreatorRepository(Model.MD_ApiRepository rota)
            : base(rota)
        {

        }

        /// <summary>
        /// Método que implementa a criação da classe
        /// </summary>
        /// <returns></returns>
        public override bool CriaClasses(out string mensagemErro)
        {
            bool retorno = true;
            mensagemErro = string.Empty;

            try
            {
                StringBuilder controllerBuilder = MontaController(out mensagemErro);
                StringBuilder queryInterface = MontaQueryInterface(out mensagemErro);
                StringBuilder query = MontaQuery(out mensagemErro);
                StringBuilder repositoryInterface = MontaRepositoryInterface(out mensagemErro);
                StringBuilder repository = MontaRepository(out mensagemErro);
                StringBuilder dto = MontaDTO(out mensagemErro);
                StringBuilder entity = MontaEntity(out mensagemErro);
                StringBuilder validation = MontaValidation(out mensagemErro);
            }
            catch(Exception e)
            {
                retorno = false;
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta o controller
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaController(out string mensagemErro)
        {
            StringBuilder retorno = new StringBuilder();
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseController_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base";
            }
            else if (!File.Exists(Util.Global.app_classesBaseControllerFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base de controller";
            }
            else if (!File.Exists(Util.Global.app_classesBaseControllerMetodosFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base de controller";
            }
            else
            {
                string rotaApi = base.rota.DAO.Rota;
                string nomeClasse = CriaNomeClasseController();
                string nomeInterfaceQuery = CriaNomeClasseQueryInterface();
                string nomeVariavelInterfaceQuery = CriaNomeVariavelClasseQueryInterface();
                string metodos = MontaMetodosController();

                string textoBase = LeArquivo(Util.Global.app_classesBaseControllerFile);
                textoBase = textoBase.Replace("#ROTAAPI", rotaApi);
                textoBase = textoBase.Replace("#NOMECLASSE", nomeClasse);
                textoBase = textoBase.Replace("#NOMEINTERFACEQUERY", nomeInterfaceQuery);
                textoBase = textoBase.Replace("#NOMEVARIAVELINTERFACEQUERY", nomeVariavelInterfaceQuery);
                textoBase = textoBase.Replace("#METODOS", metodos);

                retorno.Append(textoBase);
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta os métodos do controller
        /// </summary>
        /// <returns></returns>
        private string MontaMetodosController()
        {
            string retorno = string.Empty;

            List<Model.MD_RotasRepository> listaMetodos = Model.MD_RotasRepository.RetornaMetodosApi(this.rota.DAO.Codigo);

            listaMetodos.ForEach(metodo =>
            {
                string textoBase = LeArquivo(Util.Global.app_classesBaseControllerMetodosFile);
                textoBase = textoBase.Replace("#ROTAMETODO", metodo.DAO.Rota);
                textoBase = textoBase.Replace("#OBJETORETORNO", base.CriaNomeObjetoRetornoMetodoController(metodo));
                textoBase = textoBase.Replace("#NOMEMETODO", base.CriaNomeMetodoController(metodo));    

            });

            return retorno;
        }

        /// <summary>
        /// Método que monta a query para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaQueryInterface(out string mensagemErro)
        {
            StringBuilder retorno = new StringBuilder();
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseQueryInterface_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                return new StringBuilder();
            }
            else if (!File.Exists(Util.Global.app_classesBaseQueryInterfaceFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da query - interface";
                return new StringBuilder();
            }
            else if (!File.Exists(Util.Global.app_classesBaseQueryInterfaceMetodosFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da query - interface";
                return new StringBuilder();
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta a query para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaQuery(out string mensagemErro)
        {
            StringBuilder retorno = new StringBuilder();
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseQuery_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                return new StringBuilder();
            }
            else if (!File.Exists(Util.Global.app_classesBaseQueryFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da query";
                return new StringBuilder();
            }
            else if (!File.Exists(Util.Global.app_classesBaseQueryMetodosFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da query";
                return new StringBuilder();
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta a repository para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaRepositoryInterface(out string mensagemErro)
        {
            StringBuilder retorno = new StringBuilder();
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseRepositoryInterface_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                return new StringBuilder();
            }
            else if (!File.Exists(Util.Global.app_classesBaseRepositoryInterfaceFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da repository";
                return new StringBuilder();
            }
            else if (!File.Exists(Util.Global.app_classesBaseRepositoryInterfaceMetodosFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da repository";
                return new StringBuilder();
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta a repository para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaRepository(out string mensagemErro)
        {
            StringBuilder retorno = new StringBuilder();
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseController_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                return new StringBuilder();
            }
            else if (!File.Exists(Util.Global.app_classesBaseRepositoryFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da repository";
                return new StringBuilder();
            }
            else if (!File.Exists(Util.Global.app_classesBaseRepositoryMetodosFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da repository";
                return new StringBuilder();
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta a DTO para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaDTO(out string mensagemErro)
        {
            StringBuilder retorno = new StringBuilder();
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseController_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                return new StringBuilder();
            }
            else if (!File.Exists(Util.Global.app_classesBaseDtoFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da DTO";
                return new StringBuilder();
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta a entity para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaEntity(out string mensagemErro)
        {
            StringBuilder retorno = new StringBuilder();
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseController_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                return new StringBuilder();
            }
            else if (!File.Exists(Util.Global.app_classesBaseEntityFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da Entity";
                return new StringBuilder();
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta a validation para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaValidation(out string mensagemErro)
        {
            StringBuilder retorno = new StringBuilder();
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseController_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                return new StringBuilder();
            }

            return retorno;
        }
    }
}
