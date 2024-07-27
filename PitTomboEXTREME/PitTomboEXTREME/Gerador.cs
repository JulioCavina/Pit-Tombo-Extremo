
class Gerador
{
    Random random = new Random();
    
    private Resultado resultado = new Resultado();

    public List<int> pitTombo1 = new List<int>();

    public List<int> pitTomboExtremo1 = new List<int>();

    public List<int> pitTomboExtremo2 = new List<int>();

    public List<int> pitTomboExtremo3 = new List<int>();

    public List<int> pitTomboExtremo4 = new List<int>();

    public void ComecarJogo1()
    {
        pitTombo1.Clear();
        while (pitTombo1.Count<4)
        {
            int numeroAleatorio = random.Next(0, 10);
            if (!pitTombo1.Contains(numeroAleatorio))
            {
                pitTombo1.Add(numeroAleatorio);
            }

        }

        resultado.IniciarPalpites1(pitTombo1);

    }

    public void ComecarJogoExtremo()
    {
        pitTomboExtremo1.Clear();
        pitTomboExtremo2.Clear();
        pitTomboExtremo3.Clear();
        pitTomboExtremo4.Clear();
        
        while (pitTomboExtremo1.Count < 4)
        {
            int numeroAleatorio = random.Next(0, 10);
            if (!pitTomboExtremo1.Contains(numeroAleatorio))
            {
                pitTomboExtremo1.Add(numeroAleatorio);
            }

        }

        while (pitTomboExtremo2.Count < 4)
        {
            int numeroAleatorio = random.Next(0, 10);
            if (!pitTomboExtremo2.Contains(numeroAleatorio))
            {
                pitTomboExtremo2.Add(numeroAleatorio);
            }

        }

        while (pitTomboExtremo3.Count < 4)
        {
            int numeroAleatorio = random.Next(0, 10);
            if (!pitTomboExtremo3.Contains(numeroAleatorio))
            {
                pitTomboExtremo3.Add(numeroAleatorio);
            }

        }

        while (pitTomboExtremo4.Count < 4)
        {
            int numeroAleatorio = random.Next(0, 10);
            if (!pitTomboExtremo4.Contains(numeroAleatorio))
            {
                pitTomboExtremo4.Add(numeroAleatorio);
            }

        }

        resultado.IniciarPalpitesExtremo(pitTomboExtremo1, pitTomboExtremo2, pitTomboExtremo3, pitTomboExtremo4);



    }

}