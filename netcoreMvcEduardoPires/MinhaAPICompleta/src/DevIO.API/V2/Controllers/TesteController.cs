﻿using DevIO.API.Controllers;
using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevIO.API.V2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/teste")]
    public class TesteController : MainController
    {
        private readonly ILogger _logger;
        public TesteController(INotificador notificador, IUser appUser, ILogger<TesteController> logger) : base(notificador, appUser)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Valor()
        {
            _logger.LogTrace("Log de trace");
            _logger.LogDebug("Log de debug");
            _logger.LogInformation("Log de informação");
            _logger.LogWarning("Log de aviso");
            _logger.LogError("Log de erro");
            _logger.LogCritical("Log de problema critico");

            return "Sou a V2";
        }
    }
}