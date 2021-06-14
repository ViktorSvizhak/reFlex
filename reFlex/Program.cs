using System;
using System.Linq;
using System.Reflection;

namespace reFlex
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.GetCustomAttribute<RuleAttribute>(true) != null)
                .ToList();

            foreach (var ass in list)
            {
                Console.WriteLine(ass.Name);
            }
        }
    }
}
