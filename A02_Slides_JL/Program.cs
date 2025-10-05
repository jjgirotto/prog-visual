namespace A02_Slides_JL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Season0_JL estacao0 = Season0_JL.Fall;
            Console.WriteLine(estacao0);
            Console.WriteLine((int)estacao0);

            Season1_JL estacao1 = Season1_JL.Fall;
            Console.WriteLine(estacao1);
            Console.WriteLine((int)estacao1);

            Season2_JL estacao2 = Season2_JL.Autumn;
            Console.WriteLine(estacao2);
            Console.WriteLine((int)estacao2);

            Season3_JL estacao3 = Season3_JL.Fall;
            Console.WriteLine(estacao3);
            Console.WriteLine((int)estacao3);

            Console.WriteLine("\nPrima return para continuar");
            Console.ReadKey();

            //2-3
            Livro_JL livro1_JL;
            livro1_JL = new Livro_JL();
            Livro_JL livro2_JL = new Livro_JL();
            Livro_JL livro3_JL = new Livro_JL();
            Cd_JL cd1_JL = new Cd_JL("IU_000000001", "Esquinas", "Anavitória", 42, 10M, 5);
            Dvd_JL dvd1_JL = new Dvd_JL();

            //4
            livro2_JL = new Livro_JL("IU_000000001", "Memorial do Convento", "José Saramago", 25.5M, 3);
            livro3_JL = new Livro_JL("IU_000000002", "O Conde de Abranhos", "Eça de Queirós", 15.3M, 2);
            cd1_JL = new Cd_JL("IU_000000001", "Esquinas", "Anavitória", 42, 10M, 5);
            dvd1_JL = new Dvd_JL("IU_000000001", "Jogos Vorazes", "Sony", 129, 11.3, 1);

            //5
            Console.WriteLine("**************\nLIVROS  EM STOCK:");
            Console.WriteLine("\n*** LIVRO: " + livro1_JL.GetIdentificadorUnico_JL() + "\n* " + livro1_JL.GetTitulo_JL()
                + "\n* " + livro1_JL.GetAutor_JL() + "\n* " + livro1_JL.GetPreco_JL() + "\n* " + livro1_JL.GetExistencias_JL());
            Console.WriteLine("\n*** LIVRO: " + livro2_JL.GetIdentificadorUnico_JL() + "\n* " + livro2_JL.GetTitulo_JL()
                + "\n* " + livro2_JL.GetAutor_JL() + "\n* " + livro2_JL.GetPreco_JL() + "\n* " + livro2_JL.GetExistencias_JL());
            Console.WriteLine("\n*** LIVRO: " + livro3_JL.GetIdentificadorUnico_JL() + "\n* " + livro3_JL.GetTitulo_JL()
                + "\n* " + livro3_JL.GetAutor_JL() + "\n* " + livro3_JL.GetPreco_JL() + "\n* " + livro3_JL.GetExistencias_JL());

            Console.WriteLine("**************\nCDs  EM STOCK:");
            Console.WriteLine("\n*** CD: " + cd1_JL.GetIdentificadorUnico_JL() + "\n* " + cd1_JL.GetTitulo_JL()
                + "\n* " + cd1_JL.GetInterprete_JL() + "\n* " + cd1_JL.GetDuracao_JL() + "\n* " + 
                cd1_JL.GetPreco_JL() + "\n* " + cd1_JL.GetExistencias_JL());
            Console.WriteLine("**************\nDVDs  EM STOCK:");
            Console.WriteLine("\n*** DVD: " + dvd1_JL.GetIdentificadorUnico_JL() + "\n* " + dvd1_JL.GetTitulo_JL()
                + "\n* " + dvd1_JL.GetRealizador_JL() +"\n* " + dvd1_JL.GetDuracao_JL() + "\n* " +
                dvd1_JL.GetPreco_JL() + "\n* " + dvd1_JL.GetExistencias_JL());


            Console.WriteLine("\nPrima return para continuar");
            Console.ReadKey();

            //6
            livro1_JL.SetTitulo_JL("Os Lusíadas");
            livro1_JL.SetAutor_JL("Luis Vaz de Camões");
            livro1_JL.SetPreco_JL(30.99M);
            livro1_JL.SetExistencias_JL(1);

            livro2_JL.SetPreco_JL(35.99M);
            livro2_JL.SetExistencias_JL(5);
            livro3_JL.SetPreco_JL(20.89M);
            livro3_JL.SetExistencias_JL(1);

            cd1_JL.SetTitulo_JL("Esquinas Deluxe");
            cd1_JL.SetInterprete_JL("AnaVitória");
            cd1_JL.SetDuracao_JL(43);
            cd1_JL.SetPreco_JL(12M);
            cd1_JL.SetExistencias_JL(4);
            dvd1_JL.SetPreco_JL(15.5);
            dvd1_JL.SetExistencias_JL(10);

            Console.WriteLine("\n*** LIVRO: " + livro1_JL.GetIdentificadorUnico_JL() + "\n* " + livro1_JL.GetTitulo_JL()
                + "\n* " + livro1_JL.GetAutor_JL() + "\n* " + livro1_JL.GetPreco_JL() + "\n* " + livro1_JL.GetExistencias_JL());
            Console.WriteLine("\n*** LIVRO: " + livro2_JL.GetIdentificadorUnico_JL() + "\n* " + livro2_JL.GetPreco_JL() + "\n* " + livro2_JL.GetExistencias_JL());
            Console.WriteLine("\n*** LIVRO: " + livro3_JL.GetIdentificadorUnico_JL() + "\n* " + livro3_JL.GetPreco_JL() + "\n* " + livro3_JL.GetExistencias_JL());

            Console.WriteLine("\n*** CD: " + cd1_JL.GetIdentificadorUnico_JL() + "\n* " + cd1_JL.GetTitulo_JL()
                + "\n* " + cd1_JL.GetInterprete_JL() + "\n* " + cd1_JL.GetDuracao_JL() + "\n* " +
                cd1_JL.GetPreco_JL() + "\n* " + cd1_JL.GetExistencias_JL());
            Console.WriteLine("\n*** DVD: " + dvd1_JL.GetIdentificadorUnico_JL() + "\n* " + dvd1_JL.GetTitulo_JL()
                + "\n* " + dvd1_JL.GetRealizador_JL() + "\n* " + dvd1_JL.GetDuracao_JL() + "\n* " +
                dvd1_JL.GetPreco_JL() + "\n* " + dvd1_JL.GetExistencias_JL());

            Console.WriteLine("\nPrima return para continuar");
            Console.ReadKey();

            //7
            Console.WriteLine(livro1_JL + "\n" + livro2_JL + "\n" + livro3_JL);
            Console.WriteLine(cd1_JL);
            Console.WriteLine(dvd1_JL);

            Console.WriteLine("\nPrima return para continuar");
            Console.ReadKey();
        }
    }
}
