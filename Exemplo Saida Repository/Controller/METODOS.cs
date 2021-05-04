		/// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("#ROTAMETODO")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<ErrorResponse>), StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<ResponseDTO<#OBJETORETORNO>>> #NOMEMETODO(#OBJETOSENTRADA)
        {
            try
            {
                _logger.LogDebug($"[{nameof(#NOMECLASSE)}]:[{nameof(#NOMEMETODO)}] - inicializando execucao.");

                var filter = new BaseRequestDTO
                {
#OBEJTOSVALIDACAOENTRADA
                };

                return await ExecutarGetAsync(async (_limit, _offset) =>
                {
                    return await _cache.GetDataCacheAsync(
                        filter?.ConvertToString(),
                        nameof(#NOMEMETODO), 
                        15, 
                        () => #NOMEVARIAVELINTERFACEQUERY.#NOMEMETODO(filter));
                });
            }
            finally
            {
				_logger.LogDebug($"[{nameof(#NOMECLASSE)}]:[{nameof(#NOMEMETODO)}] - finalizando execucao."); 
            }
        }