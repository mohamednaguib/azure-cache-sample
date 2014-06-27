
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationServer.Caching;

namespace AzureCacheSample
{
    public class Program
    {
        public static DataCache cache = new DataCache("default");
        static void Main(string[] args)
        {

            SaveToCache("AzureCacheSample", "AzureCacheSampleValue");
            string temp = GetFromCache("AzureCacheSample").ToString();
        }
        public static void SaveToCache(string key,string value)
        {
            cache.Put(key, value);
        }
        public static object GetFromCache(string key)
        {
            return cache.Get(key);
        }
    }
}

