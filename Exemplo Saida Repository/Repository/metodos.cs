		/// <summary>
        /// 
        /// </summary>
        #COMENTARIOENTRADAS
        /// <returns>Lista com os planos</returns>
        public async Task<#RETORNOREPOSITORY> #NOMEMETODOREPOSITORYAsync(#FILTROSREPOSITORY)
        {
            var conn = GetConnection();

            try
            {
                _logger.LogDebug($"[{nameof(#NOMEINTERFACEREPOSITORYRepository)}]:[{nameof(#NOMEMETODOREPOSITORYAsync)}] - inicializando. #COMENTARIOFILTROSENTRADA");

                const string sql = @" #CONSULTA";

                _logger.LogDebug($"[{nameof(#NOMEINTERFACEREPOSITORYRepository)}]:[{nameof(#NOMEMETODOREPOSITORYAsync)}] - SQL: {Environment.NewLine}{sql}");

                return await conn.QueryAsync<#CLASSEENTITYEntity>(sql, new { #FILTROSCONSULTA});
            }
            finally
            {
                Diconnect();
                Dispose();
            }
        }