using System;
using System.Xml;

namespace DEV_6
{
    class CommandAveragePrice : Command
    {
        public CommandAveragePrice(string nameOfXml) : base(nameOfXml)
        {
        }
        public override void Execute()
        {
            int AllPrice = 0;
            int Count = 0;
            foreach (XmlNode xnode in xmlElement)
            {               
                foreach (XmlNode childnode in xnode)
                {
                    Count++;
                    foreach (XmlNode node in childnode )
                    {
                        if (node.Name == "Price")
                        {
                            AllPrice += Int32.Parse(node.InnerText);
                        }
                    }                 
                }
            }
            Console.WriteLine($"Average price : {AllPrice/Count}");
        }
    }
}
