using System;
using System.Collections.Generic;
using System.Text;

namespace Cuentas
{
    public abstract class Account
    {
        public string IBAN;
        protected float Amount;
        public override bool Transaction(string path)
        {
            return true;
        }
    }

   

    public class Investing : Account
    {
        public float Interest;
        ApplyInterest();
    }

    public class Savings : Account
    {
        public float ProtectedAmount;
        LiberateSavings();
    } 

    public class LiberateSavings
    {

    }

    public class ApplyInterest
    {

    }
