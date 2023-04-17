namespace Bolillero.Core;
public class Bolillero
{
    public int cantidad { get; set;}
    public List<int> Bolillas { get; set; }
    public IAzar Azar { get; set; }

    public Bolillero(int cantidad, int Bolillas, IAzar azar)
    {
        this.cantidad = cantidad;
        this.Bolillas = new List<int>();
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
        Azar.ElegirBolilla();
    }

    public void MeterBolilla(){}

    public void JugarNVeces(List<int> JugarNVeces){}
}
