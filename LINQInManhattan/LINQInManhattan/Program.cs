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
            //      {
            //      "type": "Feature",
            //      "geometry": {
            //          "type": "Point",
            //          "coordinates": [
            //              -73.999747,
            //              40.742662
            //          ]
            //      },
            //      "properties": {
            //          "zip": "10011",
            //          "city": "New York",
            //          "state": "NY",
            //          "address": "",
            //          "borough": "Manhattan",
            //          "neighborhood": "Chelsea",
            //          "county": "New York County"
            //      }
            //      },

            JObject dataObj = JObject.Parse(File.ReadAllText(@"../../../data.json"));
            // JArray dataArray = (JArray)dataObj["Features"];
            Console.WriteLine(dataObj);
            // string dataString = dataObj.features;


            // List<Entry> neighborhoods = JsonConvert.DeserializeObject<Entry>(dataObj["features"]);

            //var queryData = from neighborhood in neighborhoods
            //                select (string)neighborhood[];
        }
    }
}
