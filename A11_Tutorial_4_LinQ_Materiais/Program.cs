using System;
using System.Collections.Generic;
using System.Linq;

namespace TP06_TutorialLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXXXXXXXX 1 TESTE DA LISTA");
            Alunos alunos = new Alunos();
            Console.WriteLine(alunos.ToString());

            Console.ReadKey();

            Console.WriteLine("XXXXXXXXXXX 2 Todos os nomes de alunos");
            var todos1_JMJL = from i in alunos select i.Nome;
            foreach (var i in todos1_JMJL)
                Console.WriteLine(i.ToString());
            
            Console.WriteLine("\nXXXXXXXXXXX 2 Todos os contactos de alunos");
            var todos2_JMJL = from i in alunos select i.Contacto;
            foreach (var i in todos2_JMJL)
                Console.WriteLine(i.ToString());

            Console.WriteLine("\nXXXXXXXXXXX 2 Todos os emails de alunos");
            var todos3_JMJL = from i in alunos select i.Contacto.Mail;
            foreach (var i in todos3_JMJL)
                Console.WriteLine(i.ToString());

            Console.WriteLine("\nXXXXXXXXXXX 4 Todas as cadeiras");
            var todos4_JMJL = from i in alunos select i.Cadeiras;
            foreach (var i in todos4_JMJL)
                Console.WriteLine(i); //cada elemento é uma lista de UC's e não uma única UC (cada aluno i tem uma list<UC>)

            Console.WriteLine("\nXXXXXXXXXXX 4 Todas as cadeiras");
            todos4_JMJL = from i in alunos select i.Cadeiras;
            foreach (var i in todos4_JMJL)
            {
                foreach (UnidadeCurricular c in i) //iterando a lista
                    Console.WriteLine(c);
            }

            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXX ORDEM ASCENDENTE");
            Console.WriteLine("\nXXXXXXXXXXX 5 Todos ordenados por nome");
            var todosPorNome_JMJL = from i in alunos orderby i.Nome select i.Nome;
            foreach (var i in todosPorNome_JMJL)
                Console.WriteLine(i);

            Console.WriteLine("\nXXXXXXXXXXX 5 Todos ordenados por telefone");
            var todosPorTelefone_JMJL = from i in alunos orderby i.Contacto.Telefone select i.Contacto;
            foreach (var i in todosPorTelefone_JMJL)
                Console.WriteLine(i.ToString());

            Console.WriteLine("\nXXXXXXXXXXX 5 Todos ordenados por mail");
            var todosPorMail_JMJL = from i in alunos orderby i.Contacto.Mail select i.Contacto.Mail;
            foreach (var i in todosPorMail_JMJL)
                Console.WriteLine(i.ToString());

            Console.WriteLine("\nXXXXXXXXXXX ORDEM DESCENDENTE");
            Console.WriteLine("\nXXXXXXXXXXX 6 Todos ordenados por nome");
            var porNomesDescendentes_JMJL = from i in alunos orderby i.Nome descending select i.Nome;
            foreach (var i in porNomesDescendentes_JMJL)
                Console.WriteLine(i);

            Console.WriteLine("\nXXXXXXXXXXX 6 Todos ordenados por telefone");
            var porTelefonesDescendentes_JMJL = from i in alunos orderby i.Contacto.Telefone descending select i.Contacto;
            foreach (var i in porTelefonesDescendentes_JMJL)
                Console.WriteLine(i.ToString());

            Console.WriteLine("\nXXXXXXXXXXX 6 Todos ordenados por mail");
            var porMailDescendentes_JMJL = from i in alunos orderby i.Contacto.Mail descending select i.Contacto.Mail;
            foreach (var i in porMailDescendentes_JMJL)
                Console.WriteLine(i.ToString());

            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXX 7 Contem, começa, termina");
            Console.WriteLine("Nomes que contêm 'Cláudia'");
            var claudias_JMJL = from i in alunos where i.Nome.Contains("Cláudia") select i.Nome;
            foreach (var i in claudias_JMJL)
                Console.WriteLine(i);

            Console.WriteLine("\nNomes que começam com 'An'");
            var comecaPorAn_JMJL = from i in alunos where i.Nome.StartsWith("An") select i.Nome;
            foreach (var i in comecaPorAn_JMJL)
                Console.WriteLine(i.ToString());

            Console.WriteLine("\nNomes que terminam com 'a'");
            var terminaEmA_JMJL = from i in alunos where i.Nome.EndsWith("a") select i.Nome;
            foreach (var i in terminaEmA_JMJL)
                Console.WriteLine(i.ToString());

            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXX 8 Take, Skip e Group By");
            Console.WriteLine("\nUsando TAKE - Primeiros 7 alunos da LEI");
            var tresAlunosDaLei_JMJL = (from i in alunos where i.Curso == Curso.LEI select i.Nome).Take(7);
            foreach (var aluno in tresAlunosDaLei_JMJL)
                Console.WriteLine(aluno);

            Console.WriteLine("\nUsando SKIP - 4º e 5º da LEI");
            var quartoEQuinto_JMJL = (from i in alunos where i.Curso == Curso.LEI select i.Nome).Take(5).Skip(3);
            foreach (var aluno in quartoEQuinto_JMJL)
                Console.WriteLine(aluno);

            Console.WriteLine("\nUsando GROUPBY - agrupados por curso");
            //var alunosPorCurso_JMJL = alunos.GroupBy(aluno => aluno.Curso);
            var alunosPorCurso_JMJL = from i in alunos group i.Nome by i.Curso;
            foreach (var curso in alunosPorCurso_JMJL)
            {
                Console.WriteLine($"\nXXXXXXXXXXX CURSO: " + curso.Key); //curso.Key é a chave do grupo (Curso)
                foreach (var aluno in curso) //cada 'curso' é uma coleção de alunos
                    Console.WriteLine(aluno);
            }







        }
    }
}