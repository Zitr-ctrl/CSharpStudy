namespace ProgramacionOrientadaObjetos.Business
{
    // Una clase abstarcta sirven como una base común para otras clases,
    // pero que no pueden ser instanciadas directamente.
    public abstract class Drink
    {
        public int Quantity { get; set;}

        public Drink(int quantity)
        {
            Quantity = quantity;
        }

        public string GetQuantity()
        {
            return $"La cantidad de bebida es: {Quantity} ml";
        }

        public abstract string GetCategory();
    }
}
