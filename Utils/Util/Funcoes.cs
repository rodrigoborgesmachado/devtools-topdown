using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class Funcoes
    {

        /// <summary>
        /// Método que trata o CNPJ
        /// </summary>
        /// <param name="cnpj"></param>
        /// <returns></returns>
        public static string TrataCNPJ(string cnpj)
        {
            return cnpj.Replace(".", "").Replace("/", "").Replace("\\", "").Replace("-", "");
        }

        /// <summary>
        /// Método que sobe para o servidor o arquivo
        /// </summary>
        /// <param name="fileOrigem"></param>
        /// <param name="caminhoDestino"></param>
        /// <returns></returns>
        public static bool SubirParaServidor (string versao, string fileOrigem, string caminhoDestino)
        {
            bool retorno = true;
            try
            {
                FileInfo arquivoInfo = new FileInfo(fileOrigem);
                string url = Global.caminhoFtp + caminhoDestino + versao.Replace(".","") + arquivoInfo.Name;
                
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(url));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(Global.usuarioFtp, Global.senhaFtp);
                request.UseBinary = true;
                request.ContentLength = arquivoInfo.Length;
                using (FileStream fs = arquivoInfo.OpenRead())
                {
                    byte[] buffer = new byte[2048];
                    int bytesSent = 0;
                    int bytes = 0;

                    using (Stream stream = request.GetRequestStream())
                    {
                        while (bytesSent < arquivoInfo.Length)
                        {
                            bytes = fs.Read(buffer, 0, buffer.Length);
                            stream.Write(buffer, 0, bytes);
                            bytesSent += bytes;
                        }
                    }

                }
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro: " + e.Message, Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }
    }
}
