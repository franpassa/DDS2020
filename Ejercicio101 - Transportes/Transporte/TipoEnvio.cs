namespace Transporte
{

    public abstract class TipoEnvio
    {

        private float peso;
        private Ubicacion ubicacion;

        public TipoEnvio()
        {

        }

        public float Peso { get => peso; set => peso = value; }

        public Ubicacion getUbicacion()
        {
            return ubicacion;
        }

        public abstract float costo();

    }

}