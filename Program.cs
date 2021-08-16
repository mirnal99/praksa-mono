using System;
using System.Reflection.Metadata;
//access modifiers used: private, public, internal
namespace Day1
{
    class Program
    {
        abstract class Building
        {
            private string adress;
            // encapsulation
            internal int age;
            internal int number_of_windows;
            internal bool is__public;
            internal int residents;
            internal string color;


            public void BasicInfo()
            {
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Windows num.: " + number_of_windows);
                Console.WriteLine("Is it a public building?: " + is__public);
            }

            /*public virtual void ColorOf() 
            {
                Console.WriteLine("The color of a building");
            }*/
            public abstract void ColorOf();

            public virtual void EnterAdress() //polymorphism
            {
                Console.WriteLine("Enter an adress: ");
                adress = Console.ReadLine();
            }

            public virtual void GetAdress()
            {
                Console.WriteLine("The adress is: " + adress);
            }


        }


        static void ChangeReferenceType(House hs)
        {
            hs.color = "white";
        }

        class House : Building //inheritance
        {
            public string owner;

            public void NewResident()
            {
                base.residents += 1;
            }

            public override void ColorOf() //abstract method
            {
                Console.WriteLine("Color of a house is " + color);
            }


        }

        class School : Building
        {
            public int num_of_classes;

            public void Bell()
            {
                Console.WriteLine("Rinnnnng!");
            }

            public override void ColorOf()
            {
                Console.WriteLine("Color of a School is " + color);
            }
        }

        interface IPerson
        {
            void Occupation();

        }
        class Girl : IPerson
        {
            public void Occupation()
            {
                Console.WriteLine("Girl is a student. ");
            }

        }

        //generics:
        public class GenericList<T>
        {
            public void Add(T input) { }
        }

        static void Main(string[] args)
        {


            House villa = new House();
            villa.age = 83;
            villa.number_of_windows = 12;
            villa.is__public = false;
            villa.owner = "Alex B.";
            villa.residents = 3;
            villa.color = "yellow";
            villa.BasicInfo();
            Console.WriteLine("Num. of res.:" + villa.residents);
            villa.NewResident();
            Console.WriteLine("New num. of res.:" + villa.residents);
            villa.ColorOf();
            villa.EnterAdress();
            villa.GetAdress();

            Console.WriteLine("  ");
            School primary = new School();
            primary.age = 125;
            primary.number_of_windows = 52;
            primary.is__public = true;
            primary.color = "blue"; //reference type
            primary.ColorOf();
            primary.BasicInfo();
            //Console.WriteLine(" num. of res.:" + primary.residents);

            Console.WriteLine("  ");
            Girl ana = new Girl();
            ana.Occupation();

            // passing reference type value
            Console.WriteLine("  ");
            ChangeReferenceType(villa);
            villa.ColorOf();

            GenericList<string> list1 = new GenericList<string>();
            list1.Add(villa.color);
            list1.Add(primary.color);

            GenericList<int> list2 = new GenericList<int>();
            list2.Add(primary.age);
            list2.Add(villa.age);


        }



    }
}
