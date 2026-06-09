namespace ProgramacionOrientadaObjetos.Business
{
    public interface ISalable
    {
        // Las interfaces en C# son contratos que definen qué debe hacer una clase, pero no cómo lo hace.

        // Una interfaz contiene firmas de métodos, propiedades, eventos o índices que una clase debe implementar.

        public decimal GetPrice();
    }
}
