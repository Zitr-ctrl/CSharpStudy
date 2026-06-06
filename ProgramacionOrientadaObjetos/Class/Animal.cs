namespace ProgramacionOrientadaObjetos.Class
{
    public abstract class Animal
    {
        String Name { get; set; }
        int Age { get; set; }
        decimal Weight { get; set; }

        public Animal(string name, int age, decimal weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public string getInfo()
        {
            return $"El animal es un {Name}, tiene {Age} años y pesa {Weight} lb";
        }

        public virtual string Tipo()
        {
            return "El animal puede ser domestico o salavaje";
        }

        public abstract string Sound();
    }
}
