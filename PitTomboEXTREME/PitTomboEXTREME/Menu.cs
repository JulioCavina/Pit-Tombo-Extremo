class Menu
{

    private Gerador gerador = new Gerador();

    private string resposta = "0";

    public void IniciarMenu()
    {
        while (resposta != "4")
        {


            Console.Clear();
            Console.WriteLine("Pit Tombo EXTREMO\n");
            Console.WriteLine($"Bem vindo ao Menu!\nSelecione uma das opções abaixo:\n");
            Console.WriteLine("1 - Iniciar Jogo! (Pit Tombo Clássico)\n2 - Iniciar Jogo EXTREMO! (4 Pit Tombos)\n3 - Como Jogar?\n4 - Sair\n");
            resposta = Console.ReadLine()!;
            switch (resposta)
            {
                case "1":
                    gerador.ComecarJogo1();
                    break;
                case "2":
                    gerador.ComecarJogoExtremo();
                    break;
                case "3":
                    ComoJogar();
                    break;
                case "4":
                    Console.WriteLine("Tchaaau!!!!!");
                    break;
            }
        }
    }

    private void ComoJogar()
    {
        Console.Clear();
        Console.WriteLine($"Pit Tombo EXTREMO\n");

        Console.WriteLine("Objetivo: Adivinhar uma sequência de 4 dígitos únicos gerada aleatoriamente pelo computador.");
        Console.WriteLine("\nModos de Jogo:");
        Console.WriteLine("Clássico: Adivinhe uma única sequência de 4 dígitos.");
        Console.WriteLine("Extremo: Adivinhe 4 sequências de 4 dígitos ao mesmo tempo.");
        Console.WriteLine("\nComo Jogar:");
        Console.WriteLine("Digite uma sequência de 4 dígitos únicos (0-9).");
        Console.WriteLine("O jogo retorna a quantidade de 'Pit' e 'Tombo':");
        Console.WriteLine("Tombo: Dígito correto na posição correta. Pit: Dígito correto na posição errada.");
        Console.WriteLine("\nGanhando o Jogo:");
        Console.WriteLine("Para ganhar, basta continuar adivinhando os dígitos até acertar todos os dígitos na posição correta.");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao Menu");
        Console.ReadKey();
    }



}