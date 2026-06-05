namespace ProgramacionOrientadaObjetos.Business
{
    // Herencia
    public class ExpiringBeer : Beer
    {
        public DateTime Expiration { get; set; }

        public ExpiringBeer( string name, decimal price, decimal alcohol, DateTime expiration,
            int quantity)
            :base(name, price, alcohol, quantity)
        {
            Expiration = expiration;
            var p = Price;
        }

        // Estoy sobreescribiendo un metodo padre porque se usa la palabra reservada "override"
        public override string GetInfo()
        {
            return $"Cerveza con caducidad {Name}, Precio: {Price}, Alcohol: {Alcohol}," +
                $" Caducidad: {Expiration.Date.ToString()}";
        }
    }
}
