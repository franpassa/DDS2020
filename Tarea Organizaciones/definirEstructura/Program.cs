
using System.Security.Cryptography.X509Certificates;

class TipoEntidad
{
    private Actividad actividad;
    private int cantidadDePersonal;
    private float promedioVentasAnuales;
    private Estructura estructura;
    bool esActividadComisionista;
    bool esAgenciaDeViaje;
    public void definirEstructura()
    {
        if (this.esActividadComisionista || this.esAgenciaDeViaje){
            for (int i = 0; i < 4; i++) {
                if (cantidadDePersonal <= actividad.CantidadPersonalMax[i]){
                    this.definirTamaño(i);
                }
            }
        } else {
            for (int i = 0; i < 4; i++){
                if (promedioVentasAnuales <= actividad.PromedioVentasMax[i] && cantidadDePersonal <= actividad.CantidadPersonalMax[i]){
                    this.definirTamaño(i);
                }
            }
        }
    }

    public void definirTamaño(int i)
    {
        switch (i)
        {
            case 0:
                estructura = new Micro();
                break;
            case 1:
                estructura = new Pequeña();
                break;
            case 2:
                estructura = new MedianaTramo1();
                break;
            case 3:
                estructura = new MedianaTramo2();
                break;
        }
    }
}


internal class Estructura
{

}

internal class Micro : Estructura
{

}

internal class MedianaTramo1 : Estructura
{

}

internal class MedianaTramo2 : Estructura
{

}
internal class Pequeña : Estructura
{

}

internal class Actividad
{
    private float[] promedioVentasMax;
    private int[] cantidadPersonalMax;

    public int[] CantidadPersonalMax { get => cantidadPersonalMax; set => cantidadPersonalMax = value; }
    public float[] PromedioVentasMax { get => promedioVentasMax; set => promedioVentasMax = value; }
}

internal class Construccion : Actividad
{
    public Construccion()
    {
        CantidadPersonalMax = new int[4] { 12, 45, 200, 590};
        PromedioVentasMax = new float[4] { 15230000, 90310000, 503880000, 755740000};
    }
}

internal class Servicios : Actividad
{
    public Servicios()
    {
        CantidadPersonalMax = new int[4] { 7, 30, 165, 535 };
        PromedioVentasMax = new float[4] { 8500000, 50950000, 425170000, 607210000};
    }
}

internal class Comercio : Actividad
{
    public Comercio() {
        CantidadPersonalMax = new int[4] { 7, 35, 125, 345};
        PromedioVentasMax = new float[4] { 29740000, 178860000, 1502750000, 2146810000};
    }
}
internal class IndustriaMineria: Actividad
{
    public IndustriaMineria()
    {
        CantidadPersonalMax = new int[4] { 15, 60, 235, 655};
        PromedioVentasMax = new float[4] { 25540000, 190410000, 1190330000, 1739590000};
    }
}

internal class Agropecuario : Actividad
{
    public Agropecuario()
    {
        CantidadPersonalMax = new int[4] { 5, 10, 50, 215};
        PromedioVentasMax = new float[4] { 12890000, 48480000, 345430000, 547890000};
    }
}
