using System;
using System.Collections.Generic;

namespace LoopHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person personX = new Person();
            //personX.FirstName = "";
            //personX.LastName = "";
            //personX.Employed = true/false;
            //personX.Money = ;

            Person person1 = new Person();
            person1.FirstName = "Jaakko";
            person1.LastName = "Möykkylä";
            person1.Employed = true;
            person1.Money = 2300;

            Person person2 = new Person();
            person2.FirstName = "Jani";
            person2.LastName = "Pajala";
            person2.Employed = false;
            person2.Money = 600;

            Person person3 = new Person();
            person3.FirstName = "Taija";
            person3.LastName = "Miekelä";
            person3.Employed = true;
            person3.Money = 1200;

            Hobby hobby1 = new Hobby();
            hobby1.Name = "running";
            hobby1.MonthlyCost = 100;

            Hobby hobby2 = new Hobby();
            hobby2.Name = "wines";
            hobby2.MonthlyCost = 250;

            Hobby hobby3 = new Hobby();
            hobby3.Name = "gaming";
            hobby3.MonthlyCost = 50;

            Hobby hobby4 = new Hobby();
            hobby4.Name = "golf";
            hobby4.MonthlyCost = 500;

            //Jos List<LuokkaX> vallittaa, tarkista että System.Collections.Generic; on using tilassa Program välilehdellä
            List<Person> people = new List<Person>();            

            //Miten lisätä objecteja listaan
            //listname.Add(objecti);
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);

            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
                Console.WriteLine(person.Money);
            }

            Console.WriteLine();
            Console.WriteLine("If metodilla katsotaan jos person.Money > 1000");
            Console.WriteLine();

            foreach (var person in people)
            {
                //if metodi katsoo jos henkilöllä on alle 1000 Money objectia
                if (person.Money < 1000)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName}");
                    Console.WriteLine(person.Money);
                }

            }

            //Lisää 'running' hobbyn
            foreach (var person in people)
            {
                if (person.Money < 1000)
                {
                    person.hobbies.Add(hobby1);
                }
            }

            //lisää 'wines' hobbyn
            foreach (var person in people)
            {
                if (person.Money > 1000)
                {
                    person.hobbies.Add(hobby2);
                }
            }

            //lisää 'gaming' hobbyn
            foreach (var person in people)
            {
                if (person.Money > 500)
                {
                    person.hobbies.Add(hobby3);
                }
            }

            //lisää 'golf' hobbyn
            foreach (var person in people)
            {
                if (person.Money > 1500)
                {
                    person.hobbies.Add(hobby4);
                }
            }

            Console.WriteLine();

            //Tulostaa nimet, rahat, harrastuksen sekä harrastuksen kuukausittaiset kulut
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Money}");

                foreach (var hobby in person.hobbies)
                {
                    Console.WriteLine($"{hobby.Name} {hobby.MonthlyCost}");
                }

                Console.WriteLine();
            }
        }
    }
}
