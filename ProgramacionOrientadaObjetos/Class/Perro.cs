namespace ProgramacionOrientadaObjetos.Class
{
    public class Perro : Animal
    {
        public string Race { get; set; }
        public Perro(string name, int age, decimal weight, string race)
            :base(name, age, weight)
        {
            Race = race;
        }

        //public override string Tipo()
        //{
        //    return "El animal es domestico";
        //}

        public override string Sound()
        {
            return $"El perro ladró";
        }
    }
}
