namespace DEV_3
{
    /// <summary>
    /// Entry point of program.
    /// optimize staff using one of the 3 criteria
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry point to the program
        /// </summary>
        static void Main()
        {
            try
            {
                string Choice = string.Empty;
                TeamBuild obj;
                Company company = new Company();
                Console.WriteLine("Choose ur criteria: 1st,2nd,3rd");
                Choice = Console.ReadLine();
                switch(Choice)
                {
                    case "1st":
                        obj = new TeamBuild1stCriterion();
                        break;
                    case "2nd":
                        obj = new TeamBuild2ndCriterion();
                        break;
                    case "3rd":
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
