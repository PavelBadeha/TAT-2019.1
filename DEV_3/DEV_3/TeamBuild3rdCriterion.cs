using System;

namespace DEV_3
{
    /// <summary>
    /// Class of third criterion
    ///Third criterion minimum number of staff qualifications above Junior for fixed productivity
    /// </summary>
    class TeamBuild3rdCriterion :TeamBuild
    {
        /// <summary>
        /// the constructor of class
        /// </summary>
        public TeamBuild3rdCriterion()
        {
            Console.WriteLine("Input productivity");
            NeedProductivity = Int32.Parse(Console.ReadLine());
            TotalProductivity = NeedProductivity;
            if (NeedProductivity <= middle.Productivity)
            {
                Console.WriteLine("Not correct input!");
            }
            Colculate();
        }
        public override void Colculate()
        {
            int i = 0;
            while (NeedProductivity >= lead.Productivity)
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
                Price += middle.Cost;
                NeedProductivity -= middle.Productivity;            
                if (i == middleCounter)
                {
                    i = 0;
                    break;
                }       
            }    
            TotalProductivity -= NeedProductivity;
        }
    }
}

