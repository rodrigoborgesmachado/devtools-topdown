using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras.ClassesRotasApi
{
    public class MontaClasse
    {
        /// <summary>
        /// Atributos e Propriedades
        /// </summary>
        Util.Enumerator.ClassesApi tipoClasse;

        /// <summary>
        /// Método que cria as classes
        /// </summary>
        ClasseCreatorGeneric classeCreator;

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tipoClasse"></param>
        public MontaClasse(Util.Enumerator.ClassesApi tipoClasse, Model.MD_ApiRepository rota)
        {
            this.tipoClasse = tipoClasse;

            if(this.tipoClasse == Util.Enumerator.ClassesApi.GERENCIADOR)
            {
                this.classeCreator = new ClasseCreatorGerenciador(rota);
            }
            else
            {
                this.classeCreator = new ClasseCreatorRepository(rota);
            }
        }

        /// <summary>
        /// Método que cria as classes
        /// </summary>
        /// <returns></returns>
        public bool CriaClasses()
        {
            string mensagemErro = string.Empty;
            return this.classeCreator.CriaClasses(out mensagemErro);
        }

    }
}
