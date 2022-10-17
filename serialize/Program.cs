using System;
using static System.Console;
using System.Xml.Serialization;

namespace program
{
    class program{
        static void Main(string[] args){
            List<Pasteles> pasteles = new()
            {
                new ()
                {
                    name = "Tarta",
                    sugar = "2 kg",
                    milk = "2 cups",
                    children = new()
                    {
                        new()
                        {
                            name = "Tarta de manzana",
                            sugar = "3 kg",
                            milk = "3 cups"
                        }
                    }
                },
                new ()
                {
                    name = "Flume",
                    sugar = "4 kg",
                    milk = "4 cups"
                }
            };

            XmlSerializer serializer = new(pasteles.GetType());
            FileStream file = File.Create("pasteles.xml");

            serializer.Serialize(file, pasteles);


            file.Close();
            file.Dispose();
        }
    }
}
