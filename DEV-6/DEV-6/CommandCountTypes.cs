using System.Xml;
using System;
namespace DEV_6
{
    class CommandCountTypes: Command
    {
        public CommandCountTypes(string nameOfXml):base(nameOfXml)
        {

        }
        public override void Execute()
        {
            int Count = 0;
            foreach (XmlNode xnode in xmlElement)
            {
                if (xnode.Attributes.Count > 0)
                {
                    Count++;
                }
            }
             Console.WriteLine($"Count of types:{Count}");
        }
    }
}
