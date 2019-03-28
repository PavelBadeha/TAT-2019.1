using System;

namespace DEV_3
{
    /// <summary>
    /// Class of first criterion
    ///first criterion is maximum productivity within the sum
    /// </summary>
    class TeamBuild1stCriterion :TeamBuild
    {
        /// <summary>
        /// the constructor of class
        /// </summary>
        public TeamBuild1stCriterion()
        {        
            Console.WriteLine("Input amount");
            Amount = Int32.Parse(Console.ReadLine());
            Price = Amount;
            if (Amount <= junior.Cost)
            {
                Console.WriteLine("Not enough money");
            }
            Colculate();        
        }
        public override void Colculate()
        {
            int i = 0;
            while (Amount>=lead.Cost)
            {
                i++;
                urTeam.Add(new Lead());
                Amount -= lead.Cost;
                TotalProductivity += lead.Productivity;
                urTeamLeads++;
                if(i==leadCounter)
                {
                    i = 0;
                    break;              
                }
            }
            while (Amount >= senior.Cost)
            {             
                i++;
                urTeam.Add(new Senior());
                Amount -= senior.Cost;
                TotalProductivity += senior.Productivity;
                urTeamSeniors++;              
                if (i == seniorCounter)
                {
                    i = 0;
                    break;
                }
            }
            while (Amount >= middle.Cost)
            {            
                i++;               
                urTeam.Add(new Middle());
                urTeamMiddles++;
                Amount -= middle.Cost;
                TotalProductivity += middle.Productivity;
                if (i == middleCounter)
                {
                    i = 0;
                    break;
                }
            }
            while (Amount >= junior.Cost)
            {           
                i++;
                urTeam.Add(new Junior());
                urTeamJuniors++;
                Amount -= junior.Cost;
                TotalProductivity += junior.Productivity;
                if (i == juniorCounter)
                {
                    i = 0;
                    break;
                }
            }
            Price -= Amount;
        }
    }
}
