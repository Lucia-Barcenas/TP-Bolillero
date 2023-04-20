namespace Bolillero.Core;

public class JugadaRandom : IAzar
{
    public int ElegirBolillaAleatoria(List<int> bolillas)
    {
        Random random = new Random();
        int num = random.Next(bolillas.Count);
        return bolillas[num];
    }
}
