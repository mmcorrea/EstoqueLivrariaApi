using System;
using System.Linq;
using EstoqueLivrariaApi.Model;
using EstoqueLivrariaApi.Model.DataBaseContext;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EstoqueLivrariaApi.Controllers
{
    [Route("api/livros")]
    public class LivroController : Controller
    {
        private readonly EstoqueLivrariaContext conexao;

        public LivroController(EstoqueLivrariaContext context) => this.conexao = context;

        // Adiciona Livro (INSERT)
        [HttpPost]
        [Route("adicionarlivro")]
        public IActionResult AdicionarLivro([FromBody]Livro _livro)
        {
            if (_livro == null)
                return BadRequest();
            try
            {
                this.conexao.Livros.Add(_livro);

                this.conexao.SaveChanges();

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // Editar Livro (UPDATE)
        [HttpPut]
        [Route("editarlivro")]
        public IActionResult EditarLivro([FromBody]Livro _livro)
        {
            if (_livro == null)
                return BadRequest();
            try
            {
                var livro = this.conexao.Livros.Where(exp => exp.ID_Codigo == _livro.ID_Codigo).FirstOrDefault();

                livro.DS_Titulo = _livro.DS_Titulo;
                livro.DS_Autor = _livro.DS_Autor;
                livro.DT_Imagem = _livro.DT_Imagem;
                livro.NR_Estoque = _livro.NR_Estoque;

                this.conexao.Entry(livro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                this.conexao.SaveChanges();

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // Excluir Livro (DELETE)
        [HttpDelete]
        [Route("excluirlivro/{ID_Codigo}")]
        public IActionResult ExcluirLivro(int ID_Codigo)
        {
            if (ID_Codigo == 0)
                return BadRequest();
            try
            {
                var livro = this.conexao.Livros.Where(exp => exp.ID_Codigo == ID_Codigo).FirstOrDefault();

                this.conexao.Entry(livro).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

                this.conexao.SaveChanges();

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // Retornar Lista de Livros (SELECT)
        [HttpGet]
        [Route("listarlivros")]
        public IActionResult ListaLivro()
        {
            try
            {
                return Ok(this.conexao.Livros.Where(exp => exp.NR_Estoque > 0).OrderBy(exp => exp.DS_Titulo).ToList());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
