using System;
namespace DEV_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                int Choice = 0;
                TeamBuild obj;
                Company company = new Company();
                Console.WriteLine("Choose ur criteria: 1st,2nd,3rd");
                Choice= Int32.Parse(Console.ReadLine());
                switch(Choice)
                {
                    case (1):
                        obj = new TeamBuild1stCriterion();
                        break;
                    case (2):
                        obj = new TeamBuild2ndCriterion();
                        break;
                    case (3):
                        obj = new TeamBuild3rdCriterion();
                        break;
                    default:
                        throw new FormatException();
                }                                      
                company.GetUrTeam(obj);
            }
            catch(FormatException)
            {
                Console.WriteLine("Incorrect selection of criteria");
            }
            catch(Exception)
            {
                Console.WriteLine("ERROR!");
            }              
        }
    }
}
