using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras.Relatorios
{
    public class RelatoriosBase
    {
        private Util.Enumerator.TipoRelatorio tipoRelatorio;

        public RelatoriosBase(Util.Enumerator.TipoRelatorio tipo)
        {
            this.tipoRelatorio = tipo;
        }

        /// <summary>
        /// Método que cria o relatório
        /// </summary>
        /// <param name="mensagemErro"></param>
        /// <returns></returns>
        public virtual bool CriarRelatorio(out string mensagemErro)
        {
            mensagemErro = string.Empty;
            return true;
        }

        /// <summary>
        /// Método que salva o arquivo
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="abrirArquivo"></param>
        /// <param name="mensagemErro"></param>
        /// <returns></returns>
        protected bool SalvarArquivo(string texto, bool abrirArquivo, out string mensagemErro)
        {
            bool retorno = true;
            mensagemErro = string.Empty;

            try
            {
                string caminhoRelatorio = RetornaCaminhoRelatorio();

                if (string.IsNullOrEmpty(caminhoRelatorio))
                {
                    mensagemErro = "O relatório não foi configurado";
                }
                else
                {
                    File.Delete(caminhoRelatorio);
                    File.AppendAllText(caminhoRelatorio, texto);

                    if (abrirArquivo)
                    {
                        System.Diagnostics.Process process = System.Diagnostics.Process.Start(caminhoRelatorio);
                    }
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
        /// Método que retorna o campo do relatório
        /// </summary>
        /// <returns></returns>
        protected string RetornaCaminhoRelatorio()
        {
            string retorno = string.Empty;

            switch (this.tipoRelatorio)
            {
                case Util.Enumerator.TipoRelatorio.PASSO_A_PASSO_REPOSITORY:
                    retorno = Util.Global.app_relatorio_passo_a_passoRepository;
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Método que cria o string builder completo do html
        /// </summary>
        /// <returns></returns>
        protected StringBuilder MontaHtml(string titulo, string conteudo, bool salvarPdf)
        {
            Util.CL_Files.WriteOnTheLog("ResumoPedido().RetornaHtmlCompleto()", Util.Global.TipoLog.DETALHADO);

            StringBuilder builder = new StringBuilder();

            builder.AppendLine("<!DOCTYPE html PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"https://www.w3.org/TR/html4/strict.dtd\">");
            builder.AppendLine("<html lang=\"pt-BR\">");
            builder.AppendLine("");
            builder.AppendLine("<head>");
            builder.AppendLine("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">");
            builder.AppendLine("    <style type=\"text/css\" nonce=\"\">");
            builder.AppendLine("        body,");
            builder.AppendLine("        td,");
            builder.AppendLine("        div,");
            builder.AppendLine("        p,");
            builder.AppendLine("        a,");
            builder.AppendLine("        input {");
            builder.AppendLine("            font-family: arial, sans-serif;");
            builder.AppendLine("        }");
            builder.AppendLine("    </style>");
            builder.AppendLine("    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
            builder.AppendLine("    <title>Resumo do Pedido</title>");
            builder.AppendLine("    <style type=\"text/css\" nonce=\"\">");
            builder.AppendLine("        body {");
            builder.AppendLine("            background: #FFFFE0");
            builder.AppendLine("        }");
            builder.AppendLine("        body,");
            builder.AppendLine("        td {");
            builder.AppendLine("            font-size: 13px");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        a:link,");
            builder.AppendLine("        a:active {");
            builder.AppendLine("            color: #1155CC;");
            builder.AppendLine("            text-decoration: none");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        a:hover {");
            builder.AppendLine("            text-decoration: underline;");
            builder.AppendLine("            cursor: pointer");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        a:visited {");
            builder.AppendLine("            color: ##6611CC");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        img {");
            builder.AppendLine("            border: 0px");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        pre {");
            builder.AppendLine("            white-space: pre;");
            builder.AppendLine("            white-space: -moz-pre-wrap;");
            builder.AppendLine("            white-space: -o-pre-wrap;");
            builder.AppendLine("            white-space: pre-wrap;");
            builder.AppendLine("            word-wrap: break-word;");
            builder.AppendLine("            max-width: 800px;");
            builder.AppendLine("            overflow: auto;");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        .logo {");
            builder.AppendLine("            left: -7px;");
            builder.AppendLine("            position: relative;");
            builder.AppendLine("        }");
            builder.AppendLine("    </style>");
            builder.AppendLine("    <style type=\"text/css\"></style>");
            builder.AppendLine("</head>");
            builder.AppendLine("");
            builder.AppendLine("<body>");
            builder.AppendLine("    <div class=\"bodycontainer\">");
            builder.AppendLine("        <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\">");
            builder.AppendLine("            <tbody>");
            builder.AppendLine("                <tr height=\"14px\">");
            builder.AppendLine("                    <td width=\"143\"> ");
            builder.AppendLine("                        <img src=\"./files/logonew.png\" width=\"100\" height=\"60\" alt=\"Gmail\" class=\"logo\">");
            builder.AppendLine("                            <b>SunSale System</b> ");
            builder.AppendLine("                    </td>");
            builder.AppendLine("                    <td align=\"right\">");
            builder.AppendLine("                        <font size=\"-1\" color=\"#777\">");
            builder.AppendLine("                            <b>SunSale System &lt;sunsalesystem@gmail.com&gt;</b>");
            builder.AppendLine("                        </font> ");
            builder.AppendLine("                    </td>");
            builder.AppendLine("                </tr>");
            builder.AppendLine("            </tbody>");
            builder.AppendLine("        </table>");
            builder.AppendLine("        <br>");
            builder.AppendLine("        <hr>");
            builder.AppendLine("        <div class=\"maincontent\">");
            builder.AppendLine("            <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\">");
            builder.AppendLine("                <tbody>");
            builder.AppendLine("                    <tr>");
            builder.AppendLine("                        <td colspan=\"2\">");
            builder.AppendLine("                            <center>");
            builder.AppendLine("                                <font size=\"+2\">");
            builder.AppendLine($"                                    <b>{titulo}</b>");
            builder.AppendLine("                                </font>");
            builder.AppendLine("                            </center>");
            builder.AppendLine("                            <br>");
            builder.AppendLine("                            <br>");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                    </tr>");
            builder.AppendLine("                </tbody> ");
            builder.AppendLine("            </table> ");
            builder.AppendLine("        </div> ");
            builder.AppendLine("        <div class=\"maincontent\">");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" class=\"message\">");
            builder.AppendLine("                <tbody>");
            builder.AppendLine("                    <tr>");
            builder.AppendLine("                        <td colspan=\"2\">");
            builder.AppendLine("                            <table width=\"100%\" cellpadding=\"12\" cellspacing=\"0\" border=\"0\">");
            builder.AppendLine("                                <tbody>");
            builder.AppendLine("                                    <tr>");
            builder.AppendLine("                                        <td>");
            builder.AppendLine($"                                        {conteudo}");
            builder.AppendLine("                                        </td>");
            builder.AppendLine("                                    </tr>");
            builder.AppendLine("                                </tbody>");
            builder.AppendLine("                            </table>");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                    </tr>");
            builder.AppendLine("                </tbody>");
            builder.AppendLine("            </table>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <hr>");
            builder.AppendLine("        </div>");
            builder.AppendLine("    </div>");

            if (salvarPdf)
            {
                builder.AppendLine("    <script type=\"text/javascript\" nonce=\"\">");
                builder.AppendLine("        document.body.onload = function() {");
                builder.AppendLine("            document.body.offsetHeight;");
                builder.AppendLine("            window.print()");
                builder.AppendLine("        };");
                builder.AppendLine("    </script>");
            }

            builder.AppendLine("</body>");
            builder.AppendLine("</html>");

            return builder;
        }
    }
}
