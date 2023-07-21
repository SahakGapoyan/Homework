using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringBuilder
{
    public class CustomStringBuilder
    {
        private char[] charArray;
        private int length = 0;
        public CustomStringBuilder(string value)
        {
            int charCount = 0;
            foreach (char c in value)
            {
                charCount++;
            }
            charArray = new char[charCount];
            int index = 0;
            foreach (char c in value)
            {
                charArray[index++] = c;
            }
        }

        public int Pength()
        {
            foreach (char c in charArray)
            {
                length++;
            }
            return length;
        }

        public char[] Appeng(string val)
        {
            int charCount = 0;
            foreach (char c in val)
            {
                charCount++;
            }
            char[] array = new char[this.Pength() + charCount];
            int index = 0;
            foreach (char c in charArray)
            {
                array[index++] = c;
            }
            foreach (char c in val)
            {
                array[index++] = c;
            }
            return array;
        }

        public char[] InsertAt(string val, int index)
        {
            if (index < 0 || index > this.Pength())
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            int k = 0;
            char[] chunk;
            int charCount = 0;
            foreach (char c in val)
            {
                charCount++;
            }
            chunk = new char[charCount];
            foreach (char c in val)
            {
                chunk[k++] = c;
            }
            char[] array = new char[this.Pength() + charCount + 1000];
            for (int i = 0; i < index; i++)
            {
                array[i] = charArray[i];
            }
            for (int i = index, j = 0; j < charCount; i++, j++)
            {
                array[i] = chunk[j];
            }
            for (int i = index + charCount, p = index; p < this.Pength(); i++, p++)
            {
                array[i] = charArray[p]; 
            }
            return array;
        }

        public char[] RemoveDuplicates()
        {
            int i, j, k = 0;
            char[] array = new char[this.Pength()];
            for (i = 0; i < this.Pength() - 1; i++)
            {
                bool found = false;
                for (j = i + 1; j < this.Pength(); j++)
                {
                    if (charArray[i] == charArray[j])
                    {
                        found = true;
                        array[k++] = charArray[i];
                        break;
                    }
                }
                if (found == false)
                {
                    array[k++] = charArray[i];
                }
            }
            return array;
        }
    }
}
