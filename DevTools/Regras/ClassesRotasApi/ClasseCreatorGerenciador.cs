using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras.ClassesRotasApi
{
    class ClasseCreatorGerenciador : ClasseCreatorGeneric
    {
        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="rota"></param>
        public ClasseCreatorGerenciador(Model.MD_ApiRepository rota)
            : base(rota)
        {

        }

        /// <summary>
        /// Método que implementa a criação da classe
        /// </summary>
        /// <returns></returns>
        public override bool CriaClasses(out string mensagemErro)
        {
            mensagemErro = string.Empty;
            return true;
        }
    }
}
