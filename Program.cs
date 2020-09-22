using System;

namespace Converter
{
    class Program
    {
        public static double converter(Int32 received, double coefficient)
        {
            return received * coefficient;
        }
        public const double METERS_PER_SECOND_TO_KILOMETERS_PER_HOUR =3.6;
        static void Main(string[] args)
        {
                Console.WriteLine("METERS_PER_SECOND");
                 int temp= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((converter(temp,METERS_PER_SECOND_TO_KILOMETERS_PER_HOUR))+" KILOMETERS_PER_HOUR");
            
        }
    }
}
