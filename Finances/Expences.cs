using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    public class Expences
    {
        private string? name;
        private double amount;
        public Expences() { }
        public Expences(string? name, double amount)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Please enter a valid product name!");
            }
            if (amount < 0)
            { 
                throw new ArgumentException("Please enter a valid product amount!");
            }
            this.name = name;
            this.amount = amount;
        }

        public void InitializeExpense(string name, double amount)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Please enter a valid product name!");
            }
            if (amount < 0)
            {
                throw new ArgumentException("Please enter a valid product amount!");
            }
            this.name = name;
            this.amount = amount;
        }

        public string? getName()
        {
            return name;
        }

        public double getAmount() 
        {
            return amount;
        }
        public string GetInfo()
        {
            return $"{name} - {amount:N2}";
        }

    }
}
