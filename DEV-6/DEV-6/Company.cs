using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace DEV_6
{
    class Company
    {
        private static Company uniqueInstance;
        public List<Car> cars;
        public List<string> allBrands;
        private string nameOfXml = string.Empty;
        public static Company getInstance(string nameOfXml)
        {
            if(uniqueInstance==null)
            {
              uniqueInstance = new Company(nameOfXml);
            }
            return uniqueInstance;
        }
        private Company(string nameOfXml)
        {
            cars = new List<Car>();
            allBrands = new List<string>();
            this.nameOfXml = nameOfXml;    
            
            AddCarsToList();
            AddBrandsToList();
        }
       
    }
}
