using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using CharpZavertailo2.Tools.Managers;

namespace CharpZavertailo2
{
    
        internal static class Helper
        {
            public static List<Person> Users { get; }
            public static string[] personNames =
            {
                "Mariia",
                "Pavlo",
                "Oleg",
                "Yuriy",
                "Kateryna",
                "Olga",
                "Mariia",
                "Pavlo",
                "Oleg",
                "Yuriy",
                "Kateryna",
                "Olga",
                "Mariia",
                "Pavlo",
                "Oleg",
                "Yuriy",
                "Kateryna",
                "Olga",
                "Mariia",
                "Pavlo",
                "Oleg",
                "Yuriy",
                "Kateryna",
                "Olga",
                "Mariia",
                "Pavlo",
                "Oleg",
                "Yuriy",
                "Kateryna",
                "Olga",
                "Mariia",
                "Pavlo",
                "Oleg",
                "Yuriy",
                "Kateryna",
                "Olga",
                "Mariia",
                "Pavlo",
                "Oleg",
                "Yuriy",
                "Kateryna",
                "Olga",
                "Mariia",
                "Pavlo",
                "Oleg",
                "Yuriy",
                "Kateryna",
                "Olga",
                "Mariia",
                "Pavlo",
                "Oleg",
                "Yuriy",
                "Kateryna",
                "Olga",
                "Mariia",
                "Pavlo",
                "Oleg",
                "Yuriy",
                "Kateryna",
                "Olga"

            };

            public static string[] personSurnames =
            {
                "Zavertailo",
                "Gryshko",
                "Doroshenko",
                "Lutsenko",
                "Vasylenko",
                "Zavertailo",
                "Gryshko",
                "Doroshenko",
                "Lutsenko",
                "Vasylenko",
                "Zavertailo",
                "Gryshko",
                "Doroshenko",
                "Lutsenko",
                "Vasylenko",
                "Zavertailo",
                "Gryshko",
                "Doroshenko",
                "Lutsenko",
                "Vasylenko",
                "Zavertailo",
                "Gryshko",
                "Doroshenko",
                "Lutsenko",
                "Vasylenko",
                "Zavertailo",
                "Gryshko",
                "Doroshenko",
                "Lutsenko",
                "Vasylenko",
                "Zavertailo",
                "Gryshko",
                "Doroshenko",
                "Lutsenko",
                "Vasylenko",
                "Zavertailo",
                "Gryshko",
                "Doroshenko",
                "Lutsenko",
                "Vasylenko",
                "Zavertailo",
                "Gryshko",
                "Doroshenko",
                "Lutsenko",
                "Vasylenko",
                "Zavertailo",
                "Gryshko",
                "Doroshenko",
                "Lutsenko",
                "Vasylenko"
            };
            static Helper()
            {
                var filepath = Path.Combine(GetAndCreateDataPath(), Person.filename);
                if (File.Exists(filepath))
                {
                    try
                    {
                        Users = SerializeHelper.Deserialize<List<Person>>(filepath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error. Can't get persons from file.{Environment.NewLine}{ex.Message}");
                        throw;
                    }
                }
                else
                {
                    Users = new List<Person>();
                    Random rnd = new Random();
                    for (int i = 0; i < 50; ++i)
                        Users.Add(new Person(personNames[i], personSurnames[i], $"user{i}@gmail.com",
                            new DateTime(rnd.Next(DateTime.Today.Year - 90, DateTime.Today.Year - 10), rnd.Next(1, 13),
                                rnd.Next(1, 25))));
                }
            }

            internal static Person CreateUser(string firstName, string lastName, string email, DateTime date)
            {
                Person newPerson = new Person(firstName, lastName, email, date);
                Users.Add(newPerson);
                return newPerson;
            } 

            private static string GetAndCreateDataPath()
            {
                string dir = StationManager.WorkingDirectory;
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                return dir;
            }

        }
    
}
