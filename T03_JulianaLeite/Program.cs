namespace T03_JulianaLeite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****************************************"
                            + "\n***** 1.2 Teste das Classes "
                            + "\n***** MessagePostSh_JL e PhotoPostSh_JL"
                            + "\n* Não usando herança, mesmo para um programa"
                            + "\n* tão simples como o deste exemplo"
                            + "\n* a quantidade de código repetido é substancial"
                            + "\n* superior a 80%"
                            + "\n* Entre as classes MessagePost e PhotoPost "
                            + "\n* temos 5 atributos duplicados:"
                            + "\n* username, message/caption, timestamp, likes, comments"
                            + "\n* Temos 4 métodos iguais (duplicados!)"
                            + "\n* like, unlike, getComments, getTimeStamp, timeString"
                            + "\n* um toString praticamente igual nas 2 classes"
                            + "\n* um erro em qualquer deste métodos são certamente"
                            + "\n* dois erros e o segundo precisa de testes próprios para"
                            + "\n* ser identificado");

            Console.WriteLine("****************************************");
            Console.WriteLine("***** 1.2 Um objeto MessagePostSh_JL sem herança");
            MessagePostSh_JL mpSh_JL = new MessagePostSh_JL("Jonh Bastide", "Olá! Já cá estou!");
            mpSh_JL.AddComment("Yeah! Tudo bem?");
            Console.WriteLine(mpSh_JL);

            Console.WriteLine("\n****************************************");
            Console.WriteLine("***** 1.2 Um objeto PhotoPostSh_JL sem herança");
            PhotoPostSh_JL ppSh_JL = new PhotoPostSh_JL("Josué Bastideiro", "Também", "\\top\\smiles\\bigsmile.jpg");
            ppSh_JL.AddComment("Sem brincadeiras");
            Console.WriteLine(ppSh_JL);

            Console.WriteLine("\n*****************************************"
                            + "\n* 1.4 Teste da classe NewsFeedSh_JL"
                            + "\n* Já a classe NewsFeedSh_JL, não usando herança,"
                            + "\n* sofre de problemas ainda mais graves do "
                            + "\n* que a duplicação de código para manipular"
                            + "\n* as duas listas. Repare que sem (muito) código"
                            + "\n* adicional, primeiro apresentam-se todos os posts"
                            + "\n* de texto e depois os de imagens, quando deveriam"
                            + "\n* ser apresentados por ordem de inserção no mural");
            NewsFeedSh_JL myNf_JL = new NewsFeedSh_JL();
            myNf_JL.AddMessagePostSh_JL(mpSh_JL);
            myNf_JL.AddPhotoPostSh_JL(ppSh_JL);
            myNf_JL.AddMessagePostSh_JL(new MessagePostSh_JL("Juan Barallobre", "Finalmente chegaste, " + "tava dificil"));
            myNf_JL.AddPhotoPostSh_JL(new PhotoPostSh_JL("Josué Bastideiro", "Logo á tarde?", "\\top\\smiles\\smallsmile.jpg"));
            Console.WriteLine(myNf_JL);

            Console.WriteLine("\n*****************************************"
                            + "\n***** 2 Rede Social COM herança"
                            + "\n* 1. Criamos uma classe Post com os membros"
                            + "\n* repetidos nas classes MessagePost e PhotoPost "
                            + "\n* (campos e métodos)"
                            + "\n* 2. A classe MessagePost_JL herda de Post"
                            + "\n* (o extends do Java que em C# se define com : )"
                            + "\n* e assim fica com tudo o que Post tem, "
                            + "\n* adicionamos-lhe e alteramos"
                            + "\n* o que é específico de MessagePost_JL"
                            + "\n* 3. A classe PhotoPost herda ( : ) de Post e também"
                            + "\n* herda tudo que Post tem, resta adicionar e alterar"
                            + "\n* o que é particular de PhotoPost"
                            + "\n* 4. A classe NewsFeed passa a ter uma coleção de Post à"
                            + "\n* adicionamos mensagens e imagens indiferenciadamente"
                            + "\n* que serão apresentadas por ordem de inserção executando"
                            + "\n* os respectivos métodos graças ao polimorfismo");
            Console.WriteLine("*****************************************");
            Console.WriteLine("***** 2.1 Dois objetos da classe Post_JL");
            Post_JL post1_JL = new Post_JL("Juan Bastidero");
            post1_JL.AddComment("Arriba Arriba Yeeh");
            Post_JL post2_JL = new Post_JL();
            post2_JL.AddComment("Fake Account for sure");
            Console.WriteLine(post1_JL + "\n" + post2_JL);

            Console.WriteLine("*****************************************");
            Console.WriteLine("***** 2.4 Dois objetos da classe MessagePost_JL");
            MessagePost_JL mp1_JL = new MessagePost_JL("Iosif Bastidov", "From Russia with love");
            mp1_JL.AddComment("no comments!");
            Post_JL post3_JL = new Post_JL();
            MessagePost_JL mp2_JL = new MessagePost_JL("Outro JB", "Mais um fake profile");
            Console.WriteLine(mp1_JL + "\n" + mp2_JL);

            Console.WriteLine("*****************************************");
            Console.WriteLine("***** 2.4B Dois objetos da classe PhotoPost_JL");
            PhotoPost_JL pp1_JL = new PhotoPost_JL("Iosif Bastidov", "C:\\logonaraiz\\getalife.gif", "Só pa chatear");
            pp1_JL.AddComment("Arriba Arriba Yeeh!");
            PhotoPost_JL pp2_JL = new PhotoPost_JL();
            pp2_JL.AddComment("Fake Account for sure");
            Console.WriteLine(pp1_JL + "\n" + pp2_JL);

            Console.WriteLine("*****************************************");
            Console.WriteLine("***** 2.5 Teste da classe NewsFeed_JL");
            NewsFeed_JL nf1_JL = new NewsFeed_JL();
            nf1_JL.AddPost_JL(pp1_JL);
            nf1_JL.AddPost_JL(mp1_JL);
            nf1_JL.AddPost_JL(mp2_JL);
            nf1_JL.AddPost_JL(pp2_JL);
            Console.WriteLine(nf1_JL);

            Console.ReadKey();
        }
    }
}
