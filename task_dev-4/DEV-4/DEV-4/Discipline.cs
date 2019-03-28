using System;

namespace DEV_4
{

    /// <summary>
    /// Class creates materials for the discipline, clone discipline.
    /// </summary>
    class Discipline :ICloneable
    {

        /// <summary>
        /// <param name="ID">unique identificator</param>
        /// <param name="TextDesciption">Text Decscription </param>
        /// <param name="materials">object of Materials</param>
        /// </summary>
        private static string ID = ID.GenerateGUID();
        private string TextDescription = "Nothing to tell u";
        private Materials materials;

        /// <summary>
        /// Constructor of discipline.
        /// </summary>
        public Discipline()
        {            
            materials = new Materials();
        }

        /// <summary>
        /// Constructor of discipline with params
        /// </summary>
        public Discipline(string TextDescription,Materials materials)
        {
            this.TextDescription = TextDescription;
            this.materials = materials;
        }

        /// <summary>
        ///override method ToString() for Discipline
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "\nId is:" + ID + "\nDescription: " + TextDescription;
        }

        /// <summary>
        /// Method that set Text Description
        /// </summary>
        public void SetTextDescription()
        {
            Console.WriteLine("Input Description");
            TextDescription = Console.ReadLine();
            if (TextDescription.Length > 256)
            {
                throw new FormatException("Length more than 256");
            }
        }

        /// <summary>
        /// Method that return ID
        /// </summary>
        /// <returns></returns>
        public string GetID()
        {
            return ID;
        }

        /// <summary>
        /// override method Equals(object obj) for  Discipline
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Discipline p = (Discipline)obj;
                return  p.GetID()==ID;
            }
        }

        /// <summary>
        /// Implemented interface method deeply copies object.
        /// </summary>
        /// <returns disciplineClone></returns>
        public object Clone()
        {
            Discipline disciplineClone = new Discipline(this.TextDescription,this.materials);
            return disciplineClone;
        }
    }
}
