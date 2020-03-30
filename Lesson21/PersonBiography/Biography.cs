using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lesson21
{
    public class Biography
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string PhoneNUmber { get; set; }

        [JsonIgnore]
        public string Profession { get; set; }

        public Biography() : this(null, null, default, null, null) { }

        public Biography(string firstName, string surname, int age, string phoneNumber, string profession)
        {
            FirstName = firstName;
            Surname = surname;
            Age = age;
            PhoneNUmber = phoneNumber;
            Profession = profession;
        }

        public override string ToString()
        {
            return
                $"Firstname - {FirstName},\n" +
                $"Surname - {Surname},\n" +
                $"Age - {Age},\n" +
                $"Phone number -{PhoneNUmber},\n" +
                $"Profession - {Profession}.\n";
        }
    }
}
