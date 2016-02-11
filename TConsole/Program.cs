using QA.TestLibs;
using QA.TestLibs.XmlDesiarilization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TConsole
{

    public class Test
    {
        [XmlProperty("test")]
        public virtual int A { get; set; }
    }
    public class Test1 : Test
    {
        //[XmlProperty("test1")]
        public override int A { get; set; }
    }
    class Program
    {
        public static XElement Config = XDocument.Load("TestData.xml").Element("test").Element("complex");
        public static void GetAttribute()
        {
            Attribute[] attrs = Attribute.GetCustomAttributes(typeof(Test).GetProperty("A"));
            Attribute[] attrs1 = Attribute.GetCustomAttributes(typeof(Test1).GetProperty("A"));
            // Get instance of the attribute.
            Test test = new Test();
            //XmlProperty MyAttribute = (XmlProperty)Attribute.GetCustomAttribute(test.A.GetType(), typeof(XmlProperty));
        }
        static void Main(string[] args)
        {
            ReflectionManager.LoadAssemblies(System.IO.Directory.GetCurrentDirectory());
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            GetAttribute();
            //XmlProperty MyAttribute =            (XmlProperty)Attribute.GetCustomAttribute(, typeof(XmlProperty));

            //XElement elem = Config.Element("myComplex");
            //var obj = XmlParser.Parse<MyComplex>(elem);

            var config1 = Config.Element("complexClass3_2");
            var obj1 = XmlParser.Parse<DataSamples.ComplexClass3>(config1);

            Console.Read();
        }
    }
}
