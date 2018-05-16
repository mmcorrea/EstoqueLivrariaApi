using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueLivrariaApi.Model
{
    public class Livro
    {
        [Key]
        public int ID_Codigo { get; set; }

        public string DS_Titulo { get; set; }

        public string DS_Autor { get; set; }

        public int NR_Estoque { get; set; }

        public string DT_Imagem { get; set; }
    }
}
