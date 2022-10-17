using System;
using static System.Console;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace program
{
    class program{        
        public static void child(Pasteles item, int count)
        {   
            if(count != 0){
                for(int i = 0; i <= count; i++){
                    Write("\t");
                }
            }
            WriteLine("{0} has {1} children, it uses {2} of sugar and {3} of milk", item.name, item.children?.Count ?? 0, item.sugar, item.milk);
            if(item.children is not null)
            {
                List<Pasteles> itemNuevo = item.children.ToList();
                foreach (Pasteles itemTemp in itemNuevo)
                {
                    if(itemTemp.children is not null)
                    {
                        child(itemTemp, count + 1);
                    }else
                    {
                        child(itemTemp, count);
                    }
                }
            }
        }
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
                        },
                        new()
                        {
                            name = "Tarta de frambuesa",
                            sugar = "1 kg",
                            milk = "1 cup",
                            children = new()
                            {
                                new()
                                {
                                    name = "Frambuesas"
                                }
                            }
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
            FileStream fileCreate = File.Create("pasteles.xml");

            serializer.Serialize(fileCreate, pasteles);

            fileCreate.Close();
            fileCreate.Dispose();

            FileStream fileOpen = File.Open("pasteles.xml", FileMode.Open);

            List<Pasteles>? responseXml = serializer.Deserialize(fileOpen) as List<Pasteles>;
            
            if(responseXml is not null){
                foreach (Pasteles item in responseXml)
                {
                    child(item, 0);
                }
            }
            
            fileOpen.Close();
            fileOpen.Dispose();
        }
    }
}
