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
                TeamBuilder team;
                Company company = new Company();
                Console.WriteLine("Choose ur criteria: 1st,2nd,3rd");
                Choice = Console.ReadLine();
                switch(Choice)
                {
                    case "1st":
                        team = new TeamBuildFirstCriterion();
                        team.Colculate();
                        break;
                    case "2nd":
                        team = new TeamBuilderSecondCriterion();
                        team.Colculate();
                        break;
                    case "3rd":
                        team = new TeamBuildThirdCriterion();
                        team.Colculate();
                        break;
                    default:
                        throw new FormatException();
                }                                      
                company.PrintUrTeam(team);
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
