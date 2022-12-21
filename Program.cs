using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Income
    {
        public int _income = 45000;
        public int income { 
            get { return _income; } 
            set { 
                if(value <= 0)
                {
                    _income = 0;
                }
                else if(value > 45000 )
                {
                    _income = 45000;
                }
                else
                {
                    _income = value;
                }
            } 
        }
        public void Debit(int moneySpent)
        {
            _income = _income - moneySpent;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Income amountLeft = new Income();
            amountLeft.Debit(25000);
            Console.WriteLine(amountLeft.income);
            amountLeft.income = amountLeft.income - 50000;
            Console.WriteLine(amountLeft.income);
            amountLeft.income += 70000;
            Console.WriteLine(amountLeft.income);
            Console.ReadKey();
        }
    }
}
