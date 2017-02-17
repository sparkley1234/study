using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5
{
    public class Animal
    {
        protected string name { get; set; }
        protected string speak { get; set; }
        public Animal()
        {

        }
        public Animal(string name, string speak)
        {
            this.name = name;
            this.speak = speak;
        }
        public void DescribeAnimal()
        {
            Console.WriteLine("My name is "+name + " and I speak : " + speak);
            Console.ReadLine();
        }
        public virtual void Fly()
        {
            Console.WriteLine("I am animal, I dont know.");
            Console.ReadLine();
        }

    }
    public class Dog : Animal
    {
        public Dog(string name, string speak) :base( name,  speak)
        {

        }

    }
    public class Duck : Animal
    {
        public Duck(string name, string speak) : base(name, speak)
        {

        }
        //public void DescribeAnimal()
        //{
        //Severity	Code	Description	Project	File	Line	Suppression State
        //Warning CS0108	'Duck.DescribeAnimal()' hides inherited member 'Animal.DescribeAnimal()'. Use the new keyword if hiding was intended.CS5 D:\Study\CSBasicCodes\CS5\CS5\Program.cs
        //}
        public new void DescribeAnimal()
        {
            Console.WriteLine("My name is " + name + " and I speak : " + speak + "and you know, I can not fly");
            Console.ReadLine();
        }

    }

    public class Eagle  : Animal
    {
        public Eagle(string name, string speak) : base(name, speak)
        {

        }

        public new void DescribeAnimal()
        {
            Console.WriteLine("My name is " + name + " and I speak : " + speak + "and you know, I can fly high");
            Console.ReadLine();
        }
        public override void Fly()
        {
            Console.WriteLine("I can fly high.");
            Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Animal1", "I dont know, what to speak");
            animal.DescribeAnimal();

            Dog dog = new Dog("German Shepherd", "Bow Bow");
            dog.DescribeAnimal();
            //Duck duck = new Duck();
            //Severity	Code	Description	Project	File	Line	Suppression State
            //Error CS7036  There is no argument given that corresponds to the required formal parameter 'name' of 'Duck.Duck(string, string)'  CS5 D:\Study\CSBasicCodes\CS5\CS5\Program.cs    61  Active
            Duck duck = new Duck("Duck1", "Pawk Pawk");
            duck.DescribeAnimal();
            
            Animal animal2 = new Duck("Duck3", "Pawk Pawk");
            animal2.DescribeAnimal();// called parent method

            Eagle eagle = new Eagle("Eagle1", "Shut Up");
            eagle.Fly();
            Animal animal3 = new Eagle("Eagle2", "Shut Up");
            animal3.Fly();// override parent method, called Eagle method

        }
    }
}
