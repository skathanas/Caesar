using System;

namespace caesar
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string UserString = null;
            int shift;
            Shift OBSHIFT = new Shift();

            Console.WriteLine("Tere tulemas Caesar krüpti");

            Console.WriteLine("Kirtjuta tekst krüpteerimiseks:");

            UserString = Console.ReadLine();

            Console.WriteLine("Kui pikalt soovid krüpteerida?");
            shift = int.Parse(Console.ReadLine());

            Console.WriteLine("su krüpteeritud sõnum on: ");
            Console.WriteLine(OBSHIFT.Cshift(UserString, shift));
        }
    }
}

class Shift
{
    public string Cshift(string str, int shift)

    {
        string UserOutput = null;
        char[] A = null;
        A = str.ToCharArray();
        int temp;

        for (int i = 0; i < str.Length; i++)
        {
            temp = (int)(A[i] + shift);
            UserOutput += (char)temp;
        }

        return UserOutput;
    }
}