using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueLivrariaApi.Model.DataBaseContext
{
    public class EstoqueLivrariaContext:DbContext
    {
        public EstoqueLivrariaContext(DbContextOptions<EstoqueLivrariaContext> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
    }
}
