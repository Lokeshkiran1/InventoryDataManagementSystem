using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath= "C:\\Users\\HP\\Desktop\\csharp\\InventoryDataManagement\\jsconfig1.json";
            FetchForJsonRiceData fetch = new FetchForJsonRiceData();
            Rice data = fetch.Read(filePath);
            /* Console.WriteLine(data.typeOfRice.name);
             Console.WriteLine(data.typeOfRice.weight);
             Console.WriteLine(data.typeOfRice.price);*/
            Console.WriteLine("types of rice data");
           for(int i=0;i<data.typeOfRice.Count;i++)
            {
                Console.WriteLine(data.typeOfRice[i].name);
                Console.WriteLine(data.typeOfRice[i].weight);
                Console.WriteLine(data.typeOfRice[i].price);

                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("types of pulse data");
            for (int i = 0; i < data.typeOfPulse.Count; i++)
            {
                Console.WriteLine(data.typeOfPulse[i].name);
                Console.WriteLine(data.typeOfPulse[i].weight);
                Console.WriteLine(data.typeOfPulse[i].price);

                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("types of wheat data");
            for (int i = 0; i < data.typeOfWheat.Count; i++)
            {
                Console.WriteLine(data.typeOfWheat[i].name);
                Console.WriteLine(data.typeOfWheat[i].weight);
                Console.WriteLine(data.typeOfWheat[i].price);

                Console.WriteLine("-----------------------");
            }

            Console.ReadLine();
        }
    }
}
