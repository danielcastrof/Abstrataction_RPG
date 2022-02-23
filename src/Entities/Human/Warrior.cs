using System;
namespace Abstracao_RPG.src.Entities.Human
{
    public class Warrior : Hero
    {
        public Warrior(string Name, int Level)
        {
        this.Name = Name;
        this.Level = Level;
        this.TypeHero = "Warrior";
        this.TypeClass = "Human";
        this.Description = "Especialistas no combate corpo a corpo, estes Guerreiros representam a base para qualquer grupo de aventureiros. São famosos por sua força e resistência durante os combates. Geralmente possuem um equilíbrio entre suas características de força, defesa e destreza, podendo assim utilizar armaduras pesadas e manusear uma maior variedade de armas.";
        this.Advantage = "Melhor classe para atordoar os inimigos; Classe balanceada e versátil; Boa velocidade de ataque; Alta defesa física e HP.";
        this.Disadvantage = "Baixa defesa mágica; Não causa dano mágico; Não possui uma especialização.";
        }

        public void attack(){
            Random randNum = new Random();
            int aux = randNum.Next(10);
            if(aux > 5){
                Console.WriteLine("Você causou um dano crítico ao atacar com a espada!");
            }
            else Console.WriteLine("Você causou um dano médio ao atacar com a espada!");
            
        }
    }
}