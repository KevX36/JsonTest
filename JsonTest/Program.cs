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
            //StatData data = new StatData();
            //data.jobClass = "Chef";
            //data.name = "mar";
            //data.Level = 1;
            string jsonString = JsonSerializer.Serialize<StatData>(data);
            File.WriteAllText("statdata.json", jsonString);

            string jsonRead = File.ReadAllText("statdata.json");
            Console.WriteLine(jsonRead);
            Console.WriteLine("");
            StatData data2 = JsonSerializer.Deserialize<StatData>(jsonRead);
            Console.WriteLine(data2.name);
            Console.WriteLine(data2.level);
            Console.WriteLine(data2.jobClass);
            Console.WriteLine("");

            Console.ReadKey();

        }
        
    }
    public class StatData
    {
        public StatData(string name, string jobClass, int level)
        {
            this.name = name;
            this.jobClass = jobClass;
            this.level = level;
        }
        public string name { get; set; }
        public string jobClass { get; set; }
        public int level { get; set; }
    }
}
