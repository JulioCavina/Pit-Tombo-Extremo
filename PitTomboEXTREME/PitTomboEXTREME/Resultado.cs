class Resultado
{


    public void IniciarPalpites1(List<int> List)
    {
        int pit = 0;

        int tombo = 0;

        int contadorPalpites = 0;

        Console.Clear();

        Console.WriteLine("Pit Tombo CLÁSSICO!");

        while (tombo != 4)
        {
            tombo = 0;

            pit = 0;

            List<int> resposta = new List<int>();

            string palpite;

            while (resposta.Count < 4)
            {
                Console.WriteLine("\nMe diga uma sequência de números (4 digitos únicos)");
                palpite = Console.ReadLine()!;
                if (palpite.Length == 4 && int.TryParse(palpite, out _))
                {
                    int digito1 = int.Parse(palpite[0].ToString());
                    int digito2 = int.Parse(palpite[1].ToString());
                    int digito3 = int.Parse(palpite[2].ToString());
                    int digito4 = int.Parse(palpite[3].ToString());

                    if (digito1 != digito2 && digito1 != digito3 && digito1 != digito4 && digito2 != digito3 && digito2 != digito4 && digito3 != digito4)
                    {
                        resposta.Add(digito1);
                        resposta.Add(digito2);
                        resposta.Add(digito3);

                        resposta.Add(digito4);

                    }
                    else { Console.WriteLine("Digitos que ***NÃO SE REPITAM***"); }
                }
                else {Console.WriteLine("Sequência de ***NÚMEROS***"); }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++) 
                {

                    if (List[i] == resposta[j])
                    {
                        if (i == j)
                        {
                            tombo++;

                        }
                        else 
                        { 
                            pit++;                       
                        }
                    }
                }

            }
                            
            Console.WriteLine($"\n[{tombo}] Tombo(s) e [{pit}] Pit(s)!!!");
            Console.WriteLine("------------------------------");
            contadorPalpites++;
        }

        Console.WriteLine($"\nYUUUPI! VC ACERTOU!!!!\nVocê levou {contadorPalpites} palpites!\n\nClique em qualquer tecla para voltar ao menu!");
        Console.ReadKey();

    }


    public void IniciarPalpitesExtremo(List<int> List1, List<int> List2, List<int> List3, List<int> List4)
    {

        string resultado1,resultado2,resultado3,resultado4;

        int extremoCheck1 = 0;
        int extremoCheck2 = 0;
        int extremoCheck3 = 0;
        int extremoCheck4 = 0;

        int pit1 = 0;
        int pit2 = 0;
        int pit3 = 0;
        int pit4 = 0;

        int tombo1 = 0;
        int tombo2 = 0;
        int tombo3 = 0;
        int tombo4 = 0;

        int contadorPalpites = 0;

        Console.Clear();

        Console.WriteLine("Pit Tombo EXTREMO!");

        while (extremoCheck1 != 1 || extremoCheck2 != 1 || extremoCheck3 != 1 || extremoCheck4 != 1)
        {
            tombo1 = 0;
            tombo2 = 0;
            tombo3 = 0;
            tombo4 = 0;

            pit1 = 0;
            pit2 = 0;
            pit3 = 0;
            pit4 = 0;

            List<int> resposta = new List<int>();

            string palpite;

            while (resposta.Count < 4)
            {
                Console.WriteLine("\nMe diga uma sequência de números (4 digitos únicos)");
                palpite = Console.ReadLine()!;
                if (palpite.Length == 4 && int.TryParse(palpite, out _))
                {
                    int digito1 = int.Parse(palpite[0].ToString());
                    int digito2 = int.Parse(palpite[1].ToString());
                    int digito3 = int.Parse(palpite[2].ToString());
                    int digito4 = int.Parse(palpite[3].ToString());

                    if (digito1 != digito2 && digito1 != digito3 && digito1 != digito4 && digito2 != digito3 && digito2 != digito4 && digito3 != digito4)
                    {
                        resposta.Add(digito1);
                        resposta.Add(digito2);
                        resposta.Add(digito3);
                        resposta.Add(digito4);

                    }
                    else { Console.WriteLine("Digitos que ***NÃO SE REPITAM***"); }
                }
                else { Console.WriteLine("Sequência de ***NÚMEROS***"); }
            }

            for (int i1 = 0; i1 < 4; i1++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (List1[i1] == resposta[j])
                    {
                        if (i1 == j)
                        {
                            tombo1++;
                            if (tombo1 == 4)
                            {
                                extremoCheck1=1;

                            }

                        }
                        else
                        {
                            pit1++;
                        }
                    }
                }
            }

            for (int i2 = 0; i2 < 4; i2++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (List2[i2] == resposta[j])
                    {
                        if (i2 == j)
                        {
                            tombo2++;
                            if (tombo2 == 4)
                            {
                                extremoCheck2=1;

                            }
                        }
                        else
                        {
                            pit2++;
                        }
                    }
                }
            }

            for (int i3 = 0; i3 < 4; i3++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (List3[i3] == resposta[j])
                    {
                        if (i3 == j)
                        {
                            tombo3++;
                            if (tombo3 == 4)
                            {
                                extremoCheck3=1;

                            }
                        }
                        else
                        {
                            pit3++;
                        }
                    }
                }
            }

            for (int i4 = 0; i4 < 4; i4++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (List4[i4] == resposta[j])
                    {
                        if (i4 == j)
                        {
                            tombo4++;
                            if (tombo4 == 4)
                            {
                                extremoCheck4=1;

                            }
                        }
                        else
                        {
                            pit4++;
                        }
                    }
                }
            }
            if (extremoCheck1 > 0)
            {
                resultado1 = "   Pit Tombo Completo!     |  ";
            }
            else
            {
                resultado1 = $"[{tombo1}] Tombo(s) , [{pit1}] Pit(s)  |  ";
            }
            
            if (extremoCheck2 > 0)
            {
                resultado2 = "   Pit Tombo Completo!     |  ";
            }
            else
            {
                resultado2 = $"[{tombo2}] Tombo(s) , [{pit2}] Pit(s)  |  ";
            }

            if (extremoCheck3 > 0)
            {
                resultado3 = "   Pit Tombo Completo!     |  ";
                             


            }                
            else
            {
                resultado3 = $"[{tombo3}] Tombo(s) , [{pit3}] Pit(s)  |  ";
            }
                              

            if (extremoCheck4 > 0)
            {
                resultado4 = "   Pit Tombo Completo!   ";
                            
            }
            else
            {
                resultado4 = $"[{tombo4}] Tombo(s) , [{pit4}] Pit(s)";
            }                 

            Console.WriteLine("         Pit Tombo 1       |  "+ "         Pit Tombo 2       |  " + "         Pit Tombo 3       |  " + "         Pit Tombo 4          ");
            Console.WriteLine(resultado1+resultado2+ resultado3 + resultado4);
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------\n");
            contadorPalpites++;
        }

        Console.WriteLine($"\nYUUUPI! VC ACERTOU!!!!\nVocê levou {contadorPalpites} palpites!\n\nClique em qualquer tecla para voltar ao menu!");
        Console.ReadKey();


    }

}