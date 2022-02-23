using System;
namespace Abstracao_RPG.src.Entities.Winged
{
    public class ElfArcher : Hero
    {
        public ElfArcher(string Name, int Level)
        {
        this.Name = Name;
        this.Level = Level;
        this.TypeHero = "Elf Archer";
        this.TypeClass = "Winged";
        this.Description = "Sua aptidão em aprender os caminhos mágicos possibilitou que eles transformassem sua arma em algo ainda mais mortal. Eles ainda podem enfeitiçar sua munição antes de cada disparo.";
        this.Advantage = "Melhor atacante à distância; Boa precisão e esquiva; Alta taxa de acerto crítico; Causam dano físico e mágico.";
        this.Disadvantage = "Pouco HP; Baixa defesa física, Dano baixo quando em combates de curta distância.";
        }

         public void attack(){
            Random randNum = new Random();
            int aux = randNum.Next(10);
            if(aux > 4){
                Console.WriteLine("Você causou um dano crítico ao atacar com arco à longa distância!");
            }
            else Console.WriteLine("Você causou um dano médio ao atacar com arco à curta distância!");
          }
    }
}