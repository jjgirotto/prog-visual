using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUT05_JuliaMizuguchiJulianaLeite;

namespace TUT05_JuliaMizuguchiJuliaJMJLLeite
{
    internal class Turma_JMJL
    {
        public String Curso_JMJL { get; set; }
        public int AnoCurricular_JMJL { get; set; }
        public char Letra_JMJL { get; set; }
        public List<Aluno_JMJL> ListaDeAlunos_JMJL { get; set; }


        public Turma_JMJL(String curso_JMJL, int anoCurricular_JMJL, char letra_JMJL)
        {
            Curso_JMJL = curso_JMJL;
            AnoCurricular_JMJL = anoCurricular_JMJL;
            Letra_JMJL = letra_JMJL;
            ListaDeAlunos_JMJL = new List<Aluno_JMJL>();
        }

        // Ao incluirmos uma coleção um classe
        // normalmente temos de codificar os métodos
        // para adicionar e remover elementos dessa coleção
        public void AddAluno_JMJL(Aluno_JMJL aluno)
        {
            ListaDeAlunos_JMJL.Add(aluno);
        }


        public void RemoveAluno_JMJL(Aluno_JMJL aluno_JMJL)
        {
            ListaDeAlunos_JMJL.Remove(aluno_JMJL);
        }


        public void RemoveAt_JMJL(int i)
        {
            ListaDeAlunos_JMJL.RemoveAt(i);
        }


        public int GetLenght_JMJL()
        {
            return ListaDeAlunos_JMJL.Count();
        }


        public override string ToString()
        {
            String tmp_JMJL = "XXXX Curso: " + Curso_JMJL
                + "\nAno: " + AnoCurricular_JMJL + "\t|Turma_JMJL: " + Letra_JMJL;
            foreach (Aluno_JMJL al in ListaDeAlunos_JMJL)
                tmp_JMJL += "\n" + al.ToString();
            return tmp_JMJL;
        }
    }
}
