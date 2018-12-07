using System;
using System.Collections.Generic;


namespace FirstAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bill");
            Tanks Abrams = new Tanks(2);
            Console.WriteLine($"The Max range of this tank is {Abrams.maxrange}");
            Tanks paladin = new Tanks(100);
            Console.WriteLine($"The Max range of the Paladin tank is {paladin.maxrange}");
            Console.WriteLine($"The crew on this tank is {paladin.numberofcrew} and it is from {paladin.country}");
            Abrams.shootCannon();
            paladin.shootCannon(5);
            
                     
        }
    }

    public class Tanks{
            
    public int maxrange;
    public int numberofcrew;
    public string country;

    public Tanks(int val){
    maxrange = val;
    numberofcrew = 5;
    country = "USA";
    }
    public void shootCannon(){
    Console.WriteLine("Bang");
    }
    public void shootCannon(int val){
     Console.WriteLine($"cannon fired{val} times");

    }

    }

}