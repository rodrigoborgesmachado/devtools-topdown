using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras.Relatorios
{
    public class PassoAPassoRepository : RelatoriosBase
    {
        public PassoAPassoRepository()
            : base(Util.Enumerator.TipoRelatorio.PASSO_A_PASSO_REPOSITORY)
        {

        }

        /// <summary>
        /// Método que cria o relatório
        /// </summary>
        /// <param name="mensagemErro"></param>
        /// <returns></returns>
        public override bool CriarRelatorio(out string mensagemErro)
        {
            mensagemErro = string.Empty;
            bool retorno = true;

            try
            {
                string html = MontaHtml("Passo a Passo - Api Repositoy", MontaConteudo(), false).ToString();
                SalvarArquivo(html, false, out mensagemErro);

                if (!string.IsNullOrEmpty(mensagemErro))
                {
                    retorno = false;
                }
                else
                {
                    Visao.FO_WebPage web = new Visao.FO_WebPage(RetornaCaminhoRelatorio());
                    web.ShowDialog();
                }
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                mensagemErro = e.Message;
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta o conteúdo do relatório
        /// </summary>
        /// <returns></returns>
        private string MontaConteudo()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("                                                        Para a criação de uma rota as classes de saída devem ser colocadas nos diretórios corretos. A melhor forma de se fazer é adicionar os arquivos pelo visual studio. Caso já exista os arquivos, é necessário abrir os novos e ir copiando os métodos novos.");
            retorno.AppendLine("                                                        <br>");
            retorno.AppendLine("                                                        <br>");
            retorno.AppendLine("                                                        Arquivos de saída:");
            retorno.AppendLine("                                                        <br>");
            retorno.AppendLine("                                                        Classe controller disponível em: " + Util.Global.app_classesSaidaController_directory);
            retorno.AppendLine("                                                        <br>");
            retorno.AppendLine("                                                        Classes DTO disponível em: " + Util.Global.app_classesSaidaDto_directory);
            retorno.AppendLine("                                                        <br>");
            retorno.AppendLine("                                                        Classes Entity disponível em: " + Util.Global.app_classesSaidaEntity_directory);
            retorno.AppendLine("                                                        <br>");
            retorno.AppendLine("                                                        Classes Profile disponível em: " + Util.Global.app_classesBaseProfileFile);
            retorno.AppendLine("                                                        <br>");
            retorno.AppendLine("                                                        Classe Interface Repository disponível em: " + Util.Global.app_classesSaidaRepositoryInterface_directory);
            retorno.AppendLine("                                                        <br>");
            retorno.AppendLine("                                                        Classe Repository disponível em: " + Util.Global.app_classesSaidaRepository_directory);
            retorno.AppendLine("                                                        <br>");
            retorno.AppendLine("                                                        Classe Interface Query disponível em: " + Util.Global.app_classesSaidaQueryInterface_directory);
            retorno.AppendLine("                                                        <br>");
            retorno.AppendLine("                                                        Classe Query disponível em: " + Util.Global.app_classesSaidaQuery_directory);
            retorno.AppendLine("                                                        <br>");

            return retorno.ToString();
        }
    }
}
