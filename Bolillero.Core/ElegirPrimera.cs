namespace Bolillero.Core;

public class ElegirPrimera : IAzar
{
    public int ElegirBolillaAleatoria(List<int> bolillas)
    {
        return bolillas[0];
    }
}
