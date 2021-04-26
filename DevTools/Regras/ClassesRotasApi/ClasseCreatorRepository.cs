
using System;
using System.Collections.Generic;
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
        public override bool CriaClasses()
        {
            bool retorno = true;

            try
            {
                StringBuilder controllerBuilder = MontaController();
                StringBuilder queryInterface = MontaQueryInterface();
                StringBuilder query = MontaQuery();
                StringBuilder repositoryInterface = MontaRepositoryInterface();
                StringBuilder repository = MontaRepository();
                StringBuilder dto = MontaDTO();
                StringBuilder entity = MontaEntity();
                StringBuilder validation = MontaValidation();
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
        private StringBuilder MontaController()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno;
        }

        /// <summary>
        /// Método que monta a query para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaQueryInterface()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno;
        }

        /// <summary>
        /// Método que monta a query para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaQuery()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno;
        }

        /// <summary>
        /// Método que monta a repository para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaRepositoryInterface()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno;
        }

        /// <summary>
        /// Método que monta a repository para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaRepository()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno;
        }

        /// <summary>
        /// Método que monta a DTO para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaDTO()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno;
        }

        /// <summary>
        /// Método que monta a entity para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaEntity()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno;
        }

        /// <summary>
        /// Método que monta a validation para o retorno
        /// </summary>
        /// <returns></returns>
        private StringBuilder MontaValidation()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno;
        }
    }
}
