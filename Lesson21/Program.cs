using System;

namespace Lesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            Biography personBio = new Biography("Ivan", "Ivanov", 109787670, " +3752901234567", "DJ");
            BiographyFile bioFile = new BiographyFile();

            Console.WriteLine(personBio.ToString());

            bioFile.CompressOrDecompressBio(personBio, Mode.Serialize);
        }
    }
}
