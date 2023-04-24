namespace Bolillero.Core;
public class Bolillero
{
    public List<int> Bolillas { get; set; }
    public List<int> Afuera { get; set;}
    public IAzar Azar { get; set; }

    public Bolillero(int Bolillas, int Afuera, int Jugar, IAzar azar)
    {
        this.Bolillas = new List<int>();
        this.Afuera = new List<int>();
        this.Azar = azar;
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
        return bolilla;
    }

    public void MeterBolilla()
    {
        Bolillas.AddRange(Afuera);
        Afuera.Clear();
    }

    public void JugarNVeces(List<int> jugada, int cantidad)
    {
        var cantidadGanadas = 0;
        for (int i = 0; i < cantidad; i++)
    }
}
