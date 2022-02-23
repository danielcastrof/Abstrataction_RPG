namespace Abstracao_RPG.src.Entities
{

    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string TypeHero;
        public string TypeClass;
        public string Description;
        public string Advantage;
        public string Disadvantage;

        public Hero(string Name, int Level, string TypeHero, string TypeClass, string Description, string Advantage, string Disadvantage)
        {
            this.Name = Name;
            this.Level = Level;
            this.TypeHero = TypeHero;
            this.TypeClass = TypeClass;
            this.Description = Description;
            this.Advantage = Advantage;
            this.Disadvantage = Disadvantage;
        }

        public Hero()
        {

        }

        public override string ToString()
        {
            return "Nick: " + this.Name + "\n" + "Level: " + this.Level + "\n" + "Type Class: " + this.TypeClass + "\n" + "Type Hero: " + this.TypeHero + "\n" + "\n" + "Description: " + Description + "\n" + "\n" + "Advantage: " + Advantage + "\n" + "Disadvantage: " + Disadvantage;
        }
    }
}