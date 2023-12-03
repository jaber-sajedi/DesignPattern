using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTon
{
    public class Shape
    {
        private static volatile ConcurrentDictionary<string, Shape> instances = new ConcurrentDictionary<string, Shape>();
        private static readonly object lockObject = new object();

        private string key;
        private string color;
        private string pattern;

        private Shape(string key, string color, string pattern)
        {
            this.key = key;
            this.color = color;
            this.pattern = pattern;
        }

        public static Shape GetInstance(string key, string color, string pattern)
        {
            if (!instances.ContainsKey(key))
            {
                lock (lockObject)
                {
                    if (!instances.ContainsKey(key))
                    {
                       instances[key] = new Shape(key, color, pattern);
                       // instances.GetOrAdd(key, new Shape(key,color, pattern));
                    }
                }
            }
            return instances[key];
        }

        public string Draw()
        {
            return ($"Drawing shape with key: {key}, color: {color}, and pattern: {pattern}");
        }
    }
}
