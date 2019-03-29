using System;
using System.Collections.Generic;

namespace DEV_3
{
    /// <summary>
    /// Class that contain info about Company
    /// </summary>
    class Company
    {
        /// <summary>
        ///<param name="leadCounter">quantity of leads</param>
        ///<param name="seniorCounter">quantity of seniors</param>
        ///<param name="middleCounter">quantity of middles</param>
        ///<param name="juniorcounter">quantity of juniors</param>
        ///<param name="employeeCounter">quantity of employees</param>
        ///<param name="employees">lis of employees</param>
        /// </summary>
        protected int leadCounter = 5;
        protected int seniorCounter = 3;
        protected int middleCounter = 3;
        protected int juniorCounter = 10;
        protected int employeesCounter = 0;
        protected  List<Employee> employees = new List<Employee>();

        /// <summary>
        /// the constructor who fills the list of employees
        /// </summary>
        public Company()
        {
            employeesCounter = leadCounter + seniorCounter + middleCounter + juniorCounter;
            for (int i = 0; i < leadCounter; i++)
            {
                employees.Add(new Lead());
            }
            for (int i = 0; i < seniorCounter; i++)
            {
                employees.Add(new Senior());
            }
            for (int i = 0; i < middleCounter; i++)
            {
                employees.Add(new Middle());
            }
            for (int i = 0; i < juniorCounter; i++)
            {
                employees.Add(new Junior());
            }
        }

        /// <summary>
        /// a method which shows which employees the company is ready to sel
        /// </summary>
        /// <param name="obj">the object that selects which employees are needed</param>
        public void GetUrTeam(TeamBuild obj)
        {
            obj.GetUrTeam();     
        }

        /// <summary>
        /// a method that displays all employess
        /// </summary>
        public void GetEmployees()
        {
            foreach(var emp in employees)
            {
                Console.WriteLine(emp.GetName());
            }
        }
    }
}
