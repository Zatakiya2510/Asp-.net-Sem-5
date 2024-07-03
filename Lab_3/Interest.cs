using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public abstract class RBI
    {
        public abstract void calculateInterest(int i, int p, int r);
    }

    public class HDFC : RBI
    {
        public override void calculateInterest(int i, int p, int r)
        {
            Console.WriteLine("Interest Of HDFC= " + (i*p*r)/100);
        }
    }

    public class SBI : RBI
    {
        public override void calculateInterest(int i, int p, int r)
        {
            Console.WriteLine("Interest Of SBI = " + (i * p * r) / 100);
        }
    }

    public class ICICI : RBI
    {
        public override void calculateInterest(int i, int p, int r)
        {
            Console.WriteLine("Interest Of ICICI= " + (i * p * r) / 100);
        }
    }
}
