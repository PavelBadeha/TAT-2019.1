using System;
using System.Collections.Generic;

namespace DEV_4
{
    /// <summary>
    /// Class Seminar
    /// </summary>
    class Seminar: Materials
    {
        /// <summary>
        /// <param name="numberOfQuestions">number of questions</param>
        ///<param name="ID">ID</param>
        ///<param name="questions">list of questions</param>
        ///<param name="answers">list of answers</param>
        /// </summary>
        private int numberOfQuestions = 0;
        private static string ID = ID.GenerateGUID();
        private List<string> questions;
        private List<string> answers;
       
        /// <summary>
        /// Constructor of Seminar
        /// </summary>
        public Seminar()
        {
            SetQuestions();
            SetAnswers();
        }
        
        /// <summary>
        /// Method that set questions
        /// </summary>
        public void SetQuestions()
        {         
            questions = new List<string>();          
            Console.WriteLine("Input how much wil be questions");
            numberOfQuestions = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input questions");
            for (int i=0;i<numberOfQuestions;i++)
            {
                questions.Add(Console.ReadLine());
            }             
        }

        /// <summary>
        /// Method that set answers
        /// </summary>
        public void SetAnswers()
        {
            answers = new List<string>();
            Console.WriteLine("Input answer");
            for (int i =0;i<numberOfQuestions;i++)
            {
                answers.Add(Console.ReadLine());
            }
        }     
    }
}
