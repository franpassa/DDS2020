
class TipoEntidad
{
    private Actividad actividad;
    private int cantidadDePersonal;
    private float promedioVentasAnuales;
    private Estructura estructura;
    public void definirEstructura()
    {

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

internal class Comercio : Actividad
{
    public Comercio() {
        CantidadPersonalMax = new int[4] { };
        PromedioVentasMax = new float[4] { };
    }
}

internal class Construccion : Actividad
{
    public Construccion()
    {
        CantidadPersonalMax = new int[4] { 12, 45, 200, 590};
        PromedioVentasMax = new float[4] { };
    }
}

internal class Servicios : Actividad
{
    public Servicios()
    {
        CantidadPersonalMax = new int[4] { };
        PromedioVentasMax = new float[4] { };
    }
}

internal class IndustriaMineria: Actividad
{
    public IndustriaMineria()
    {
        CantidadPersonalMax = new int[4] { };
        PromedioVentasMax = new float[4] { };
    }
}

internal class Agropecuario : Actividad
{
    public Agropecuario()
    {
        CantidadPersonalMax = new int[4] { };
        PromedioVentasMax = new float[4] { };
    }
}