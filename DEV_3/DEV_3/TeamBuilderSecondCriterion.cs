using System;

namespace DEV_3
{
    /// <summary>
    /// Class of second criterion
    ///Second criterion is minimum cost with fixed productivity
    /// </summary>
    class TeamBuilderSecondCriterion :TeamBuilder
    {
      /// <summary>
      /// the constructor of class
      /// </summary>
        public TeamBuilderSecondCriterion()
        {
            Console.WriteLine("Input productivity");
            NeedProductivity= Int32.Parse(Console.ReadLine());
            TotalProductivity = NeedProductivity;
            if (NeedProductivity <= junior.Productivity)
            {
                Console.WriteLine("Not correct input!");
            }       
        }
        
        public override void Colculate()
        {
            int i = 0;
            
            while (NeedProductivity>= lead.Productivity)
            {
                i++;
                urTeam.Add(new Lead());
                NeedProductivity -= lead.Productivity;
                urTeamLeads++;
                Price += lead.Cost;
                if (i == leadCounter)
                {
                    i = 0;
                    break;
                }
            }
            
            while (NeedProductivity >= senior.Productivity)
            {
                i++;
                urTeam.Add(new Senior());
                urTeamSeniors++;
                NeedProductivity -= senior.Productivity;
                Price += senior.Cost;   
                
                if (i == seniorCounter)
                {
                    i = 0;
                    break;
                }
            }
            
            while (NeedProductivity >= middle.Productivity)
            {
                i++;
                urTeam.Add(new Middle());
                urTeamMiddles++;
                NeedProductivity -= middle.Productivity;
                Price += middle.Cost;    
                
                if (i == middleCounter)
                {
                    i = 0;
                    break;
                }
            }
            while (NeedProductivity >= junior.Productivity)
            {

                i++;
                urTeam.Add(new Junior());
                urTeamJuniors++;
                Price += junior.Cost;
                NeedProductivity -= junior.Productivity;
                
                if (i == juniorCounter)
                {
                    i = 0;
                    break;
                }
            }
            TotalProductivity -= NeedProductivity;
        }
    }
}

