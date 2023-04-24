namespace Bolillero.Core;

public class AzarRandom : IAzar
{
    public int ElegirBolillaAleatoria(List<int> bolillas)
    {
        Random random = new Random();
        int num = random.Next(bolillas.Count);
        return bolillas[num];
    }
}
