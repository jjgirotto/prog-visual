using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10_JulianaLeite
{
    internal class Disciplina : List<Aluno>
    {
        public String Nome { get; set; }
        public int TotalDeAlunos { get; set; }
        public String Curso { get; set; }
    }
}
