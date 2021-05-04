
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
        List<Model.MD_RotasRepository> listaMetodos;

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="rota"></param>
        public ClasseCreatorRepository(Model.MD_ApiRepository rota)
            : base(rota)
        {
            listaMetodos = Model.MD_RotasRepository.RetornaMetodosApi(this.rota.DAO.Codigo);
        }

        /// <summary>
        /// Método que implementa a criação da classe
        /// </summary>
        /// <returns></returns>
        public override bool CriaClasses(out string mensagem)
        {
            bool retorno = true;
            mensagem = string.Empty;

            try
            {
                string mensagemErro = string.Empty;

                retorno &= MontaController(out mensagemErro);
                mensagem += mensagemErro;

                retorno &= MontaQueryInterface(out mensagemErro);
                mensagem += mensagemErro;

                retorno &= MontaQuery(out mensagemErro);
                mensagem += mensagemErro;

                retorno &= MontaRepositoryInterface(out mensagemErro);
                mensagem += mensagemErro;

                retorno &= MontaRepository(out mensagemErro);
                mensagem += mensagemErro;

                retorno &= MontaDTO(out mensagemErro);
                mensagem += mensagemErro;

                retorno &= MontaEntity(out mensagemErro);
                mensagem += mensagemErro;

                retorno &= MontaValidation(out mensagemErro);
                mensagem += mensagemErro;

                retorno &= MontaProfile(out mensagemErro);
                mensagem += mensagemErro;

            }
            catch (Exception e)
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
        private bool MontaController(out string mensagemErro)
        {
            bool retorno = true;
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseController_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base";
                retorno = false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseControllerFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base de controller";
                retorno = false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseControllerMetodosFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base de controller";
                retorno = false;
            }
            else
            {
                try
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

                    retorno = SalvarArquivo(nomeInterfaceQuery, textoBase, Util.Enumerator.TipoClasseRepository.CONTROLLER);

                    if (!retorno)
                    {
                        mensagemErro = "Erro ao criar o arquivo Query!" + Environment.NewLine;
                    }
                }
                catch(Exception e)
                {
                    retorno = false;
                    Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                }
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

            listaMetodos.ForEach(metodo =>
            {
                string textoBase = LeArquivo(Util.Global.app_classesBaseControllerMetodosFile);
                textoBase = textoBase.Replace("#ROTAMETODO", metodo.DAO.Rota);
                textoBase = textoBase.Replace("#OBJETORETORNO", base.CriaRetornoMetodoController(metodo));
                textoBase = textoBase.Replace("#NOMECLASSE", base.CriaNomeClasseController());
                textoBase = textoBase.Replace("#NOMEMETODO", base.CriaNomeMetodoController(metodo));
                textoBase = textoBase.Replace("#OBJETOSENTRADA", base.CriaObjetosEntradaMetodoController(metodo));
                textoBase = textoBase.Replace("#OBEJTOSVALIDACAOENTRADA", base.CriaOjetosValidacaoEntradaMetodoController(metodo));
                textoBase = textoBase.Replace("#NOMEVARIAVELINTERFACEQUERY", base.CriaNomeVariavelClasseQueryInterface());
                retorno += textoBase + Environment.NewLine;
                retorno += Environment.NewLine;
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta a query para o retorno
        /// </summary>
        /// <returns></returns>
        private bool MontaQueryInterface(out string mensagemErro)
        {
            bool retorno = true;
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseQueryInterface_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                retorno = false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseQueryInterfaceFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da query - interface";
                retorno = false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseQueryInterfaceMetodosFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da query - interface";
                retorno = false;
            }
            else
            {
                try
                {
                    string nomeInterfaceQuery = CriaNomeClasseQueryInterface();
                    string metodos = MontaMetodosQueryInterface();

                    string textoBase = LeArquivo(Util.Global.app_classesBaseQueryInterfaceFile);
                    textoBase = textoBase.Replace("#NOMEINTERFACEQUERY", nomeInterfaceQuery);
                    textoBase = textoBase.Replace("#METODOS", metodos);

                    retorno = SalvarArquivo(nomeInterfaceQuery, textoBase, Util.Enumerator.TipoClasseRepository.QUERYINTERFACE);

                    if (!retorno)
                    {
                        mensagemErro = "Erro ao criar o arquivo Interface Query!" + Environment.NewLine;
                    }
                }
                catch(Exception e)
                {
                    retorno = false;
                    Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta os métodos de query interface
        /// </summary>
        /// <returns></returns>
        private string MontaMetodosQueryInterface()
        {
            string retorno = string.Empty;

            listaMetodos.ForEach(metodo =>
            {
                string textoBase = LeArquivo(Util.Global.app_classesBaseQueryInterfaceMetodosFile);
                textoBase = textoBase.Replace("#OBJETORETORNO", base.CriaRetornoMetodoController(metodo));
                textoBase = textoBase.Replace("#NOMEMETODO", base.CriaNomeMetodoController(metodo));
                retorno += textoBase + Environment.NewLine;
                retorno += Environment.NewLine;
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta a query para o retorno
        /// </summary>
        /// <returns></returns>
        private bool MontaQuery(out string mensagemErro)
        {
            bool retorno = true;
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseQuery_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                retorno = false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseQueryFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da query";
                retorno = false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseQueryMetodosFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da query";
                retorno = false;
            }
            else
            {
                try
                {
                    string nomeImplementacaoQuery = CriaNomeClasseQuery();
                    string nomeInterfaceQuery = CriaNomeClasseQueryInterface();
                    string nomeInterfaceRepository = CriaNomeClasseRepositoryInterface();
                    string nomeVariavelInterfaceRepository = CriaNomeVariavelClasseRepositoryInterface();
                    string metodos = MontaMetodosQuery();

                    string textoBase = LeArquivo(Util.Global.app_classesBaseQueryFile);
                    textoBase = textoBase.Replace("#NOMEIMPLEMENTACAOQUERY", nomeImplementacaoQuery);
                    textoBase = textoBase.Replace("#NOMEINTERFACEQUERY", nomeInterfaceQuery);
                    textoBase = textoBase.Replace("#NOMEINTERFACEREPOSITORY", nomeInterfaceRepository);
                    textoBase = textoBase.Replace("#NOMEVARIAVELREPOSITORY", nomeVariavelInterfaceRepository);
                    textoBase = textoBase.Replace("#METODOS", metodos);

                    retorno = SalvarArquivo(nomeInterfaceQuery, textoBase, Util.Enumerator.TipoClasseRepository.QUERY);

                    if (!retorno)
                    {
                        mensagemErro = "Erro ao criar o arquivo Query!" + Environment.NewLine;
                    }
                }
                catch(Exception e)
                {
                    retorno = false;
                    Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta os metodos da query
        /// </summary>
        /// <returns></returns>
        private string MontaMetodosQuery()
        {
            string retorno = string.Empty;

            listaMetodos.ForEach(metodo =>
            {
                string textoBase = LeArquivo(Util.Global.app_classesBaseQueryMetodosFile);
                textoBase = textoBase.Replace("#OBJETORETORNO", base.CriaRetornoMetodoController(metodo));
                textoBase = textoBase.Replace("#NOMEMETODO", base.CriaNomeMetodoController(metodo));
                textoBase = textoBase.Replace("#NOMECLASSEVALIDATION", base.CriaNomeClasseValidation(metodo));
                textoBase = textoBase.Replace("#FILTROSREPOSITORY", base.CriaFiltrosRepositoryChamadaQuery(metodo));
                retorno += textoBase + Environment.NewLine;
                retorno += Environment.NewLine;
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta a repository para o retorno
        /// </summary>
        /// <returns></returns>
        private bool MontaRepositoryInterface(out string mensagemErro)
        {
            bool retorno = true;
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseRepositoryInterface_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                retorno = false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseRepositoryInterfaceFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da repository";
                retorno = false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseRepositoryInterfaceMetodosFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da repository";
                retorno = false;
            }
            else
            {
                try
                {
                    string nomeInterfaceRepository = CriaNomeClasseRepositoryInterface();
                    string metodos = MontaMetodosInterfaceRepository();

                    string textoBase = LeArquivo(Util.Global.app_classesBaseRepositoryInterfaceFile);
                    textoBase = textoBase.Replace("#NOMEINTERFACEREPOSITORY", nomeInterfaceRepository);
                    textoBase = textoBase.Replace("#METODOS", metodos);

                    retorno = SalvarArquivo(nomeInterfaceRepository, textoBase, Util.Enumerator.TipoClasseRepository.REPOSITORYINTERFACE);

                    if (!retorno)
                    {
                        mensagemErro = "Erro ao criar o arquivo Interface Repository!" + Environment.NewLine;
                    }
                }
                catch(Exception e)
                {
                    retorno = false;
                    Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Método que implementa os métodos da interface repository
        /// </summary>
        /// <returns></returns>
        private string MontaMetodosInterfaceRepository()
        {
            string retorno = string.Empty;

            listaMetodos.ForEach(metodo =>
            {
                string textoBase = LeArquivo(Util.Global.app_classesBaseRepositoryInterfaceMetodosFile);
                textoBase = textoBase.Replace("#COMENTARIOENTRADAS", base.CriaComentarioMetodoRepository(metodo));
                textoBase = textoBase.Replace("#RETORNOREPOSITORY", base.CriaRetornoRepository(metodo));
                textoBase = textoBase.Replace("#NOMEMETODOREPOSITORY", base.CriaNomeMetodoController(metodo));
                textoBase = textoBase.Replace("#FILTROSREPOSITORY", base.CriaFiltrosRepository(metodo));
                retorno += textoBase + Environment.NewLine;
                retorno += Environment.NewLine;
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta a repository para o retorno
        /// </summary>
        /// <returns></returns>
        private bool MontaRepository(out string mensagemErro)
        {
            bool retorno = true;
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseController_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                retorno = false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseRepositoryFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da repository";
                retorno = false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseRepositoryMetodosFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da repository";
                retorno = false;
            }
            else
            {
                try
                {
                    string nomeInterfaceRepository = CriaNomeClasseRepositoryInterface();
                    string nomeRepository = CriaNomeClasseRepository();
                    string metodos = MontaMetodosRepository();

                    string textoBase = LeArquivo(Util.Global.app_classesBaseRepositoryFile);
                    textoBase = textoBase.Replace("#NOMEINTERFACEREPOSITORY", nomeInterfaceRepository);
                    textoBase = textoBase.Replace("#NOMEREPOSITORY", nomeRepository);
                    textoBase = textoBase.Replace("#METODOREPOSITORY", metodos);

                    retorno = SalvarArquivo(nomeInterfaceRepository, textoBase, Util.Enumerator.TipoClasseRepository.REPOSITORY);

                    if (!retorno)
                    {
                        mensagemErro = "Erro ao criar o arquivo Repository!" + Environment.NewLine;
                    }
                }
                catch(Exception e)
                {
                    retorno = false;
                    Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta os métodos da repository
        /// </summary>
        /// <returns></returns>
        private string MontaMetodosRepository()
        {
            string retorno = string.Empty;

            listaMetodos.ForEach(metodo =>
            {
                string textoBase = LeArquivo(Util.Global.app_classesBaseRepositoryMetodosFile);
                textoBase = textoBase.Replace("#COMENTARIOENTRADAS", base.CriaComentarioMetodoRepository(metodo));
                textoBase = textoBase.Replace("#RETORNOREPOSITORY", base.CriaRetornoRepository(metodo));
                textoBase = textoBase.Replace("#NOMEMETODOREPOSITORY", base.CriaNomeMetodoController(metodo));
                textoBase = textoBase.Replace("#FILTROSREPOSITORY", base.CriaFiltrosRepository(metodo));
                textoBase = textoBase.Replace("#NOMEINTERFACEREPOSITORY", base.CriaNomeClasseRepositoryInterface());
                textoBase = textoBase.Replace("#COMENTARIOFILTROSENTRADA", base.CriaComentarioLogRepository(metodo));
                textoBase = textoBase.Replace("#CONSULTA", metodo.DAO.Consulta);
                textoBase = textoBase.Replace("#CLASSEENTITY", base.CriaRetornoRepository(metodo));
                textoBase = textoBase.Replace("#FILTROSCONSULTA", base.CriaFiltrosRepositoryConsulta(metodo));
                retorno += textoBase + Environment.NewLine;
                retorno += Environment.NewLine;
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta a DTO para o retorno
        /// </summary>
        /// <returns></returns>
        private bool MontaDTO(out string mensagemErro)
        {
            bool retorno = true;
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseController_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                return false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseDtoFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da DTO";
                return false;
            }
            else
            {
                string mensagem = string.Empty;
                try
                {
                    this.listaMetodos.ForEach(metodo =>
                    {
                        List<string> lista = new List<string>();
                        lista = base.MontaClassesBase(metodo, Util.Enumerator.TipoClasseBase.DTO);
                        lista.ForEach(texto =>
                        {
                            if (!SalvarArquivo(texto.Split('|')[0].Replace("Enumerator<", "").Replace("IList<", "").Replace(">", ""), texto.Split('|')[1], Util.Enumerator.TipoClasseRepository.DTO))
                            {
                                mensagem += "Erro ao gerar o arquivo " + texto.Split('|')[0] + " DTO!" + Environment.NewLine;
                            }
                        });
                    });
                }
                catch(Exception e)
                {
                    Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                    retorno = false;
                }

                mensagemErro += mensagem;
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta a entity para o retorno
        /// </summary>
        /// <returns></returns>
        private bool MontaEntity(out string mensagemErro)
        {
            bool retorno = true;
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseController_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                return false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseEntityFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base da Entity";
                return false;
            }
            else
            {
                string mensagem = string.Empty;
                try
                {
                    this.listaMetodos.ForEach(metodo =>
                    {
                        List<string> lista = new List<string>();
                        lista = base.MontaClassesBase(metodo, Util.Enumerator.TipoClasseBase.ENTITY);
                        lista.ForEach(texto =>
                        {
                            if (!SalvarArquivo(texto.Split('|')[0].Replace("Enumerator<", "").Replace("IList<", "").Replace(">", ""), texto.Split('|')[1], Util.Enumerator.TipoClasseRepository.ENTITY))
                            {
                                mensagem += "Erro ao gerar o arquivo " + texto.Split('|')[0] + " Entity!" + Environment.NewLine;
                            }
                        });
                    });
                }
                catch (Exception e)
                {
                    Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                    retorno = false;
                }

                mensagemErro += mensagem;
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta a validation para o retorno
        /// </summary>
        /// <returns></returns>
        private bool MontaValidation(out string mensagemErro)
        {
            bool retorno = true;
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseController_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                retorno = false;
            }
            else
            {
                try
                {
                    string textoBase = LeArquivo(Util.Global.app_classesBaseValidationFile);
                    string mensagem = string.Empty;
                    this.listaMetodos.ForEach(metodo => 
                    {
                        string nomeValidation = CriaNomeClasseValidation(metodo);

                        string texto = textoBase.Replace("#NOMECLASSEVALIDATION", nomeValidation);
                        retorno = SalvarArquivo(nomeValidation, texto, Util.Enumerator.TipoClasseRepository.VALIDATIONS);
                        if (!retorno)
                        {
                            mensagem += "Erro ao criar o validation!" + Environment.NewLine;
                        }
                    });

                    if (!string.IsNullOrEmpty(mensagem))
                    {
                        mensagemErro = mensagem;
                    }
                }
                catch (Exception e)
                {
                    retorno = false;
                    Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta os profiles
        /// </summary>
        /// <returns></returns>
        private bool MontaProfile(out string mensagemErro)
        {
            bool retorno = true;
            mensagemErro = string.Empty;

            if (!Directory.Exists(Util.Global.app_classesBaseProfile_directory))
            {
                mensagemErro += "Não foi encontrado o diretório base;";
                retorno = false;
            }
            else if (!File.Exists(Util.Global.app_classesBaseProfileFile))
            {
                mensagemErro += "Não foi encontrado o arquivo base";
                retorno = false;
            }
            else
            {
                try
                {
                    string mensagem = string.Empty;
                    this.listaMetodos.ForEach(metodo =>
                    {
                        List<string> lista = new List<string>();
                        lista = base.MontaClassesProfile(metodo);
                        lista.ForEach(texto =>
                        {
                            if (!SalvarArquivo(texto.Split('|')[0], texto.Split('|')[1], Util.Enumerator.TipoClasseRepository.PROFILES))
                            {
                                mensagem += "Erro ao gerar o arquivo " + texto.Split('|')[0] + " Profiles!" + Environment.NewLine;
                            }
                        });
                    });

                    if (!string.IsNullOrEmpty(mensagem))
                    {
                        mensagemErro = mensagem;
                    }
                }
                catch (Exception e)
                {
                    retorno = false;
                    Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                }
            }

            return retorno;
        }

    }
}
