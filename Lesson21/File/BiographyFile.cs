using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Lesson21
{
    [InfoMetadata(PathToSerializedFile = @"E:\", SerializedFileName = "biography.txt")]
    public class BiographyFile : IInfoReadable
    {
        const string pathToFile = @"E:\biography.txt";
        public Biography Biography { get; set; }

        public void CompressOrDecompressBio(Biography bio, Mode mode)
        {
            switch (mode)
            {
                case Mode.Serialize:
                    {
                        SerializeObject(bio);
                        break;
                    }
                case Mode.Deserialize:
                    {
                        Biography = DeserializeObject();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error\n");
                        break;
                    }
            }
        }

        private void SerializeObject(Biography bio)
        {
            using (StreamWriter sw = new StreamWriter(pathToFile, false))
            {
                string jsonBiography = JsonSerializer.Serialize<Biography>(bio);

                sw.Write(jsonBiography);
                Console.WriteLine($"The object serialized to file {pathToFile}.\n");
            }
        }

        private Biography DeserializeObject()
        {
            Biography bio = null;

            using (StreamReader sr = new StreamReader(pathToFile))
            {
                string jsonBiography = sr.ReadToEnd();
                bio = JsonSerializer.Deserialize<Biography>(jsonBiography);
                Console.WriteLine($"The object deserialized from the file {pathToFile}.\n");
            }

            return bio;
        }

        public void GetBiography(Biography bio)
        {
            string biography = bio == null ? "Error. Bio is null" : $"{bio.ToString()}";

            Console.WriteLine(biography);
        }
    }
}
