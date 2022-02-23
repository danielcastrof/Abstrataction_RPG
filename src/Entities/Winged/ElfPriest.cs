using System;
namespace Abstracao_RPG.src.Entities.Winged
{
    public class ElfPriest : Hero
    {
        public ElfPriest(string Name, int Level)
        {
        this.Name = Name;
        this.Level = Level;
        this.TypeHero = "Elf Priest";
        this.TypeClass = "Winged";
        this.Description = "Eles são gentis e amáveis com todas as raças, não poupando esforços em ajudá-las no que for preciso. Sua mera presença já é capaz de amenizar as aflições dos seres ao seu redor.";
        this.Advantage = "Muito MP; Alta defesa mágica; Possuem as melhores magias de cura; Podem ser defensivos ou ofensivos.";
        this.Disadvantage = "Pouco HP; Baixa mobilidade; Atrai atenção dos monstros quando utiliza magias de cura.";
        }

         public void attack(){
            Random randNum = new Random();
            int aux = randNum.Next(10);
            if(aux > 8){
                Console.WriteLine("Você causou um dano crítico ao lançar uma magia!");
            }
            else Console.WriteLine("Você causou um dano médio ao lançar uma magia!");
          }

           public void cure(){
            Random randNum = new Random();
            int aux = randNum.Next(10);
            if(aux > 5){
                Console.WriteLine("Você curou todos os aliados no raio de 20 metros!");
            }
            else Console.WriteLine("Você curou um aliado!");
          }
    }
}