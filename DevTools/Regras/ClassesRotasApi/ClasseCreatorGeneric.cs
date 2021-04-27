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
        /// Método que cria o nome da classe
        /// </summary>
        /// <returns></returns>
        protected string CriaNomeClasseController()
        {
            return rota.DAO.NomeRota.Contains("Controller") ? rota.DAO.NomeRota : rota.DAO.NomeRota + "Controller";
        }

        /// <summary>
        /// Método que cria o nome da classe Query Interface
        /// </summary>
        /// <returns></returns>
        protected string CriaNomeClasseQueryInterface()
        {
            string retorno = rota.DAO.NomeRota[0].Equals('I') ? rota.DAO.NomeRota : "I" + rota.DAO.NomeRota;
            return retorno.Contains("Query") ? retorno : retorno + "Query";
        }

        /// <summary>
        /// Método que cria o nome da classe Query Interface
        /// </summary>
        /// <returns></returns>
        protected string CriaNomeVariavelClasseQueryInterface()
        {
            string retorno = CriaNomeClasseQueryInterface();
            return "_" + retorno[0].ToString().ToLower() + retorno.Substring(1);
        }

        /// <summary>
        /// Método que monta o nome de retorno do objeto do método
        /// </summary>
        /// <param name="metodo"></param>
        /// <returns></returns>
        protected string CriaNomeObjetoRetornoMetodoController(Model.MD_RotasRepository metodo)
        {
            string retorno = string.Empty;

            Model.MD_RetornoRotaRepository retornoRota = Model.MD_RetornoRotaRepository.RetornaRetornosMetodos(metodo.DAO.Codigo).FirstOrDefault();

            if(retornoRota != null)
            {
                retorno = retornoRota.DAO.TipoRetorno;
            }

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

            return retorno;
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
                textoBase += s;
            }

            return textoBase;
        }
    }
}
