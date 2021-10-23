using System;
using System.Net;

namespace OOP_3_whales
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var passport = new Passport("Ivan", "Ivanov", 33);
           
            Console.WriteLine(passport.Age);

            PassportValidator validator = new PassportValidator(new WebRequester());

            validator.Validate(passport);
            Console.WriteLine(passport.Age);*/

            var furniture = new Furniture(5);
            furniture.Buy();

            var chair = new Chair(10, 4);
            chair.Buy();
            chair.Sit();

            Console.ReadKey();
        }
    }

    class Furniture
    {
        private int cost;

        public Furniture(int cost)
        {
            Console.WriteLine($"Furniture create. Cost {cost}");

            this.cost = cost;
        }

        public virtual void Buy()
        {
            Console.WriteLine($"I'm buying method. Cost {cost}");
        }
    }

    class Chair : Furniture
    {
        private int legsCount;
        public Chair(int cost, int legsCount) : base(cost)
        {
            this.legsCount = legsCount;
            Console.WriteLine($"Chair create. Cost {cost}. Legs {legsCount}");
        }

        public override void Buy()
        {
            Console.WriteLine("I'm new buying method.");

        }
        public void Sit()
        {
            Console.WriteLine("I'm sitting method.");

        }
    }
    class Table : Furniture
    {
        public Table(int cost) : base(cost)
        {
            Console.WriteLine($"Table create. Cost {cost}");

        }
        public void Eat()
        {
            Console.WriteLine("I'm eating method.");

        }
    }

    /*class Passport
    {
        public Passport(string firstname, string lastName = null, int age = 0)
        {
            Firstname = firstname;
            LastName = lastName;
            Age = age;
        }

        public string Firstname { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }


    }

    class PassportValidator
    {
        private WebRequester webRequester;

        public PassportValidator(WebRequester webRequester)
        {
            this.webRequester = webRequester;
        }

        public void Validate(Passport passport)
        {
            var age = 0;
            if (passport.Age < 18)
            {
                age = 0;
            }
            else
            {
                age = 18;
            }
            if (passport.Age == 0)
            {
                //  
            }
            else
            {
                //
            }

            webRequester.Request("https://google.com");

        }

    }

    class WebRequester 
    { 
        public void Request(string url)
        {
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
        }
    }*/


}
