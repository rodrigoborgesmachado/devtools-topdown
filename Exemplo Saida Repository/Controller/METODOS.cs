		/// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(#ROTAMETODO)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<ErrorResponse>), StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<ResponseDTO<#OBJETORETORNO>>> #NOMEMETODOAsync(#OBJETOSENTRADA)
        {
            try
            {
                _logger.LogDebug($"[{nameof(#NOMECLASSEController)}]:[{nameof(#NOMEMETODOAsync)}] - inicializando execucao.");

                var filter = new BaseRequestDTO
                {
                    #OBEJTOSVALIDACAOENTRADA
                };

                return await ExecutarGetAsync(async (_limit, _offset) =>
                {
                    return await _cache.GetDataCacheAsync(
                        filter?.ConvertToString(),
                        nameof(#NOMEMETODOAsync), 
                        15, 
                        () => #NOMEVARIAVELINTERFACEQUERY.#NOMEMETODOAsync(filter));
                });
            }
            finally
            {
				_logger.LogDebug($"[{nameof(#NOMECLASSEController)}]:[{nameof(#NOMEMETODOAsync)}] - finalizando execucao.");
            }
        }