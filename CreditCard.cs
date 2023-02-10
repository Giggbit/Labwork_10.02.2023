using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_10._02._2023
{
    internal class CreditCard
    {
        private string name;
        private string surname;
        private string num_card;
        private string date;
        private int cvv;
        private int amount_of_money;

        public CreditCard() { }
        public CreditCard(string n, string s, string nc, string d, int c, int a) {
            name = n;
            surname = s;
            num_card = nc;
            date = d;
            cvv = c;
            amount_of_money = a;
        }
            
        public void Enter() {
            int count = 0;
            while (count != 5) {
                try
                {
                    Console.Write("Enter your name: ");
                    name = Console.ReadLine();
                    if (name.Length <= 1)
                    {
                        throw new Exception("Minimal amount words = 2!");
                    }
                    count++;
                    Console.Write("Enter your surname: ");
                    surname = Console.ReadLine();
                    if (surname.Length <= 2)
                    {
                        throw new Exception("Minimal amount words = 3!");
                    }
                    count++;
                    Console.Write("Enter your card number: ");
                    num_card = Console.ReadLine();
                    if (num_card.Length != 16)
                    {
                        throw new Exception("card number must be sixteen-digit!");
                    }
                    count++;
                    Console.Write("Enter card expiration date: ");
                    date = Console.ReadLine();
                    if (date.Length != 10)
                    {
                        throw new Exception("Card expiration date must be ten-digit!");
                    }
                    count++;
                    Console.Write("Enter your cvv code: ");
                    string c = Console.ReadLine();
                    if (c.Length != 3)
                    {
                        throw new Exception("cvv code must be three-digit!");
                    }
                    count++;
                    cvv = Convert.ToInt32(c);
                    Console.Write("Enter amount of money: ");
                    string a = Console.ReadLine();
                    amount_of_money = Convert.ToInt32(a);  
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    count = 0;
                }
            }
            
        }
        public void Print() {
            Console.WriteLine($"\nName: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Card number: {num_card}");
            Console.WriteLine($"Expiration date: {date}");
            Console.WriteLine($"cvv: {cvv}");
            Console.WriteLine($"Balance: {amount_of_money}");
        }

        public static CreditCard operator + (CreditCard obj, int a) { 
            CreditCard card = new CreditCard();
            card.amount_of_money = obj.amount_of_money + a;
            return card;
        }
        public static CreditCard operator - (CreditCard obj, int a) { 
            CreditCard card = new CreditCard();
            card.amount_of_money = obj.amount_of_money - a;
            return card;
        }

        public static bool operator == (CreditCard lhs, CreditCard rhs) {
            if (lhs.cvv == rhs.cvv)
                return true;
            else
                return false;
        }
        public static bool operator != (CreditCard lhs, CreditCard rhs) {
            if (lhs.cvv != rhs.cvv)
                return true;
            else
                return false;
        }

        public static bool operator < (CreditCard lhs, CreditCard rhs) { 
            if(lhs.amount_of_money < rhs.amount_of_money)
                return true;
            else 
                return false;
        }
        public static bool operator > (CreditCard lhs, CreditCard rhs) { 
            if(lhs.amount_of_money > rhs.amount_of_money)
                return true;
            else 
                return false;
        }

    }
}
