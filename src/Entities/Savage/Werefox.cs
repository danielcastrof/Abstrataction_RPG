using System;
namespace Abstracao_RPG.src.Entities.Savage
{
    public class Werefox : Hero
    {
        public Werefox(string Name, int Level)
        {
        this.Name = Name;
        this.Level = Level;
        this.TypeHero = "Werefox";
        this.TypeClass = "Savage";
        this.Description = "Dentro do grupo, as Feiticeiras preferem agir minando a resistência adversária, seja lançando seus ataques venenosos à distância ou usando a ajuda dos animais da floresta para atacar seus inimigos.";
        this.Advantage = "Muito MP; Alta defesa mágica; Alta defesa física (quando em forma de raposa); Pode usar monstros para atacar seus inimigos.";
        this.Disadvantage = "Pouco HP; Dano físico baixo em forma humana.";
        }

          public void attack(){
            Random randNum = new Random();
            int aux = randNum.Next(10);
            if(aux > 7){
                Console.WriteLine("Você causou um dano crítico ao lançar uma magia na forma de raposa!");
            }
            else Console.WriteLine("Você causou um dano médio ao lançar uma magia!");
          }
        
    }
}