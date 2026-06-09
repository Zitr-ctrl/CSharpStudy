namespace ProgramacionOrientadaObjetos.Business
{
    public class Beer : Drink
    {   
        private const string Category = "Cerveza";
        // _alcohol es un campo privado, un campo sirve para almacenar información y que
        // sea privado significa que solo se puede acceder a la clase a travez del código de la clase
        private decimal _alcohol;
        // Las propiedades ayudan a guardar y devolver datos, por convencion comienzan siempre en mayuscula
        public string Name { get; set; }
        protected decimal Price { get; set; }

        public static int QuantityObjects;
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
        public Beer(string name, decimal price, decimal alcohol, int quantity)
            :base(quantity)
        {
            Name = name;
            Price = price;
            Alcohol = alcohol;
            QuantityObjects++;

        }

        // Sobreescritura: La sobreescritura permite sobreescribir metodos de una clase Padre desde una clase hijo
        // Solo se peuden sobreescribir los emtodos que no tengan parametros de entrada.
        // Para que un metodo se pueda sobre escribir se usa la palabra reservada "virtual".
        public virtual string GetInfo()
        {
            return $"Nombre: {Name}, Precio: {Price}, Alcohol: {Alcohol}";
        }

        // Sobrecarga de metodos, se puede crear umetodos con el mismo nombre y con diferente comportamiento
        // siempre y cuando los parametros de cada metodo sean diferentes
        public string GetInfo(string message)
        {
            return message + " " + GetInfo() ;
        }

        public string GetInfo(int number)
        {
            return number + " " + GetInfo();
        }

        public override string GetCategory()
        {
            return Category;
        }
    }
}
