using System;
using System.Collections.Generic;
using System.Xml;

namespace DEV_6
{
    class Company
    {
        public List<Car> cars;
        private XmlDocument xmlDocument;
        private XmlElement xmlElement;
        public List<string> allMarks;
        private string nameOfXml = string.Empty;
        public Company(string nameOfXml)
        {
            cars = new List<Car>();
            allMarks = new List<string>();
            this.nameOfXml = nameOfXml;
            xmlDocument = new XmlDocument();
            xmlDocument.Load(nameOfXml);
            xmlElement = xmlDocument.DocumentElement;
            AddCarsToList();
            AddMarksToList();
        }
        public void AddMarksToList()
        {
            foreach (XmlElement xnode in xmlElement)
            {
                if(!allMarks.Contains(xnode.Attributes.GetNamedItem("Mark")?.Value))
                {
                    allMarks.Add(xnode.Attributes.GetNamedItem("Mark")?.Value);
                }            
            }
        }
        public void AddCarsToList()
        {         
            foreach (XmlElement xnode in xmlElement)
            {
                Car car = new Car();               
                foreach (XmlNode childnode in xnode)
                {                             
                    foreach (XmlNode node in childnode)
                    {
                        car.Mark = xnode.Attributes.GetNamedItem("Mark")?.Value;
                        car.Model = childnode.Attributes.GetNamedItem("Model")?.Value;
                        if (node.Name=="Price")
                        {
                            car.Price = Int32.Parse(node?.InnerText);
                        }
                        else
                        {
                            car.Quantity = Int32.Parse(node?.InnerText);
                        }                     
                    }
                }
                cars.Add(car);
            }
        }
    }
}
