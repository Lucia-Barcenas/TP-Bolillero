namespace Bolillero.Core;
public class Bolillero
{
    public List<int> Bolillas { get; set; }
    public List<int> Afuera { get; set;}
    public IAzar Azar { get; set; }

    public Bolillero(int Bolillas, int Numeros, int Jugar, IAzar azar)
    {
        this.Bolillas = new List<int>();
        this.Afuera = new List<int>();
        this.Azar = azar;
    }

    public bool Jugar(List<int> Azar){
        for (int i = 0; i < Azar.Count; i++)
        {

        }
        return true;
    }

    public int SacarBolilla()
    {
        var bolilla = Azar.ElegirBolillaAleatoria(Bolillas);
    }

    public void MeterBolilla()
    {
        
    }

    public void JugarNVeces(List<int> JugarNVeces){}
}
