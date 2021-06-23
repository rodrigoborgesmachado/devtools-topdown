using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras
{
    public static class RelatorioApi
    {
        /// <summary>
        /// Método que cria a documentação
        /// </summary>
        /// <param name="api"></param>
        /// <param name="mensagemErro"></param>
        /// <returns></returns>
        public static bool Criar (Model.MD_ApiRepository api, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            bool retorno = true;

            try
            {
                StringBuilder builder = new StringBuilder();
                builder = MontaTexto(api);

                MontaArquivo(builder);
            }
            catch(Exception e)
            {
                mensagemErro = e.Message;
                Util.CL_Files.WriteOnTheLog(mensagemErro, Util.Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta o arquivo
        /// </summary>
        private static void MontaArquivo(StringBuilder builder)
        {
            if (File.Exists(Util.Global.app_temp_html_file))
            {
                File.Delete(Util.Global.app_temp_html_file);
            }

            File.AppendAllText(Util.Global.app_temp_html_file, builder.ToString());
        }

        /// <summary>
        /// Método que monta o texto base
        /// </summary>
        /// <param name="api"></param>
        /// <param name="mensagemErro"></param>
        /// <returns></returns>
        private static StringBuilder MontaTexto(Model.MD_ApiRepository api)
        {
            StringBuilder builder = new StringBuilder();

            string texto = MontaTextoBase().ToString();

            texto = texto.Replace("#NOMEAPI", api.DAO.NomeRota);
            texto = texto.Replace("#DESCRICAOAPI", api.DAO.Descricao);
            texto = texto.Replace("#DATAHORACRIACAO", DateTime.Now.ToShortDateString());
            texto = texto.Replace("#APIS", MontaApisTexto(api).ToString());

            builder.AppendLine(texto);

            return builder;
        }

        /// <summary>
        /// Método que monta o texto base
        /// </summary>
        /// <returns></returns>
        private static StringBuilder MontaTextoBase()
        {
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
            builder.AppendLine("    <title>Descrição das Rotas - #NOMEAPI</title>");
            builder.AppendLine("    <style type=\"text/css\" nonce=\"\">");
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
            builder.AppendLine("            color: #6611CC");
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
            builder.AppendLine("    <div class=\"bodycontainer\" align=\"justify\">");
            builder.AppendLine("        <br>");
            builder.AppendLine("        <hr>");
            builder.AppendLine("        <div class=\"maincontent\">");
            builder.AppendLine("            <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\">");
            builder.AppendLine("                <tbody>");
            builder.AppendLine("                    <tr>");
            builder.AppendLine("                        <td> ");
            builder.AppendLine("                            <font size=\"+1\">");
            builder.AppendLine("                                <b>Descrição das rotas da api - #NOMEAPI</b>");
            builder.AppendLine("                            </font>");
            builder.AppendLine("                            <br>");
            builder.AppendLine("                            <font size=\"-1\" color=\"#777\">");
            builder.AppendLine("                                Descrição detalhada dos campos de entrada e retorno da API. ");
            builder.AppendLine("                                <br>");
            builder.AppendLine("                                #DESCRICAOAPI");
            builder.AppendLine("                            </font> ");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                        <td align=\"right\">");
            builder.AppendLine("                            <font size=\"-1\">");
            builder.AppendLine("                                #DATAHORACRIACAO");
            builder.AppendLine("                            </font>");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                    </tr>");
            builder.AppendLine("                </tbody>");
            builder.AppendLine("            </table>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            #APIS");
            builder.AppendLine("        </div>");
            builder.AppendLine("");
            builder.AppendLine("    </div>");
            builder.AppendLine("    <script type=\"text/javascript\" nonce=\"\">");
            builder.AppendLine("        document.body.onload = function() {");
            builder.AppendLine("            document.body.offsetHeight;");
            builder.AppendLine("            window.print()");
            builder.AppendLine("        };");
            builder.AppendLine("    </script>");
            builder.AppendLine("</body>");
            builder.AppendLine("");
            builder.AppendLine("</html>");
            builder.AppendLine("");

            return builder;
        }

        /// <summary>
        /// Método que monta o texto das apis
        /// </summary>
        /// <param name="api"></param>
        /// <returns></returns>
        private static StringBuilder MontaApisTexto(Model.MD_ApiRepository api)
        {
            StringBuilder builder = new StringBuilder();

            foreach(Model.MD_RotasRepository rota in Model.MD_RotasRepository.RetornaMetodosApi(api.DAO.Codigo))
            {
                builder.AppendLine("			<table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" class=\"message\">");
                builder.AppendLine("                <tbody>");
                builder.AppendLine("                    <tr>");
                builder.AppendLine("                        <td colspan=\"2\">");
                builder.AppendLine("                            <table width=\"100%\" cellpadding=\"12\" cellspacing=\"0\" border=\"0\">");
                builder.AppendLine("                                <tbody>");
                builder.AppendLine("                                    <tr>");
                builder.AppendLine("                                        <td>");
                builder.AppendLine("                                            <font size=\"-1\">");
                builder.AppendLine("                                                <b>Nome da rota:</b> " + rota.DAO.NomeMetodo);
                builder.AppendLine("                                                <br>");
                builder.AppendLine("                                                <b>Url de acesso:</b> " + (string.IsNullOrEmpty(rota.DAO.Rota) ? api.DAO.Rota : rota.DAO.Rota));
                builder.AppendLine("                                                <br>");
                builder.AppendLine("												<b>Tipo Requisição:</b> " + rota.DAO.TipoMetodo);
                builder.AppendLine("                                                <br>");
                builder.AppendLine("												<b>Consulta:</b> ");
                builder.AppendLine("                                                <br>");
                builder.AppendLine("                                                <textarea cols=\"100\" rows=\"" + (rota.DAO.Consulta.Length/100 + 1).ToString("00") + "\" style=\"background-color:#FCF5D8;color:#AD8C08;\" disable>");
                builder.AppendLine(rota.DAO.Consulta.Trim());
                builder.AppendLine("                                                </textarea>");
                builder.AppendLine("                                                <br>");
                builder.AppendLine("                                            </font>");
                builder.AppendLine("                                        </td>");
                builder.AppendLine("                                    </tr>");
                builder.AppendLine("                                    <tr>");
                builder.AppendLine("                                        <td>");
                builder.AppendLine("                                            <div style=\"overflow: hidden;\">");
                builder.AppendLine("                                                <font size=\"-1\">");
                builder.AppendLine("                                                    <div dir=\"ltr\">");
                builder.AppendLine("                                                        <ol>");
                builder.AppendLine("                                                            <li><b>Campos de entrada</b></li>");
                builder.AppendLine("                                                            <br>");
                builder.AppendLine("                                                            " + RetornaCamposEntrada(rota).ToString());
                builder.AppendLine("                                                            <br>");
                builder.AppendLine("                                                            <li><b>Campos de saída</b></li>");
                builder.AppendLine("                                                            <br>");
                builder.AppendLine("                                                            " + RetornaCamposSaida(rota).ToString());
                builder.AppendLine("                                                            <br>");
                builder.AppendLine("                                                        </ol>");
                builder.AppendLine("                                                    </div>");
                builder.AppendLine("                                                </font>");
                builder.AppendLine("                                            </div>");
                builder.AppendLine("                                        </td>");
                builder.AppendLine("                                    </tr>");
                builder.AppendLine("                                </tbody>");
                builder.AppendLine("                            </table>");
                builder.AppendLine("                        </td>");
                builder.AppendLine("                    </tr>");
                builder.AppendLine("                </tbody>");
                builder.AppendLine("            </table>");
                builder.AppendLine("			<br>");
                builder.AppendLine("            <br>");
                builder.AppendLine("            <br>");
                builder.AppendLine("            <hr> ");
            }

            return builder;
        }

        /// <summary>
        /// Método que monta os campos de entrada
        /// </summary>
        /// <param name="rota"></param>
        /// <returns></returns>
        private static StringBuilder RetornaCamposEntrada(Model.MD_RotasRepository rota)
        {
            StringBuilder builder = new StringBuilder();

            foreach(Model.MD_CamposEntrada campo in Model.MD_CamposEntrada.RetornaCamposEntradaRota(rota.DAO.Codigo))
            {
                builder.AppendLine("                                                            <ul>");
                builder.AppendLine("                                                                <li>");
                builder.AppendLine("                                                                " + campo.DAO.NomeCampoEntrada + " - <b>" + campo.DAO.TipoCampoEntrada + " - " + campo.DAO.TipoEntrada + "</b>");
                builder.AppendLine("                                                                </li>");
                builder.AppendLine("                                                            </ul>");
            }

            foreach(Model.MD_ClasseEntrada campo in Model.MD_ClasseEntrada.RetornaClassesEntradaRota(rota.DAO.Codigo))
            {
                builder.AppendLine(RetornaCamposClasseEntrada(campo));
            }

            return builder;
        }

        /// <summary>
        /// Método que retorna a descrição da classe
        /// </summary>
        /// <param name="classe"></param>
        /// <returns></returns>
        private static string RetornaCamposClasseEntrada(Model.MD_ClasseEntrada classe)
        {
            string retorno = string.Empty;
            retorno += "                                                             <ul>";
            retorno += "                                                                <li>";
            retorno += "                                                                " + classe.DAO.NomeClasse + " - <b>" + classe.DAO.TipoEntrada + "</b>";

            foreach (Model.MD_CamposClasseEntrada campo in Model.MD_CamposClasseEntrada.RetornaCamposClasseEntrada(classe.DAO.Codigo))
            {
                retorno += "                                                                   <ul>";
                retorno += "                                                                        <li>";
                retorno += "                                                                        " + campo.DAO.NomeCampo + " - <b>" + campo.DAO.TipoCampo + " - " + classe.DAO.TipoEntrada + "</b>";
                retorno += "                                                                        </li>";
                retorno += "                                                                    </ul>";
            }
            foreach (Model.MD_ClasseEntrada campo in Model.MD_ClasseEntrada.RetornaClassesFilhas(classe.DAO.Codigo))
            {
                retorno += RetornaCamposClasseEntrada(campo);
            }
            retorno += "                                                                </li>";
            retorno += "                                                             </ul>";

            return retorno;
        }

        /// <summary>
        /// Método que monta os campos de entrada
        /// </summary>
        /// <param name="rota"></param>
        /// <returns></returns>
        private static StringBuilder RetornaCamposSaida(Model.MD_RotasRepository rota)
        {
            StringBuilder builder = new StringBuilder();

            foreach (Model.MD_RetornoRotaRepository campo in Model.MD_RetornoRotaRepository.RetornaRetornosMetodos(rota.DAO.Codigo).Where(l => l.DAO.CodigoClasseRetorno != -1))
            {
                builder.AppendLine("                                                            <ul>");
                builder.AppendLine("                                                                <li>");
                builder.AppendLine("                                                                <b>Objeto - " + campo.DAO.TipoRetorno + "</b>");

                builder.AppendLine("                                                            <ul>");
                foreach (Model.MD_ClasseRetornoRepository campo2 in Model.MD_ClasseRetornoRepository.RetornaRetornosClasses(campo.DAO.Codigo))
                {
                    builder.AppendLine("                                                                <li>");
                    builder.AppendLine("                                                                " + campo2.DAO.Nome + " - <b>Classe</b>");

                    builder.AppendLine(RetornaCamposClasseSaida(campo2));

                    builder.AppendLine("                                                                </li>");
                }
                foreach (Model.MD_CamposClasseRetorno campoClasse in Model.MD_CamposClasseRetorno.RetornaRetornosCampoRota(campo.DAO.Codigo))
                {
                    builder.AppendLine("                                                                <li>");
                    builder.AppendLine("                                                                " + campoClasse.DAO.NomeCampo + " - <b>" + campoClasse.DAO.TipoCampo + "</b>");
                    builder.AppendLine("                                                                </li>");
                }
                builder.AppendLine("                                                            </ul>");
                builder.AppendLine("                                                                </li>");
                builder.AppendLine("                                                            </ul>");
            }
            foreach (Model.MD_RetornoRotaRepository campo in Model.MD_RetornoRotaRepository.RetornaRetornosMetodos(rota.DAO.Codigo).Where(l => l.DAO.CodigoClasseRetorno == -1))
            {
                builder.AppendLine("                                                            <ul>");
                builder.AppendLine("                                                                <li>");
                builder.AppendLine("                                                                <b>Campo - " + campo.DAO.TipoRetorno + "</b>");
                builder.AppendLine("                                                                </li>");
                builder.AppendLine("                                                            </ul>");
            }
            return builder;
        }

        /// <summary>
        /// Método que monta os campos da classe de saída
        /// </summary>
        /// <param name="classe"></param>
        /// <returns></returns>
        private static string RetornaCamposClasseSaida(Model.MD_ClasseRetornoRepository classe)
        {
            string retorno = string.Empty;

            retorno += "                                                             <ul>";
            retorno += "                                                                <li>";
            retorno += "                                                                " + classe.DAO.Nome + " - <b>Classe</b>";
            
            foreach (Model.MD_CamposClasseRetorno campo in Model.MD_CamposClasseRetorno.RetornaRetornosCampoClasses(classe.DAO.Codigo))
            {
                retorno += "                                                                   <ul>";
                retorno += "                                                                        <li>";
                retorno += "                                                                        " + campo.DAO.NomeCampo + " - <b>" + campo.DAO.TipoCampo + " - " + "</b>";
                retorno += "                                                                        </li>";
                retorno += "                                                                    </ul>";
            }
            foreach (Model.MD_ClasseRetornoRepository campo in Model.MD_ClasseRetornoRepository.RetornaRetornosClasses(classe.DAO.Codigo))
            {
                retorno += RetornaCamposClasseSaida(campo);
            }
            retorno += "                                                                </li>";
            retorno += "                                                             </ul>";

            return retorno;
        }

    }

}
