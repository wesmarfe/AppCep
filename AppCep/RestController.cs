using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCep.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppCep
{
    [Route("Endereco")]
    public class RestController : Controller
    {


        private readonly Context _context;



        public RestController(Context context)
        {

            _context = context;

        }

        
        [HttpGet("Enderecos")]
        public IEnumerable<Endereco> GetTodos()


        {

            List<Endereco> enderecos = _context.Enderecos.ToList();
            return enderecos;


        }

        [HttpGet("Enderecos/{cep}")]
        public IEnumerable<Endereco> GetCep(string cep)


        {
            var endereco = _context.Enderecos.Where(s => s.Cep == cep);
            return endereco;
        }


        [HttpGet("Enderecos/Cidade/{cidade}")]
        public IEnumerable<Endereco> GetCidade(string cidade)


        {
            var endereco = _context.Enderecos.Where(s => s.Localidade == cidade);
            return endereco;
        }


        [HttpGet("Enderecos/EnderecosPorEstado/{uf}")]
        public IEnumerable<Endereco> GetEstado(string uf)
        {
            List<Endereco> enderecos = _context.Enderecos.Where(s => s.Uf == uf).ToList();
            return enderecos;
        }
    }
}
