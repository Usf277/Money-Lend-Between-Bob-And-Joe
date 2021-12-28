using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy Joe = new Guy() { Name = "Joe" , Cash = 50};
            Guy Bob = new Guy() { Name = "Bob", Cash = 100 };
            Joe.WriteMyInfo();
            Bob.WriteMyInfo();

            do
            {
                Console.Write("Enter An Amount : ");
                double Amount = double.Parse(Console.ReadLine());
                Console.Write("Who Should Give Money To Who ?");
                string MoneyGiver = Console.ReadLine();
                if (MoneyGiver == "Joe")
                {
                    Joe.GiveCash(Amount);
                    Bob.ReceiveCash(Amount);
                    Joe.WriteMyInfo();
                    Bob.WriteMyInfo();
                }
                if (MoneyGiver == "Bob")
                {
                    Bob.GiveCash(Amount);
                    Joe.ReceiveCash(Amount);
                    Joe.WriteMyInfo();
                    Bob.WriteMyInfo();
                }
                if (MoneyGiver != "Bob||Joe")
                {
                    Console.WriteLine("Enter A Valid Name !");
                }
            } while (true);
        }
    }
    class Guy
    {
        private string _Name;
        private double _Cash;

        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        public double Cash
        {
            set { _Cash = value; }
            get { return _Cash; }
        }
        public void WriteMyInfo ()
        {
            Console.WriteLine("My Name Is {0} And I have {1}",Name,Cash);
        }
        public double GiveCash(double amount )
        {
            if (amount <= 0)
            {
                Console.WriteLine("{0} Says {1} Isn't Valid !",Name,amount);
                return 0; 
            }
            if (amount > Cash)
            {
                Console.WriteLine("{0} Says I Dont Have Enough Money To Give You {1}",Name,amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }
        public void ReceiveCash(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("{0} Says {1} Is Not Amount I Will Take !",Name,amount);
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
