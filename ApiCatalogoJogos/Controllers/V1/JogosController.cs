﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List <object>>> Obter()
        {
            return Ok();
        }
        [HttpGet("{idJogo:guid}")]
        public async Task<ActionResult<object>>Obter(Guid idJogo)
        {
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult<object>> InserirJogo(object jogo)
        {
            return Ok();
        }
        [HttpPatch("{idJogo:guid}/preco/{preco:doube}")]
        public async Task<ActionResult>AtualizarJogo(Guid idJogo, double preco)
        {
            return Ok();
        }
        [HttpDelete]
        public async Task<AcceptedResult>ApagarJogo(Guid idJogo)
        {
            return Ok();
        }
    }
}
