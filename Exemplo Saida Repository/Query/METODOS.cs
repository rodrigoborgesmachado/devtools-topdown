		/// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<ResponseDTO<#OBJETORETORNO>> #NOMEMETODOAsync(BaseRequestDTO filter)
        {
            var response = new ResponseDTO<#OBJETORETORNO>();
            try
            {
                var responseValidation = new #NOMECLASSEVALIDATIONValidation().Validate(filter);

                if (!responseValidation.IsValid)
                {
                    response.Errors = ValidationMessages..ValidationErrorToErrorResponse();
                    return response;
                }

                var retorno = await _repository.#NOMEMETODOAsync(#FILTROSREPOSITORY);

                response.Results = _mapper.Map<#OBJETORETORNO>(retorno);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, MethodBase.GetCurrentMethod().DeclaringType.FullName, null);
                response.Errors.Add(new ErrorResponse()
                {
                    Source = System.Reflection.Assembly.GetExecutingAssembly().FullName,
                    ErrorCode = ex.HResult,
                    ErrorDescription = "DESCRIPTION: " + ex.Message?.ToString() + "\nSTACK-TRACE: " + ex.StackTrace?.ToString(),
                    InnerException = ex.InnerException?.ToString()
                });
            }
            return response;
        }