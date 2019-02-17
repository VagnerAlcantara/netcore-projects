﻿using Microsoft.AspNetCore.Mvc;
using ModernStore.Infra.Transations;
using ModernStore.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModernStore.Api.Controllers
{
    public class BaseController : Controller
    {
        private readonly IUow _uow;

        public BaseController(IUow uow)
        {
            _uow = uow;
        }

        public async Task<IActionResult> Response(object result, Dictionary<string, string> notifications)
        {
            if (!notifications.Any())
            {
                try
                {
                    _uow.Commit();

                    return Ok(
                        new
                        {
                            success = true,
                            data = result
                        });
                }
                catch (Exception e)
                {
                    //Logar erro (Usar Elmah) 
                    return BadRequest(
                        new
                        {
                            success = false,
                            errors = new[] { e.Message }
                        });
                }
            }
            else
            {
                return BadRequest(
                        new
                        {
                            success = false,
                            errors = notifications
                        });
            }
        }
    }
}
