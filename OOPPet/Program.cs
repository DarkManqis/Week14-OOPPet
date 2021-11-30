using System;

namespace OOPPet
{
    class Program
    {

        class Pet
        {
            string name;
            int age;
            double weight;


            public Pet(string _name)
            {
                name = _name;
                age = 0;
                weight = 0.1;
                Console.WriteLine($"Congratulations! You've adopted {name}. ");
            }

            //getter for weight 
            public double Weight
            {
                get { return weight;}
            }

            public void ShowPetInfo()
            {
                Console.WriteLine($"Name: {name}. ");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Weight: {weight}");
            }

            public void Eat()
            {
                weight += 0.2; // Weight = weight + 0,2
                Console.WriteLine("Omnomnomnom");
            }

            public void Run()
            {
                weight -= 0.1;
                Console.WriteLine("spin-spin-spin");
            }

            //destructor

            //~Pet()
            //{
            //    Console.WriteLine($"RIP {name}");
            //}

        }


        static void Main(string[] args)
        {
            Pet myPet = new Pet("Hamster");
            myPet.ShowPetInfo();

            for(int i = 0; i < 10; i++)
            {
                myPet.Eat();
                Console.WriteLine($"Current weight: {myPet.Weight}");
                if(myPet.Weight >= 0.7)
                {
                    while(myPet.Weight > 0.7)
                    {
                        myPet.Run();
                        Console.WriteLine($"Weight after workout: {myPet.Weight}");
                    }
                    
                }
            }

            //GC.Collect();
        }
    }
}
