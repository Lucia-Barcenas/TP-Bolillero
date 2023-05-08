namespace Bolillero.Core;
public class Bolillero
{
    public List<int> Bolillas { get; set; }
    public List<int> Afuera { get; set; }
    public IAzar Azar { get; set; }

    public Bolillero(int Bolillas, IAzar azar)
    {
        this.Bolillas = new List<int>();
        this.Afuera = new List<int>();
        this.Azar = azar;
        CrearBolilla(Bolillas);
    }

    public void CrearBolilla(int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
            Bolillas.Add(i);
    }

    public bool Jugar(List<int> jugada)
    {
        for (int i = 0; i < jugada.Count; i++)
        {
            var bolilla = SacarBolilla();
            if (bolilla != jugada[i])
                return false;
        }
        return true;
    }

    public int SacarBolilla()
    {
        var bolilla = Azar.ElegirBolillaAleatoria(Bolillas);
        Bolillas.Remove(bolilla);
        Afuera.Add(bolilla);
        return bolilla;
    }

    public void MeterBolillas()
    {
        Bolillas.AddRange(Afuera);
        Afuera.Clear();
    }

    public int JugarNVeces(List<int> jugada, int cantidad)
    {
        int cantidadGanadas = 0;
        for (int i = 0; i < cantidad; i++)
        {
            MeterBolillas();
            if (Jugar(jugada))
            {
                cantidadGanadas++;
            }
        }
        return cantidadGanadas;
    }
}
