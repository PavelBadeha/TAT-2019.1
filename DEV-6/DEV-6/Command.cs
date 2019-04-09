using System.Xml;
using System.Collections.Generic;

namespace DEV_6
{
   abstract class Command: ICommand
    {
        public abstract void Execute();
        public string nameOfXml { get; protected set; }
        protected XmlDocument xmlDocument;
        protected XmlElement xmlElement;
        protected List<string> allMarks= new List<string>();
        public Command(string nameOfXml)
        {
            this.nameOfXml = nameOfXml;
            xmlDocument = new XmlDocument();
            xmlDocument.Load(nameOfXml);
            xmlElement = xmlDocument.DocumentElement;
            AddMarksToList();          
        }
        public void AddMarksToList()
        {
            foreach (XmlElement xnode in xmlElement)
            {
               allMarks.Add(xnode.Attributes.GetNamedItem("Mark")?.Value);                
            }
        }
    }
}
