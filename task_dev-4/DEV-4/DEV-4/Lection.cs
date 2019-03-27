using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_4
{
    /// <summary>
    /// Class thath creates seminar,lab for lection
    /// </summary>
    class Lection :Materials
    {
        /// <summary>
        /// <param name="ID">ID</param>
        /// <param name="lectureText">text of lection</param>
        /// <param name="presentation">object of Presentation</param>
        /// <param name="labs">list of lab</param>
        /// <param name="seminars">list of seminar</param>
        /// </summary>
        private static string ID = ID.GenerateGUID();
        private string lectureText = string.Empty;
        private Presentation presentation;
        List<Lab> labs;
        List<Seminar> seminars;

        /// <summary>
        /// Construct of Lection
        /// </summary>
        public Lection()
        {

            labs = new List<Lab>();
            seminars = new List<Seminar>();
            presentation = new Presentation();
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(3); i++)
            {
                seminars.Add(new Seminar());
                labs.Add(new Lab());
            }         
        } 
        
        /// <summary>
        /// Method that Inform u about lection
        /// </summary>
        /// <returns></returns>
        public string Inform()
        {
            StringBuilder infoAboutLection = new StringBuilder();
            infoAboutLection.Append(this.ToString());
            foreach (var lab in labs) 
            {
                infoAboutLection.Append(lab.ToString());
            }
            foreach (var seminar in seminars)
            {
                infoAboutLection.Append(seminar.ToString());
            }
            return infoAboutLection.ToString();
        }

        /// <summary>
        /// Method that set text of lection
        /// </summary>
        public void SetLectureText()
        {
            Console.WriteLine("Input lecture text");
            lectureText = Console.ReadLine();
            if (lectureText.Length > 100000)
            {
                throw new FormatException("Length more than 100000");
            }      
        }
    }
}
