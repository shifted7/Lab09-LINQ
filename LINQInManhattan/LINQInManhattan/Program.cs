using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LINQInManhattan.Classes;

namespace LINQInManhattan
{

    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"../../../data.json";
            JObject dataJObj = ReadFileIntoJObject(filepath);
            //Console.WriteLine(dataJObj);
            DataObject dataObject = new DataObject();
            dataObject = dataJObj.ToObject<DataObject>();
            QueryAllEntries(dataObject);
            QueryAllValidEntries(dataObject);
            QueryAllDistinctValidEntries(dataObject);
            QueryAllNeighborhoods(dataObject);
            QueryAllNeighborhoodsWithStatements(dataObject);
        }

        public static JObject ReadFileIntoJObject(string filepath)
        {
            return JObject.Parse(File.ReadAllText(@"../../../data.json"));
            //using (StreamReader sr = File.OpenText(@"../../../data.json"))
            //{
            //    return (JObject)JToken.ReadFrom(new JsonTextReader(sr));
            //}
        }
        public static void QueryAllEntries(DataObject dataObject)
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("All Data Entries:");
            int count = 0;
            foreach (Feature feature in dataObject.Features)
            {
                count++;
                Console.WriteLine($"{count}: {feature.Properties.Neighborhood}");
            }
        }
        public static void QueryAllValidEntries(DataObject dataObject)
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("All Non-Blank Data Entries:");
            int count = 0;
            foreach (Feature feature in dataObject.Features)
            {
                if(feature.Properties.Neighborhood != "")
                {
                    count++;
                    Console.WriteLine($"{count}: {feature.Properties.Neighborhood}");
                }
            }
        }
        public static void QueryAllDistinctValidEntries(DataObject dataObject)
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("All Non-Blank, Distinct Data Entries:");
            var allNeighborhoodEntries = dataObject.Features.Select(feature => feature.Properties.Neighborhood);
            var allValidNeighborhoodEntries = allNeighborhoodEntries.Where(neighborhood => neighborhood != "");
            var allValidDistinctNeighborhoodEntries = allValidNeighborhoodEntries.Distinct();
            int count = 0;
            foreach (string neighborhood in allValidDistinctNeighborhoodEntries)
            {
                count++;
                Console.WriteLine($"{count}: {neighborhood}");
            }
        }
        public static void QueryAllNeighborhoods(DataObject dataObject)
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("All Non-Blank, Distinct Data Entries:");
            var allNeighborhoods = dataObject.Features
                .Select(feature => feature.Properties.Neighborhood)
                .Where(neighborhood => neighborhood != "")
                .Distinct();
            int count = 0;
            foreach (string neighborhood in allNeighborhoods)
            {
                count++;
                Console.WriteLine($"{count}: {neighborhood}");
            }
        }
        public static void QueryAllNeighborhoodsWithStatements(DataObject dataObject)
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("All Non-Blank, Distinct Data Entries:");
            var allNeighborhoods = (from entry in dataObject.Features
                                   where entry.Properties.Neighborhood != ""
                                   select entry.Properties.Neighborhood)
                                   .Distinct(); // No query statement equivalent to distinct, afaik
            int count = 0;
            foreach (string neighborhood in allNeighborhoods)
            {
                count++;
                Console.WriteLine($"{count}: {neighborhood}");
            }
        }
    }
}
