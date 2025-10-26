using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class TurmaComConjunto_JMJL
    {
        public String Curso_JMJL { get; set; }
        public int AnoCurricular_JMJL { get; set; }
        public char Letra_JMJL { get; set; }
        public HashSet<Aluno_JMJL> ConjuntoDeAlunos_JMJL { get; }

        public TurmaComConjunto_JMJL(String curso_JMJL,
                                        int anoCurricular_JMJL,
                                        char letra_JMJL)
        {
            Curso_JMJL = curso_JMJL;
            AnoCurricular_JMJL = anoCurricular_JMJL;
            Letra_JMJL = letra_JMJL;
            ConjuntoDeAlunos_JMJL = new HashSet<Aluno_JMJL>();
        }


        public void AddAluno_JMJL(Aluno_JMJL aluno)
        {
            ConjuntoDeAlunos_JMJL.Add(aluno);
        }

        public void RemoveAluno_JMJL(Aluno_JMJL aluno_JMJL)
        {
            ConjuntoDeAlunos_JMJL.Remove(aluno_JMJL);
        }

        public int GetLenght_JMJL()
        {
            return ConjuntoDeAlunos_JMJL.Count();
        }

        public override string ToString()
        {
            String tmp_JMJL = "XXXX Curso: " + Curso_JMJL
                + "\nAno: " + AnoCurricular_JMJL + "\t|Turma: " + Letra_JMJL;
            foreach (Aluno_JMJL al in ConjuntoDeAlunos_JMJL)
                tmp_JMJL += "\n" + al.ToString();
            return tmp_JMJL;
        }
    }
}
