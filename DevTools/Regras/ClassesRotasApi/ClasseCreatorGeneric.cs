using System;
using System.Collections.Generic;
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
        Model.MD_ApiRepository rota;

        public ClasseCreatorGeneric(Model.MD_ApiRepository rota)
        {
            this.rota = rota;
        }

        public virtual bool CriaClasses()
        {
            return true;
        }
    }
}
