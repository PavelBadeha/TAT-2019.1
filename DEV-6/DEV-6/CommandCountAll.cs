using System;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class CommandCountAll: Command
    {
        public CommandCountAll(string nameOfXml) : base(nameOfXml)
        {

        }
        public override void Execute()
        {
            int QuantityOfAll = 0;
            foreach (XmlNode xnode in xmlElement)
            {              
                foreach (XmlNode childnode in xnode)
                {
                    foreach(XmlNode attribute in childnode)
                    {
                        if (attribute.Name == "Quantity")
                        {
                            QuantityOfAll += Int32.Parse(attribute.InnerText);
                        }
                    }                                   
                }
            }
            Console.WriteLine($"QuantityOfAll: {QuantityOfAll}");
        }
    }
}
