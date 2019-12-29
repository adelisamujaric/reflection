using System;
using System.Reflection;
using System.IO;
using MyLibrary;

namespace reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            Assembly assem = null;

            try
            {
                assem = Assembly.Load("MyLibrary");
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }

            if (assem == null)
                return;

            Type countryType = assem.GetType("MyLibrary.Country");
            object obj = Activator.CreateInstance(countryType, new object[] { "China", 9992111 });

            MethodInfo mi = countryType.GetMethod("GetCountryInfo");
            mi.Invoke(obj, new object[] { });
            object returnValue = mi.Invoke(obj, new object[] { });
            Console.WriteLine(returnValue);


            //Second part of the task
            Type type = typeof(String);

            if (type != null)
            {
                Console.WriteLine("The class name is {0}.", type.Name);
                Console.WriteLine("The full class name is {0}.", type.FullName);
                Console.WriteLine("Class namescape is {0}.", type.Namespace);
                Console.WriteLine("Class assembly is {0}.", type.Assembly);
                Console.WriteLine("Base class is: {0}", type.BaseType);
                Console.WriteLine("Abstract: {0}", type.IsAbstract);
                Console.WriteLine("Sealed: {0}", type.IsSealed);
                Console.WriteLine("Generic: {0}", type.IsGenericTypeDefinition);
                Console.WriteLine("Class: {0}", type.IsClass);
            }
        }
    }
}
