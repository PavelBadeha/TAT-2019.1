using System;
using System.Xml;

namespace DEV_6
{
    class CommandAveragePriceType: Command
    {
        private string Type = string.Empty;
        public CommandAveragePriceType(string nameOfXml,string Type) : base(nameOfXml)
        {
            this.Type = Type;
            checkForValid();
        }
        public void checkForValid()
        {
            if(!allMarks.Contains(Type))
            {
                Console.WriteLine("!!!!Not correct Mark!!!!\nMarks that we have");
                foreach(var type in allMarks)
                {
                    Console.WriteLine(type);
                }
                Console.WriteLine("Input new Mark");
                Type = Console.ReadLine();
                checkForValid();
            }
        }
        public override void Execute()
        {
            int AllPrice = 0;
            int Count = 0;
            foreach (XmlNode xnode in xmlElement)
            {                      
                if (xnode.Attributes.GetNamedItem("Mark").Value==Type)
                {                   
                    foreach (XmlNode childnode in xnode)
                    {
                        Count++;
                        foreach (XmlNode node in childnode)
                        {
                            if (node.Name == "Price")
                            {
                                AllPrice += Int32.Parse(node.InnerText);
                            }
                        }
                    }
                }              
            }
            Console.WriteLine($"Average price : {AllPrice / Count}");
        }
    }
}
