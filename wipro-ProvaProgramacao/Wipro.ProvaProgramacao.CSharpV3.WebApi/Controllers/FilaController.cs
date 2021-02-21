using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wipro.ProvaProgramacao.CSharpV3.Data;
using Wipro.ProvaProgramacao.CSharpV3.Domain.Dto;
using Wipro.ProvaProgramacao.CSharpV3.Domain.Entities;
using Wipro.ProvaProgramacao.CSharpV3.Service.Interface;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wipro.ProvaProgramacao.CSharpV3.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilaController : ControllerBase
    {
        private readonly IFilaService _filaService;
        public FilaController(IFilaService filaService)
        {
            _filaService = filaService;
        }

        // GET: api/<FilaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
       
        // POST api/<FilaController>
        [HttpPost("AddItemFila")]
        public Retorno AddItemFila([FromBody] List<MoedaDto> listaMoedas)
        {
            return _filaService.AddItemRanger(listaMoedas);
        }

        [HttpGet("GetItemFila")]
        public string GetItemFila()
        {
            return _filaService.GetItemLista();
        }

    }
}
