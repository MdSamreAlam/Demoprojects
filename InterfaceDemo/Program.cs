using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int P, T;
            float R;
            Console.WriteLine("Enter All details to calculate Interest");
            Console.Write("Enter Amount :");
            P = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Rate :");
            R = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Time :");
            T = Convert.ToInt32(Console.ReadLine());
           
            //simpleInterest_CompoundInterestcalculation simpleInterest_CompoundInterestcalculation = new simpleInterest_CompoundInterestcalculation();
            I1 i1 = FactoryClass.GetSiCi(0);
            Console.WriteLine("Total Interest  is: {0}", i1.Interest(P, T, R));
          //float result=  i1.Interest(P, T, R);
           
            //calculatecompound Interest
            Console.WriteLine("Enter details to Calculate compound Interest");
            double amount;
            double interest;
            int years;
            // double balance = 0;

            Console.Write("Enter the Amount:");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Interest Rate:");
            interest = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Enter number of Years:");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Amount Balance is: {0}", i1.CalculateCompoundInterest(amount, interest, years));      
            Console.ReadLine();
        }
    }
    public interface I1
    {
        float Interest(int P, int T, float R);
        double CalculateCompoundInterest(double amount, double interest, int years);



    }
    //public interface I2
    //{
    //    double CalculateCompoundInterest(double amount, double interest, int years);
    //}
    public class simpleInterest_CompoundInterestcalculation : I1
    {
        public float Interest(int P, int T, float R)
        {
            float s;
            s = P * R * T / 100;
            return s;
        }

        public double CalculateCompoundInterest(double amount, double interest, int years)
        {
            double balance = 0;
            //int loop = 0;

            
                balance = amount * Math.Pow((1 + interest), years);

            return balance;

        }

    }
    public static class FactoryClass
    {
        public static I1 GetSiCi(int Id)
        {
            switch (Id)
            {
                case 0:
                    return new simpleInterest_CompoundInterestcalculation();
             
                default:
                    return null;
            }
        }
    }
}
   

