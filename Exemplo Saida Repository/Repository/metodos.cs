		/// <summary>
        /// 
        /// </summary>
#COMENTARIOENTRADAS
        /// <returns></returns>
        public async Task<#RETORNOREPOSITORY> #NOMEMETODOREPOSITORY(#FILTROSREPOSITORY)
        {
            var conn = GetConnection();

            try
            {
                _logger.LogDebug($"[{nameof(#NOMEINTERFACEREPOSITORY)}]:[{nameof(#NOMEMETODOREPOSITORY)}] - inicializando. #COMENTARIOFILTROSENTRADA");

                const string sql = @" #CONSULTA";

                _logger.LogDebug($"[{nameof(#NOMEINTERFACEREPOSITORY)}]:[{nameof(#NOMEMETODOREPOSITORY)}] - SQL: {Environment.NewLine}{sql}");

                return await conn.QueryAsync<#CLASSEENTITY>(sql, new { #FILTROSCONSULTA});
            }
            finally
            {
                Diconnect();
                Dispose();
            }
        }