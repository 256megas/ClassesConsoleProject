using System;

namespace ClassesConsoleProject
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Classes

            Animal dog = new Animal();
            dog.toString();
            dog.name = "Patata";
            dog.toString();

            Animal.count++;

            Console.WriteLine(Animal.count);

            Animal cat = new Animal("Agato" , 3, 0.8f);
            cat.toString();
            



            Console.ReadKey();
        }
    }

    class Animal
    {
        public static int count = 0;
        //private by default 
        public string name ;
        public int age;
        public float hapiness;

        public Animal()
        {
            name = "Spotty";
            age = 6;
            hapiness = 0.5f;
            count++;
        }

        public Animal(string _name,int _age,float _happiness)
        {
            name = _name;
            age = _age;
            hapiness = _happiness;
            count++;
        }

        public void toString()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Hapiness: " + hapiness);
            Console.WriteLine("************************************");

        }

    }

}
