using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day04
{
    enum Power
    {
        Flight, Speed, Strength, Money, Telepathy, Swimming
    }
    class Superhero
    {
        public string Name { get; set; }
        public string SecretIdentity { get; set; }
        public Power Superpower { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\temp\2212";
            string fileName = "sample.txt";
            string fullPath = Path.Combine(filePath, fileName);

            char delimiter = '#';
            #region Write CSV
            //1) Open the file. will create/overwrite
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                //2) write to the file
                sw.Write("Batman rules! Aquaman does not.");
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(13.7);
                sw.Write(delimiter);
                sw.Write(true);
            }//3) CLOSE THE FILE! 
            #endregion

            #region Read CSV

            if (File.Exists(fullPath))
            {
                string fileText = File.ReadAllText(fullPath);//open, read, close
                Console.WriteLine(fileText);
                string[] data = fileText.Split(delimiter);

                foreach(string dataItem in data)
                    Console.WriteLine(dataItem);
            }

            #endregion

            List<Superhero> JLA = new List<Superhero>();
            JLA.Add(new Superhero() { Name = "Batman", Superpower = Power.Money, SecretIdentity = "Bruce Wayne" });
            JLA.Add(new Superhero() { Name = "Superman", Superpower = Power.Flight, SecretIdentity = "Clark Kent" });
            JLA.Add(new Superhero() { Name = "Wonder Woman", Superpower = Power.Strength, SecretIdentity = "Diana Prince" });
            JLA.Add(new Superhero() { Name = "Green Lantern", Superpower = Power.Telepathy, SecretIdentity = "Hal Jordan" });
            JLA.Add(new Superhero() { Name = "Aquaman", Superpower = Power.Swimming, SecretIdentity = "Arthur Curry" });

            // Serializing
            //change the extension to .json
            fileName = Path.ChangeExtension(fileName, "json");
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    jtw.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jtw, JLA);
                }
            }



            Course pg2 = new Course() { Name = "PG2 - 2212" };

            string[] menu = new string[]
            {"0. Exit", "1. Part 1 - Saving CSV", "2. Part 2 - Reading CSV", "3. Part 3 - Serializing JSON", "4. Part 4 - Deserializing JSON","5. Part 5 - Recursive Loop"};

            int part = 1;
            while (true)
            {
                Console.Clear();

                #region Show Menu
                Console.WriteLine("What part to run?");
                foreach (var option in menu)
                    Console.WriteLine(option);
                Console.Write("Choice? ");
                string input = Console.ReadLine();
                #endregion

                if (int.TryParse(input, out part) && part > 0 && part < 6)
                {
                    switch (part)
                    {
                        case 1:
                            //Add a method SaveGrades to the Course class
                            //  save the dictionary to a csv file
                            //call SaveGrades here
                            pg2.SaveGrades();
                            break;
                        case 2:
                            //Add a method LoadGrades to the Course class
                            //  clear the _grades dictionary
                            //  load the dictionary data from the csv file
                            //call LoadGrades here
                            pg2.LoadGrades();
                            pg2.PrintGrades();
                            break;
                        case 3:
                            //Add a SerializeGrades method to the Course class
                            //  serialize the dictionary to a json file
                            //call SerializeGrades here 
                            break;
                        case 4:
                            //Add a DeserializeGrades method to the Course class
                            //  clear the _grades dictionary
                            //  deserialize the json file to the dictionary
                            //call DeserializeGrades here 
                            break;
                        case 5:
                            //Add a static Bats method to this file
                            //  convert this for loop to a recursive loop using the Bats method
                            /*
                                for(int i = 0;i < 100;i++)
                                {
                                    Console.Write((char)78);
                                    Console.Write((char)65);
                                    Console.Write(' ');
                                }
                             */
                            //call Bats here 
                            break;
                        default:
                            break;
                    }
                }
                else
                    break;
                Console.ReadKey();
            }
        }
    }
}
