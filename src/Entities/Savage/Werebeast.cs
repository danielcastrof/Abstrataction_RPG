using System;
namespace Abstracao_RPG.src.Entities.Savage
{
    public class Werebeast : Hero
    {
        public Werebeast(string Name, int Level)
        {
        this.Name = Name;
        this.Level = Level;
        this.TypeHero = "Werebeast";
        this.TypeClass = "Savage";
        this.Description = "São guerreiros formidáveis, de força e agilidade dignas de seus ancestrais. Conseguem canalizar sua ferocidade e transformá-la em poder de batalha. Podem enfrentar uma ampla quantidade de inimigos e ainda sair vitoriosos sem nenhum tipo de ajuda. Também conseguem assumir a forma de um tigre para aumentar sua defesa ou obter mais velocidade ao atravessar grandes territórios.";
        this.Advantage = "Muito HP; Alta defesa física; Alta velocidade em forma animal.";
        this.Disadvantage = "Baixa velocidade de ataque; Baixa defesa mágica; Baixa velocidade em forma humana.";
        }

          public void attack(){
            Random randNum = new Random();
            int aux = randNum.Next(10);
            if(aux > 5){
                Console.WriteLine("Você causou um dano crítico ao atacar em forma de tigre!");
            }
            else Console.WriteLine("Você causou um dano médio ao atacar com o machado!");
            
        }
    }
}