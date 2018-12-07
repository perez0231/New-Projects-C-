using System;

namespace C_OOP
{
    


    class Human{
        public string Name {get; set; }
        public int Health {get; set; } = 100;
        public int Strength {get; set; }= 30;
        public int Intelligence {get; set; } = 20;
        public int Special {get; set; } = 3;

        public Human(string providedname){
            Name = providedname;
        }

        public Human(string provname, int provhealth, int provstrength, int provintelligence, int provspecial){
            Name = provname;
            Health  = provhealth;
            Strength = provstrength;
            Intelligence = provintelligence;
            Special= provspecial;
        }

        public void attack(object victim){
        var Victim = (Human) victim;
        int attackPower = Strength *2;
        Victim.Health -= attackPower;
        Console.BackgroundColor =ConsoleColor.DarkRed;
        Console.WriteLine($"{Name} Attacked {Victim.Name} resulting in {attackPower} damage, {Victim.Name} has {Victim.Health} health now!");
        Console.WriteLine(Victim.PlayerStatus() );

        }

        public string PlayerStatus(){

            return 
                $"Name: {Name}, Health: {Health}, Strength: {Strength}, Intelligence: {Intelligence}, Special: {Special}";
        }



        
    }

    class Program
    {
        static void Main(string[] args)
        {
        Human Player1 = new Human("Dan");
        Human Player2 = new Human("Bill");
        Player1.attack(Player2);
       
        }
    }

    
}


