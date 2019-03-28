using System.Collections.Generic;

namespace DEV_4
{ 
    /// <summary>
    /// Class that creates lection for the materials
    /// </summary>
    class Materials :Discipline
    {
       /// <summary>
       /// <param name="lection">object of Lection</param>
       /// <param name="lections">list of lection</param>
       /// </summary>
        private Lection lection;
        private static List<Lection> lections = new List<Lection>();

        /// <summary>
        /// Constructor of Materials
        /// </summary>
        public Materials()
        {
            lection = new Lection();
            lections.Add(lection);
        }

        /// <summary>
        /// Indexer return certain lecture and her seminars and laboratory lessons.
        /// </summary>
        /// <param name="index">Number of lection</param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                return lections[index].Inform();
            }
        }
    }
}
