		/// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("#ROTA")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<#RETORNO>> #NOMEMETODO(#ENTRADAMETODOCONTROLLER)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                _logger.LogDebug($"[{nameof(#NOMECLASSE)}] iniciando método {nameof(#NOMEMETODO)} -> #COMENTARIOENTRADAMETODOCONTROLLER");

                var retorno = await ExecutarGet<ResponseDTO<#REPOSITORYRETORNO>, IList<ErrorResponse>, #RETORNO>(
                  url: #VARIAVELCONFIGURATION.URL,
                  resourceName: #URL,
                  authentication: #VARIAVELCONFIGURATION.BasicAuthentication,
                  timeoutInSeconds: #VARIAVELCONFIGURATION.TimeoutInSeconds ?? 0,
                  actionErro: (task) =>
                  {
                      _logger.LogDebug($"[{nameof(#NOMECLASSE)}] executando tratamento de erro...");

                      return new #RETORNO
                      {
                          MensagemRetorno = (task?.CallbackErrors?.Any() == true) ?
                                      string.Join(". ", task.CallbackErrors.MappErros(#VARIAVELCONFIGURATION.ServiceName)) :
                                      string.Join(". ", task.Errors),
                          Sucesso = false
                      };

                  },
                  actionException: (ex) =>
                  {
                      _logger.LogDebug($"[{nameof(#NOMECLASSE)}] executando tratamento de exception...");

                      return new #RETORNO
                      {
                          MensagemRetorno = ex.Message,
                          Sucesso = false
                      };
                  });

                return retorno;
            }
            finally
            {
                stopwatch.Stop();
                _logger.LogDebug($"[{nameof(#NOMECLASSE)}] finalizando método {nameof(#NOMEMETODO)} - Tempo total -> {stopwatch.Elapsed}");
            }
        }