﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StatePattern
{
    //Create Concrete State
    public class DebitCardNotInsertedState : IATMState
    {
        public void InsertDebitCard()
        {
            Console.WriteLine("DebitCard Inserted");
        }
        public void EjectDebitCard()
        {
            Console.WriteLine("You cannot eject the Debit CardNo, as no Debit Card in ATM Machine slot");
        }
        public void EnterPin()
        {
            Console.WriteLine("you cannot enter the pin, as No Debit Card in ATM Machine slot");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("you cannot withdraw money, as No Debit Card in ATM Machine slot");
        }
    }
}
