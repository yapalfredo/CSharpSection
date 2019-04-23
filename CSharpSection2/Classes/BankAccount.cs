using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpSection2.Classes
{
    public class BankAccount
    {
        private float balance;
        private string owner;

        //no need
        //public BankAccount()
        //{
        //    balance = 0;
        //    owner = "";
        //}

        //PROPERTY
        public float Balance
        {
            get
            {
                return balance;
            }

            //setter has to be private
            private set
            {
                if (value>=0)
                {
                    balance = value;
                }
                else
                {
                    balance = 0;
                }
                
            }
        }
        //PROPERTY
        public string Owner
        {
            get
            {
                return owner;
            }

            //setter has to be private
            private set
            {
                owner = value;
            }
        }

        public BankAccount(float balance, string owner)
        {
            Balance = balance;
            Owner = owner;
        }

        //set virtual for overloading from child
        public virtual float AddBalance(float balanceToBeAdded)
        {
            Balance = balance + balanceToBeAdded;
            return Balance;
        }

        public virtual float AddBalance(float balanceToBeAdded, bool balanceCanBeNegative)

        {
            if (balanceCanBeNegative)
            {
                balance = balance + balanceToBeAdded;
            }
            else
            {
                Balance = balance + balanceToBeAdded;
            }

            return Balance;
        }
        
        //asynchronus programming
        //this simulates fetching data from internet
        //in reality, you wouldn't know how long it would take

        //use '<data type>' if you want to return something
        public async Task<string> GetData()
        {
            Thread.Sleep(5000);
            return "Completed";
        }

    }
    
    //inheritance
    public class ChildBankAccount : BankAccount
    {
        public string Parent { get; set; }

        public ChildBankAccount(float balance, string owner, string parent) : base(balance, owner)
        {
            Parent = parent;
        }

        public override float AddBalance(float balanceToBeAdded)
        {
            if(balanceToBeAdded >= -10)
            {
                return base.AddBalance(balanceToBeAdded);
            }
            else
            {
                return Balance;
            }
        }

        public override float AddBalance(float balanceToBeAdded, bool balanceCanBeNegative)
        {
            if (balanceToBeAdded >= -10)
            {
                return base.AddBalance(balanceToBeAdded, balanceCanBeNegative);
            }
            else
            {
                return Balance;
            }
            
        }
    }

}
