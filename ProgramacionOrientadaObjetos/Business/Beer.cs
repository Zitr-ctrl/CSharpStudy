namespace ProgramacionOrientadaObjetos.Business
{
    public class Beer
    {
        // _alcohol es un campo privado, un campo sirve para almacenar información y que
        // sea privado significa que solo se puede acceder a la clase a travez del código de la clase
        private decimal _alcohol;
        // Las propiedades ayudan a guardar y devolver datos, por convencion comienzan siempre en mayuscula
        public string Name { get; set; }
        protected decimal Price { get; set; }
        public decimal Alcohol
        {
            get { return _alcohol; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _alcohol = value;
            }
        }

        // Metodo constructor (tiene el mismo nombre de la clase)
        public Beer(string name, decimal price, decimal alcohol)
        {
            Name = name;
            Price = price;
            Alcohol = alcohol;
        }

        public string getInfo()
        {
            return $"Nombre: {Name}, Precio: {Price}, Alcohol: {Alcohol}";
        }
    }
}
