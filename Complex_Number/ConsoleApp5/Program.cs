namespace ComplexNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber complex = new ComplexNumber(4, 5);

            double value = complex.AbsoluteValue();
            Console.WriteLine("The absolute value of complex number is: " + value);

            ComplexNumber result = complex + 3;
            ComplexNumber result1 = complex - 2;
            ComplexNumber result2 = complex * 4;

            Console.WriteLine("complex + 3: " + result);
            Console.WriteLine("complex - 2: " + result1);
            Console.WriteLine("complex * 4: " + result2);

            double realPart = complex; 
            Console.WriteLine("Real Part: " + realPart);
            
            double val = 5;
            ComplexNumber newComplex = (ComplexNumber)val; 
            Console.WriteLine("New Complex: " + newComplex);
        }
    }
}