using System;
namespace Abstracao_RPG.src.Entities.Human
{    public class Wizard : Hero
    {
        public Wizard(string Name, int Level)
        {
        this.Name = Name;
        this.Level = Level;
        this.TypeHero = "Wizard";
        this.TypeClass = "Human";
        this.Description = "Conseguem conjurar feitiços de diversos elementos e podem causar grande quantidade de dano em combate com suas magias. Suas habilidades lhe garantem um papel importante dentro do grupo. Eles podem tanto conjurar encantamentos ofensivos em um único oponente quanto devastar legiões inteiras com poderosos ataques de área.";
        this.Advantage = "Alto ataque mágico; Alta defesa mágica; Muito MP; Evolui rapidamente.";
        this.Disadvantage = "Pouco HP; Baixa defesa física; Alto consumo de MP; Baixa mobilidade.";
        }

        public void attack(){
            Random randNum = new Random();
            int aux = randNum.Next(10);
            if(aux > 7){
                Console.WriteLine("Você causou um dano crítico ao lançar uma magia!");
            }
            else Console.WriteLine("Você causou um dano médio ao lançar uma magia!");
            
        }
    }
}