namespace Lab02JGL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nXXXXXXX NIVEL 1 – Classe Bilhete!");

            Bilhete_JL bilhete1_JL = new Bilhete_JL();
            Console.WriteLine($"Preço do Bilhete: {Bilhete_JL.PRECO_BILHETE_JL}");
            Console.WriteLine($"Número do Bilhete: {bilhete1_JL.NumeroDoBilhete_JL}");
            Console.WriteLine($"Data e Hora: {bilhete1_JL.DataHora_JL}");
            Console.WriteLine($"Nome do Cliente: {bilhete1_JL.NomeDoCliente_JL}");
            bilhete1_JL.NomeDoCliente_JL = "Juliana";

            Console.WriteLine($"Número do Bilhete: {bilhete1_JL.NumeroDoBilhete_JL}");
            Console.WriteLine($"Data e Hora: {bilhete1_JL.DataHora_JL}");
            Console.WriteLine($"Nome do Cliente: {bilhete1_JL.NomeDoCliente_JL}");

            Console.WriteLine("\nXXXXXXX NIVEL 2 – Construtores da classe Bilhete");
            Bilhete_JL bilhete2_JL = new Bilhete_JL("Juliana Leite");
            Console.WriteLine($"Número do Bilhete: {bilhete2_JL.NumeroDoBilhete_JL}");
            Console.WriteLine($"Data e Hora: {bilhete2_JL.DataHora_JL}");
            Console.WriteLine($"Nome do Cliente: {bilhete2_JL.NomeDoCliente_JL}");

            Console.WriteLine("\nXXXXXXX NIVEL 3 – Método ToString da classe Bilhete_JL");
            Bilhete_JL bilhete3_JL = new Bilhete_JL("Ana Clara");
            Console.WriteLine(bilhete3_JL.ToString());

            Console.WriteLine("\nXXXXXXX NIVEL 4 – Venda de Bilhetes");
            Console.Write("Insira a quantia desejada: ");
            decimal quantia = Convert.ToDecimal(Console.ReadLine());
            if (quantia < Bilhete_JL.PRECO_BILHETE_JL)
            {
                Console.WriteLine("Valor inserido é menor que o preço do bilhete.");
            }
            else
            {
                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();
                Bilhete_JL bilhete4_JL = new Bilhete_JL(nome);
                decimal troco = quantia - Bilhete_JL.PRECO_BILHETE_JL;
                Console.WriteLine($"\nBilhete comprado! Troco = {troco}");
                Console.WriteLine(bilhete4_JL.ToString());
            }

            Console.WriteLine("\nXXXXXXX NIVEL 5 – ifs encadeados");
            Console.Write("Insira a quantia desejada: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            if (valor < Bilhete_JL.PRECO_BILHETE_JL)
            {
                Console.WriteLine("Valor inserido é menor que o preço do bilhete.");
            } else if (valor > Bilhete_JL.PRECO_BILHETE_JL)
            {
                Console.WriteLine("Valor inserido é maior que o preço do bilhete.");
            }
            else
            {
                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();
                Bilhete_JL bilhete5_JL = new Bilhete_JL(nome);
                Console.WriteLine($"\nBilhete comprado!");
                Console.WriteLine(bilhete5_JL.ToString());
            }

            Console.WriteLine("\nXXXXXXX NIVEL 6 – Estruturas de repetição");
            bool continuar = true;

            while (continuar)
            {
                Console.Write("Insira a quantia desejada: ");
                decimal valor2 = Convert.ToDecimal(Console.ReadLine());

                if (valor2 < Bilhete_JL.PRECO_BILHETE_JL)
                {
                    Console.WriteLine("Valor inserido é menor que o preço do bilhete.");
                }
                else
                {
                    Console.Write("Informe o nome: ");
                    string nome = Console.ReadLine();

                    Bilhete_JL bilhete6_JL = new Bilhete_JL(nome);
                    decimal troco = valor2 - Bilhete_JL.PRECO_BILHETE_JL;

                    Console.WriteLine($"\nBilhete comprado! Troco = {troco}");
                    Console.WriteLine(bilhete6_JL.ToString());
                }

                Console.Write("\nDeseja comprar outro bilhete? (s/n): ");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() != "s")
                {
                    continuar = false;
                }
            }

            Console.WriteLine("\nObrigado por utilizar a Máquina de Bilhetes!");

        }
    }
}
