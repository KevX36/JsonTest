using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace JsonTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StatData data = new StatData("mar","Chef", 1);
            string jsonString = JsonSerializer.Serialize<StatData>(data);
            File.WriteAllText("statdata.json", jsonString);

            string jsonRead = File.ReadAllText("statdata.json");

            Console.WriteLine(jsonRead);
            Console.ReadKey();

        }
        
    }
    public class StatData
    {
        public StatData(string Name,string job, int lv)
        {
            name = Name;
            jobClass = job;
            Level = lv;
        }
        public string name { get; set; }
        public string jobClass { get; set; }
        public int Level { get; set; }
    }
}
