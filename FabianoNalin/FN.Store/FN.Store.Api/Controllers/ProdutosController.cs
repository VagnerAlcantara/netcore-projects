﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FN.Store.Domain.Contracts.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FN.Store.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _produtoRepository.GetAsync();

            return Ok(data);
        }
    }
}