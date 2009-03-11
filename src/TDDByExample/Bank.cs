using System;
using System.Collections;
using System.Collections.Generic;

namespace TDDByExample
{
    public class Bank
    {
        private Dictionary<Pair,int> _rates = new Dictionary<Pair,int>();

        public Dictionary<Pair,int> Rates
        {
            get{ return _rates;}
            
        }
        public Money Reduce(IExpression src, string to)
        {
            return src.Reduce(this,to);
        }

        public void AddRate(string from, string to, int rate)
        {
           _rates.Add(new Pair(from,to),rate);
        }

        public int Rate(string from, string to)
        {
            if (from == to)
                return 1;
            int rate = _rates[new Pair(from, to)];
            return rate;
            
        }
    }
}