using System;
using System.Collections.Generic;

namespace DEV_3
{
    /// <summary>
    /// Class that create team for customer
    /// </summary>
    class TeamBuild:Company
    {
        /// <summary>
        /// <param name="Amount">the amount of money that the customer is willing to spend</param>
        /// <param name="NeedProductivity">desired productivity</param>
        /// <param name="TotalProductivity">output productivity</param>
        /// <param name="Price">Price</param>
        /// <param name="urTeam">list of employees thath sold</param>
        /// <param name="urTeamLeads">quantity of leads that sold</param>
        /// <param name="urTeamSeniors">quantity of seniors that sold</param>
        /// <param name="urTeamMiddles">quantity of middles that sold</param>
        /// <param name="urTeamJuniors">quantity of juniors that sold</param>
        /// </summary>
        protected int Amount = 0;
        protected int NeedProductivity = 0;
        protected int TotalProductivity = 0;
        protected int Price=0;
        protected List<Employee> urTeam;
        protected int urTeamLeads = 0;
        protected int urTeamSeniors = 0;
        protected int urTeamMiddles = 0;
        protected int urTeamJuniors = 0;

        //objects of Lead,Senior,Middle,Junior
        protected Lead lead;
        protected Senior senior;
        protected Middle middle;
        protected Junior junior;
         
        /// <summary>
        /// the constructor that create object of Employees
        /// </summary>
        public TeamBuilder()
        {
            junior = new Junior();
            middle = new Middle();
            senior = new Senior();
            lead = new Lead();
            urTeam = new List<Employee>();
        }

        /// <summary>
        /// a method that considers how much and who needs the customer
        /// </summary>
        public virtual void Colculate() { }

        /// <summary>
        /// display team for a customer
        /// </summary>
        public void  PrintUrTeam()
        {
            Console.WriteLine("Your Team :");
            Console.WriteLine($"{urTeamLeads} Leads\n{urTeamSeniors} Seniors\n{urTeamMiddles} Middles\n{urTeamJuniors} Juniors");
            Console.WriteLine($"Yours price is {Price}\nYours productivity is {TotalProductivity}");        
            if (Amount >= junior.Cost || NeedProductivity >= junior.Productivity )
            {
                Console.WriteLine("Not enough staff to perform fully");
            }        
        }
    }
}
