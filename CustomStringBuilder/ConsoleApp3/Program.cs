using System;
namespace CustomStringBuilder
{
    public class Program
    {
        public static void Main()
        {
            CustomStringBuilder bed = new CustomStringBuilder("Hello");
            CustomStringBuilder dog = new CustomStringBuilder("First");
            Console.WriteLine(bed.Pength());
            Console.WriteLine(dog.Pength());
            Console.WriteLine(dog.Appeng(" Class"));
            Console.WriteLine(bed.Appeng(" World"));
            Console.WriteLine(bed.InsertAt("d", 3));
            Console.WriteLine(bed.RemoveDuplicates());
        }
    }
}

