using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    public class ComplexNumber
    {
        private double Real { get; set; }
        private double Imaginary { get; set; }
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public double AbsoluteValue()
        {
            return Math.Sqrt(Real * Real + Imaginary * Imaginary);
        }
        //overloading +
        public static ComplexNumber operator +(ComplexNumber a, double scalar)
        {
            return new ComplexNumber(a.Real + scalar, a.Imaginary);
        }
        //overloading -
        public static ComplexNumber operator -(ComplexNumber a, double scalar)
        {
            return new ComplexNumber(a.Real - scalar, a.Imaginary);
        }
        //overloading *
        public static ComplexNumber operator *(ComplexNumber a, double scalar)
        {
            return new ComplexNumber(a.Real * scalar, a.Imaginary);
        }
        //overloading iplicit cast
        public static implicit operator double(ComplexNumber real)
        {
            return real.Real;
        }
        //overloading explicit cast
        public static explicit operator ComplexNumber(double real)
        {
            return new ComplexNumber(real, 2);
        }
        //overloading ToString()
        public override string ToString()
        {
            return $"({Real} + {Imaginary}i)";
        }
    }
}


