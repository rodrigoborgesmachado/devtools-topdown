using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras.ClassesRotasApi
{
    class ClasseCreatorGeneric
    {
        /// <summary>
        /// Rota para criar
        /// </summary>
        protected Model.MD_ApiRepository rota;

        public ClasseCreatorGeneric(Model.MD_ApiRepository rota)
        {
            this.rota = rota;
        }

        public virtual bool CriaClasses(out string mensagemErro)
        {
            mensagemErro = string.Empty;
            return true;
        }

        /// <summary>
        /// Método que monta o nome da variável
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        private string MontaPadraoVariavel(string nome)
        {
            if(nome.Count() < 2)
            {
                return string.Empty;
            }

            return nome[0].ToString().ToLower() + nome.Substring(1);
        }

        /// <summary>
        /// Método que monta o nome da variável
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        private string MontaPadraoClasseMetodoPropriedade(string nome)
        {
            if (nome.Count() < 2)
            {
                return string.Empty;
            }

            return nome[0].ToString().ToUpper() + nome.Substring(1);
        }

        /// <summary>
        /// Método que monta o tipo de entrada
        /// </summary>
        /// <param name="classe"></param>
        /// <returns></returns>
        private string MontaTipoEntrada(string tipoEntrada)
        {
            string retorno = string.Empty;

            if (tipoEntrada.Equals("Query"))
            {
                retorno = "[FromQuery]";
            }
            else if(tipoEntrada.Equals("FromBody"))
            {
                retorno = "[FromBody]";
            }
            else if (tipoEntrada.Equals("FromRoute"))
            {
                retorno = "[FromRoute]";
            }
            else if (tipoEntrada.Equals("Url"))
            {
                retorno = "";
            }

            return retorno;
        }

        /// <summary>
        /// Método que cria o nome da classe
        /// </summary>
        /// <returns></returns>
        protected string CriaNomeClasseController()
        {
            return MontaPadraoClasseMetodoPropriedade(rota.DAO.NomeRota.Contains("Controller") ? rota.DAO.NomeRota : rota.DAO.NomeRota + "Controller");
        }

        /// <summary>
        /// Método que cria o nome da classe Query Interface
        /// </summary>
        /// <returns></returns>
        protected string CriaNomeClasseQueryInterface()
        {
            string retorno = rota.DAO.NomeRota[0].Equals('I') ? rota.DAO.NomeRota : "I" + rota.DAO.NomeRota;
            if(retorno.Count() > 1)
            {
                retorno = retorno[0] + retorno[1].ToString().ToUpper() + retorno.Substring(2);
            }

            return MontaPadraoClasseMetodoPropriedade(retorno.Contains("Query") ? retorno : retorno + "Query");
        }

        /// <summary>
        /// Método que monta o nome da classe implementação query
        /// </summary>
        /// <returns></returns>
        protected string CriaNomeClasseQuery()
        {
            string retorno = rota.DAO.NomeRota;
            return MontaPadraoClasseMetodoPropriedade(retorno.Contains("Query") ? retorno : retorno + "Query");
        }

        /// <summary>
        /// Método que cria o nome da classe Query Interface
        /// </summary>
        /// <returns></returns>
        protected string CriaNomeClasseRepositoryInterface()
        {
            string retorno = rota.DAO.NomeRota[0].Equals('I') ? rota.DAO.NomeRota : "I" + rota.DAO.NomeRota;
            if (retorno.Count() > 1)
            {
                retorno = retorno[0] + retorno[1].ToString().ToUpper() + retorno.Substring(2);
            }

            return MontaPadraoClasseMetodoPropriedade(retorno.Contains("Repository") ? retorno : retorno + "Repository");
        }

        /// <summary>
        /// Método que cria o nome da classe Query Interface
        /// </summary>
        /// <returns></returns>
        protected string CriaNomeClasseRepository()
        {
            string retorno = rota.DAO.NomeRota[0].Equals('I') ? rota.DAO.NomeRota.Substring(1) : rota.DAO.NomeRota;
            return MontaPadraoClasseMetodoPropriedade(retorno.Contains("Repository") ? retorno : retorno + "Repository");
        }

        /// <summary>
        /// Método que monta o nome da classe implementação query
        /// </summary>
        /// <returns></returns>
        protected string CriaNomeClasseImplementacaoRepository()
        {
            string retorno = rota.DAO.NomeRota;
            return MontaPadraoClasseMetodoPropriedade(retorno.Contains("Repository") ? retorno : retorno + "Repository");
        }

        /// <summary>
        /// Método que cria o nome da classe Query Interface
        /// </summary>
        /// <returns></returns>
        protected string CriaNomeVariavelClasseQueryInterface()
        {
            string retorno = CriaNomeClasseQueryInterface();
            if (retorno.Count() < 2)
                return string.Empty;

            return "_" + retorno[0].ToString().ToLower() + retorno.Substring(1);
        }

        /// <summary>
        /// Método que cria o nome da classe Query Interface
        /// </summary>
        /// <returns></returns>
        protected string CriaNomeVariavelClasseRepositoryInterface()
        {
            string retorno = CriaNomeClasseRepositoryInterface();
            if (retorno.Count() < 2)
                return string.Empty;

            return "_" + retorno[0].ToString().ToLower() + retorno.Substring(1);
        }

        /// <summary>
        /// Método que monta o nome de retorno do objeto do método
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaRetornoMetodoController(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;

            Model.MD_RetornoRotaRepository retornoRota = Model.MD_RetornoRotaRepository.RetornaRetornosMetodos(metodo.DAO.Codigo).FirstOrDefault();

            if(retornoRota != null)
            {
                retorno = CriaRetornoMetodoController(retornoRota.DAO.TipoRetorno);
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta o nome de retorno do objeto do método
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaRetornoMetodoController(string nome)
        {
            string retorno = string.Empty;

            retorno = nome;
            string[] lista = retorno.Split('>');
            retorno = lista[0].Contains("DTO") ? lista[0] : lista[0] + "DTO";

            int i = 1;
            while (i < lista.Count())
            {
                retorno += ">";
                i++;
            }

            retorno = MontaPadraoClasseMetodoPropriedade(retorno);

            return retorno;
        }

        /// <summary>
        /// Método que monta o nome de retorno do objeto do método
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaRetornoRepository(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;

            Model.MD_RetornoRotaRepository retornoRota = Model.MD_RetornoRotaRepository.RetornaRetornosMetodos(metodo.DAO.Codigo).FirstOrDefault();

            if (retornoRota != null)
            {
                retorno = CriaRetornoRepository(retornoRota.DAO.TipoRetorno);
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta o nome de retorno do objeto do método
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaRetornoRepository(string nome)
        {
            string retorno = string.Empty;

            retorno = nome;
            string[] lista = retorno.Split('>');
            retorno = lista[0].Contains("Entity") ? lista[0] : lista[0] + "Entity";

            int i = 1;
            while (i < lista.Count())
            {
                retorno += ">";
                i++;
            }
            retorno = retorno.Contains("DTO") ? retorno.Replace("DTO", "") : retorno;
            retorno = MontaPadraoClasseMetodoPropriedade(retorno);

            return retorno;
        }

        /// <summary>
        /// Método que cria o nome do método do controller
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaNomeMetodoController(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;
            retorno =  metodo.DAO.NomeMetodo.Contains("Async") ? metodo.DAO.NomeMetodo : metodo.DAO.NomeMetodo + "Async";

            return MontaPadraoClasseMetodoPropriedade(retorno);
        }
        
        /// <summary>
        /// Método que cria o nome do método do controller
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaNomeClasseValidation(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;

            retorno = metodo.DAO.NomeMetodo.Contains("Validation") ? metodo.DAO.NomeMetodo : metodo.DAO.NomeMetodo + "Validation";
            retorno = retorno.Contains("Async") ? retorno.Replace("Async", "") : retorno;

            return MontaPadraoClasseMetodoPropriedade(retorno);
        }

        /// <summary>
        /// Método que cria o nome do método do controller
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaNomeClasseProfile(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;

            retorno = metodo.DAO.NomeMetodo.Contains("Validation") ? metodo.DAO.NomeMetodo : metodo.DAO.NomeMetodo + "Validation";
            retorno = retorno.Contains("Async") ? retorno.Replace("Async", "") : retorno;

            return MontaPadraoClasseMetodoPropriedade(retorno);
        }

        /// <summary>
        /// Método que cria o nome do método do controller
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaNomeClasseValidation(string nomeValidation)
        {
            string retorno = string.Empty;

            retorno = nomeValidation.Contains("Validation") ? nomeValidation : nomeValidation + "Validation";
            retorno = retorno.Contains("Async") ? retorno.Replace("Async", "") : retorno;

            return MontaPadraoClasseMetodoPropriedade(retorno);
        }

        /// <summary>
        /// Método que cria o filtro para chamada da repository pela query
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaFiltrosRepositoryChamadaQuery(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;

            List<Model.MD_ClasseEntrada> listaClassesEntrada = Model.MD_ClasseEntrada.RetornaClassesEntradaRota(metodo.DAO.Codigo);
            int i = 0;
            listaClassesEntrada.ForEach(classe =>
            {
                if (i > 0) retorno += ", ";
                retorno += "filter." + MontaPadraoClasseMetodoPropriedade(classe.DAO.NomeClasse.Split('=')[0].Trim());
                i++;
            });

            List<Model.MD_CamposEntrada> listaCampos = Model.MD_CamposEntrada.RetornaCamposEntradaRota(metodo.DAO.Codigo);
            listaCampos.ForEach(campo =>
            {
                if (i > 0) retorno += ", ";
                retorno += "filter." + MontaPadraoClasseMetodoPropriedade(campo.DAO.NomeCampoEntrada.Split('=')[0].Trim());
                i++;
            });

            return retorno;
        }

        /// <summary>
        /// Método que cria o filtro para chamada da repository pela query
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaFiltrosRepositoryConsulta(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;

            List<Model.MD_ClasseEntrada> listaClassesEntrada = Model.MD_ClasseEntrada.RetornaClassesEntradaRota(metodo.DAO.Codigo);
            int i = 0;
            listaClassesEntrada.ForEach(classe =>
            {
                if (i > 0) retorno += ", ";
                retorno += MontaPadraoVariavel(classe.DAO.NomeClasse.Split('=')[0].Trim());
                i++;
            });

            List<Model.MD_CamposEntrada> listaCampos = Model.MD_CamposEntrada.RetornaCamposEntradaRota(metodo.DAO.Codigo);
            listaCampos.ForEach(campo =>
            {
                if (i > 0) retorno += ", ";
                retorno += MontaPadraoVariavel(campo.DAO.NomeCampoEntrada.Split('=')[0].Trim());
                i++;
            });

            return retorno;
        }

        /// <summary>
        /// Método que cria o filtro para chamada da repository pela query
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaFiltrosRepository(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;

            List<Model.MD_ClasseEntrada> listaClassesEntrada = Model.MD_ClasseEntrada.RetornaClassesEntradaRota(metodo.DAO.Codigo);
            int i = 0;
            listaClassesEntrada.ForEach(classe =>
            {
                if (i > 0) retorno += ", ";
                retorno += classe.DAO.TipoClasse + " " + MontaPadraoVariavel(classe.DAO.NomeClasse.Split('=')[0].Trim());
                i++;
            });

            List<Model.MD_CamposEntrada> listaCampos = Model.MD_CamposEntrada.RetornaCamposEntradaRota(metodo.DAO.Codigo);
            listaCampos.ForEach(campo =>
            {
                if (i > 0) retorno += ", ";
                retorno += campo.DAO.TipoCampoEntrada + " " + MontaPadraoVariavel(campo.DAO.NomeCampoEntrada.Split('=')[0].Trim());
                i++;
            });

            return retorno;
        }

        /// <summary>
        /// Método que cria o filtro para chamada da repository pela query
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaComentarioMetodoRepository(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;

            List<Model.MD_ClasseEntrada> listaClassesEntrada = Model.MD_ClasseEntrada.RetornaClassesEntradaRota(metodo.DAO.Codigo);
            int i = 0;
            listaClassesEntrada.ForEach(classe =>
            {
                if (i > 0) retorno += Environment.NewLine;
                retorno += "        /// <param name=\"" + MontaPadraoVariavel(classe.DAO.NomeClasse.Split('=')[0].Trim()) + "\"></param>";
                i++;
            });

            List<Model.MD_CamposEntrada> listaCampos = Model.MD_CamposEntrada.RetornaCamposEntradaRota(metodo.DAO.Codigo);
            listaCampos.ForEach(campo =>
            {
                if (i > 0) retorno += Environment.NewLine;
                retorno += "        /// <param name=\"" + MontaPadraoVariavel(campo.DAO.NomeCampoEntrada.Split('=')[0].Trim()) + "\"></param>";
                i++;
            });

            return retorno;
        }
        
        /// <summary>
        /// Método que cria o filtro para chamada da repository pela query
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaComentarioLogRepository(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;

            List<Model.MD_ClasseEntrada> listaClassesEntrada = Model.MD_ClasseEntrada.RetornaClassesEntradaRota(metodo.DAO.Codigo);
            int i = 0;
            listaClassesEntrada.ForEach(classe =>
            {
                if (i > 0) retorno += " | ";
                retorno += MontaPadraoVariavel(classe.DAO.NomeClasse.Split('=')[0].Trim()) +  " {" + MontaPadraoVariavel(classe.DAO.NomeClasse.Split('=')[0].Trim()) + "}";
                i++;
            });

            List<Model.MD_CamposEntrada> listaCampos = Model.MD_CamposEntrada.RetornaCamposEntradaRota(metodo.DAO.Codigo);
            listaCampos.ForEach(campo =>
            {
                if (i > 0) retorno += " | ";
                retorno += MontaPadraoVariavel(campo.DAO.NomeCampoEntrada.Split('=')[0].Trim()) + " {" + MontaPadraoVariavel(campo.DAO.NomeCampoEntrada.Split('=')[0].Trim()) + "}";
                i++;
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta os objetos de entrada do método
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaObjetosEntradaMetodoController(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;
            List<Model.MD_ClasseEntrada> listaClassesEntrada = Model.MD_ClasseEntrada.RetornaClassesEntradaRota(metodo.DAO.Codigo);
            int i = 0;
            listaClassesEntrada.ForEach(classe =>
            {
                if (i > 0) retorno += ", ";
                retorno += MontaTipoEntrada(classe.DAO.TipoEntrada);
                retorno += classe.DAO.TipoClasse + " ";
                retorno += MontaPadraoVariavel(classe.DAO.NomeClasse);

                i++;
            });

            List<Model.MD_CamposEntrada> listaCampos = Model.MD_CamposEntrada.RetornaCamposEntradaRota(metodo.DAO.Codigo);
            listaCampos.ForEach(campo =>
            {
                if (i > 0) retorno += ", ";
                retorno += MontaTipoEntrada(campo.DAO.TipoEntrada);
                retorno += campo.DAO.TipoCampoEntrada + " ";
                retorno += MontaPadraoVariavel(campo.DAO.NomeCampoEntrada);

                i++;
            });

            return retorno;
        }

        /// <summary>
        /// Cria variaveis de entrada e validação dos campos corretos
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaOjetosValidacaoEntradaMetodoController(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;

            List<Model.MD_ClasseEntrada> listaClassesEntrada = Model.MD_ClasseEntrada.RetornaClassesEntradaRota(metodo.DAO.Codigo);
            int i = 0;
            listaClassesEntrada.ForEach(classe =>
            {
                if (i > 0) retorno += ", " + Environment.NewLine ;
                retorno += "                    " + MontaPadraoClasseMetodoPropriedade(classe.DAO.NomeClasse.Split('=')[0].Trim()) + " = " + MontaPadraoVariavel(classe.DAO.NomeClasse.Split('=')[0].Trim());
                i++;
            });

            List<Model.MD_CamposEntrada> listaCampos = Model.MD_CamposEntrada.RetornaCamposEntradaRota(metodo.DAO.Codigo);
            listaCampos.ForEach(campo =>
            {
                if (i > 0) retorno += ", " + Environment.NewLine;
                retorno += "                    " + MontaPadraoClasseMetodoPropriedade(campo.DAO.NomeCampoEntrada.Split('=')[0].Trim()) + " = " + MontaPadraoVariavel(campo.DAO.NomeCampoEntrada.Split('=')[0].Trim());
                i++;
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta os campos para DTO e Entity
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected List<string> MontaClassesBase(Model.MD_RotasRepository metodo, Util.Enumerator.TipoClasseBase tipo)
        {
            List<string> retorno = new List<string>();

            List<Model.MD_ClasseEntrada> listaClassesSaida = Model.MD_ClasseEntrada.RetornaClassesEntradaRota(metodo.DAO.Codigo);
            listaClassesSaida.ForEach(classe =>
            {
                retorno.AddRange(MontaClasse(classe, tipo));
            });

            List<Model.MD_ClasseRetornoRepository> listaCampos = Model.MD_ClasseRetornoRepository.RetornaRetornosClasses(metodo.DAO.Codigo);
            listaCampos.ForEach(campo =>
            {
                retorno.AddRange(MontaClasse(campo, tipo));
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta a classe base
        /// </summary>
        /// <param name="classe"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private List<string> MontaClasse(Model.MD_ClasseRetornoRepository classe, Util.Enumerator.TipoClasseBase tipo)
        {
            List<string> retorno = new List<string>();

            List<Model.MD_ClasseRetornoRepository> listaClassesSaida = Model.MD_ClasseRetornoRepository.RetornaRetornosClasses(classe.DAO.Codigo);
            listaClassesSaida.ForEach(cl =>
            {
                retorno.AddRange(MontaClasse(cl, tipo));
            });

            List<Model.MD_CamposClasseRetorno> campos = Model.MD_CamposClasseRetorno.RetornaRetornosCampoClasses(classe.DAO.Codigo);
            string camposTexto = string.Empty;
            campos.ForEach(campo => 
            {
                camposTexto += "		" + MontaTextoPropriedadePadrao(campo.DAO.NomeCampo, campo.DAO.TipoCampo) + Environment.NewLine;
            });

            retorno.Add(classe.DAO.Nome + "|" + (tipo == Util.Enumerator.TipoClasseBase.DTO ? MontaTextoBase(classe.DAO.Nome, camposTexto) : MontaTextoEntity(classe.DAO.Nome, camposTexto)));

            return retorno;
        }

        /// <summary>
        /// Método que monta a classe base
        /// </summary>
        /// <param name="classe"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private List<string> MontaClasse(Model.MD_ClasseEntrada classe, Util.Enumerator.TipoClasseBase tipo)
        {
            List<string> retorno = new List<string>();

            List<Model.MD_ClasseEntrada> listaClassesSaida = Model.MD_ClasseEntrada.RetornaClassesFilhas(classe.DAO.Codigo);
            listaClassesSaida.ForEach(cl =>
            {
                retorno.AddRange(MontaClasse(cl, tipo));
            });

            List<Model.MD_CamposClasseEntrada> campos = Model.MD_CamposClasseEntrada.RetornaCamposClasseEntrada(classe.DAO.Codigo);
            string camposTexto = string.Empty;
            campos.ForEach(campo =>
            {
                camposTexto += "		" + MontaTextoPropriedadePadrao(campo.DAO.NomeCampo, campo.DAO.TipoCampo) + Environment.NewLine;
            });

            retorno.Add(classe.DAO.NomeClasse + "|" + (tipo == Util.Enumerator.TipoClasseBase.DTO ? MontaTextoBase(classe.DAO.NomeClasse, camposTexto) : MontaTextoEntity(classe.DAO.NomeClasse, camposTexto)));
            return retorno;
        }

        /// <summary>
        /// Método que monta as classes profile
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected List<string> MontaClassesProfile(Model.MD_RotasRepository metodo)
        {
            List<string> retorno = new List<string>();

            List<Model.MD_ClasseEntrada> listaClassesSaida = Model.MD_ClasseEntrada.RetornaClassesEntradaRota(metodo.DAO.Codigo);
            listaClassesSaida.ForEach(classe =>
            {
                retorno.AddRange(MontaClasseProfile(classe));
            });

            List<Model.MD_ClasseRetornoRepository> listaCampos = Model.MD_ClasseRetornoRepository.RetornaRetornosClasses(metodo.DAO.Codigo);
            listaCampos.ForEach(campo =>
            {
                retorno.AddRange(MontaClasseProfile(campo));
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta a classe base
        /// </summary>
        /// <param name="classe"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private List<string> MontaClasseProfile(Model.MD_ClasseRetornoRepository classe)
        {
            List<string> retorno = new List<string>();

            List<Model.MD_ClasseRetornoRepository> listaClassesSaida = Model.MD_ClasseRetornoRepository.RetornaRetornosClasses(classe.DAO.Codigo);
            listaClassesSaida.ForEach(cl =>
            {
                MontaClasseProfile(cl);
            });

            string nomeClasse = MontaNomeClasseProfile(classe.DAO.Nome);
            retorno.Add(nomeClasse + "|" + MontaTextoProfile(nomeClasse, CriaRetornoRepository(classe.DAO.Nome), CriaRetornoMetodoController(classe.DAO.Nome)));

            return retorno;
        }

        /// <summary>
        /// Método que monta a classe base
        /// </summary>
        /// <param name="classe"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private List<string> MontaClasseProfile(Model.MD_ClasseEntrada classe)
        {
            List<string> retorno = new List<string>();

            List<Model.MD_ClasseEntrada> listaClassesSaida = Model.MD_ClasseEntrada.RetornaClassesFilhas(classe.DAO.Codigo);
            listaClassesSaida.ForEach(cl =>
            {
                string nomeClasse = MontaNomeClasseProfile(cl.DAO.NomeClasse);
                retorno.Add(nomeClasse + "|" + MontaTextoProfile(nomeClasse, CriaRetornoRepository(classe.DAO.NomeClasse), CriaRetornoMetodoController(classe.DAO.NomeClasse)));
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta o nome da classe profile
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        private string MontaNomeClasseProfile(string nome)
        {
            string retorno = string.Empty;

            nome = nome.Replace("DTO", string.Empty);
            nome = nome.Replace("Entity", string.Empty);
            nome = nome.Replace("IList<", string.Empty);
            nome = nome.Replace(">", string.Empty);
            retorno = nome + "EntityTo" + nome + "DTO";

            return MontaPadraoClasseMetodoPropriedade(retorno);
        }

        /// <summary>
        /// Método que monta o texto com a propriedade padrão
        /// </summary>
        /// <param name="nomeVariavel"></param>
        /// <param name="tipoVariavel"></param>
        /// <returns></returns>
        private string MontaTextoPropriedadePadrao(string nomeVariavel, string tipoVariavel)
        {
            string retorno = string.Empty;

            retorno += "public " + tipoVariavel + " " + nomeVariavel + " { get; set; }";

            return retorno;
        }

        /// <summary>
        /// Método que monta o texto do DTO e Entity
        /// </summary>
        /// <param name="nomeClasse"></param>
        /// <param name="campos"></param>
        /// <returns></returns>
        private string MontaTextoBase(string nomeClasse, string campos)
        {
            string texto = LeArquivo(Util.Global.app_classesBaseDtoFile);

            nomeClasse = CriaRetornoMetodoController(nomeClasse);

            texto = texto.Replace("#NOMECLASSEDTO", nomeClasse);
            texto = texto.Replace("#CAMPOSDTO", campos);

            return texto;
        }

        /// <summary>
        /// Método que monta o texto do Profile
        /// </summary>
        /// <param name="nomeProfile"></param>
        /// <param name="classeEntity"></param>
        /// <param name="classeDto"></param>
        /// <returns></returns>
        private string MontaTextoProfile(string nomeProfile, string classeEntity, string classeDto)
        {
            string texto = LeArquivo(Util.Global.app_classesBaseProfileFile);

            nomeProfile = CriaRetornoMetodoController(nomeProfile);
            texto = texto.Replace("#NOMEPROFILE", nomeProfile);

            classeEntity = classeEntity.Replace("DTO", string.Empty);
            classeEntity = classeEntity.Replace("IList<", string.Empty);
            classeEntity = classeEntity.Replace(">", string.Empty);
            texto = texto.Replace("#CLASSEENTITY", classeEntity);

            classeDto = classeDto.Replace("Entity", string.Empty);
            classeDto = classeDto.Replace("IList<", string.Empty);
            classeDto = classeDto.Replace(">", string.Empty);
            texto = texto.Replace("#CLASSEDTO", classeDto);

            return texto;
        }

        /// <summary>
        /// Método que monta o texto do DTO
        /// </summary>
        /// <param name="nomeClasse"></param>
        /// <param name="campos"></param>
        /// <returns></returns>
        private string MontaTextoEntity(string nomeClasse, string campos)
        {
            string texto = LeArquivo(Util.Global.app_classesBaseDtoFile);

            nomeClasse = CriaRetornoRepository(nomeClasse);

            texto = texto.Replace("#NOMECLASSEDTO", nomeClasse);
            texto = texto.Replace("#CAMPOSDTO", campos);

            return texto;
        }

        /// <summary>
        /// Método que lê o arquivo e retorna o texto
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        protected string LeArquivo(string path)
        {
            if (!File.Exists(path))
            {
                return string.Empty;
            }

            string[] lista = File.ReadAllLines(path);
            string textoBase = string.Empty;

            foreach (string s in lista)
            {
                textoBase += s + Environment.NewLine;
            }

            return textoBase;
        }

        /// <summary>
        /// Método que salva o arquivos
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        protected bool SalvarArquivo(string nomeArquivo, string texto, Util.Enumerator.TipoClasseRepository tipo)
        {
            bool retorno = true;
            string caminhoArquivo = string.Empty;

            switch (tipo)
            {
                case Util.Enumerator.TipoClasseRepository.CONTROLLER:
                    caminhoArquivo = Util.Global.app_classesSaidaController_directory + CriaNomeClasseController();
                    break;
                case Util.Enumerator.TipoClasseRepository.DTO:
                    caminhoArquivo = Util.Global.app_classesSaidaDto_directory + CriaRetornoMetodoController(nomeArquivo);
                    break;
                case Util.Enumerator.TipoClasseRepository.ENTITY:
                    caminhoArquivo = Util.Global.app_classesSaidaEntity_directory + CriaRetornoRepository(nomeArquivo);
                    break;
                case Util.Enumerator.TipoClasseRepository.QUERY:
                    caminhoArquivo = Util.Global.app_classesSaidaQuery_directory + CriaNomeClasseQuery();
                    break;
                case Util.Enumerator.TipoClasseRepository.QUERYINTERFACE:
                    caminhoArquivo = Util.Global.app_classesSaidaQueryInterface_directory + CriaNomeClasseQueryInterface();
                    break;
                case Util.Enumerator.TipoClasseRepository.REPOSITORY:
                    caminhoArquivo = Util.Global.app_classesSaidaRepository_directory + CriaNomeClasseRepository();
                    break;
                case Util.Enumerator.TipoClasseRepository.REPOSITORYINTERFACE:
                    caminhoArquivo = Util.Global.app_classesSaidaRepositoryInterface_directory + CriaNomeClasseRepositoryInterface();
                    break;
                case Util.Enumerator.TipoClasseRepository.VALIDATIONS:
                    caminhoArquivo = Util.Global.app_classesSaidaValidations_directory + CriaNomeClasseValidation(nomeArquivo);
                    break;
                case Util.Enumerator.TipoClasseRepository.PROFILES:
                    caminhoArquivo = Util.Global.app_classesSaidaProfile_directory + nomeArquivo;
                    break;
            }

            caminhoArquivo += ".cs";

            try
            {
                File.Delete(caminhoArquivo);
                File.AppendAllText(caminhoArquivo, texto);
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }

    }
}
