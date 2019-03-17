using System;
using System.Linq;
using System.Text;


namespace DEV_2
{
    class MakeTranscription
    {
        /// <summary>
        /// <param name="str"></param> Source string
        /// <param name="Vowel"></param> Vowels
        /// <param name="Consonant"></param> Consonants
        /// <param name="AfterYote"></param> Yote's transformation
        /// <param name="SoftYote"></param> One more Yote's transformation
        /// <param name="BuffResultingString"></param> Buff string that contains trnascription
        /// <param name="ResuktingString"></param> Result
        /// </summary>
        private string str = String.Empty;
        private string Vowel = "аоиеёэыуюя";
        private string Consonant = "бвгджзйклмнпрстфхцчшщ";
        private string VoicedConsonants = "бвгджз";
        private string DeafConsonants = "пфктшс";
        private string Soundless = "ъь";
        private string Yote = "юяёе";
        private string AfterYote = "уаоэ";
        private string[] SoftYote = new string[] { "йу", "йа", "йо", "йэ" };
        private StringBuilder BuffResultString = new StringBuilder(string.Empty);
        private string ResultString = string.Empty;

        public MakeTranscription(string _str)
        {
            str = _str;
        }

        /// <summary>
        /// StressedLetter unstressed 'о' goes into 'a'
        /// </summary>
        public string StressedLetter()
        {
          
            return "a";
                               
        }

        /// <summary>
        ///The vowels of "ю", "я", "е", "ё" soften the previous consonant sound and transform into "y", "a", "o", "э
        /// </summary>
        public string Softening(string Letter)
        {
            int index = Yote.IndexOf(Letter);
            Letter = AfterYote[index].ToString();
            return Letter;
            
        }
        /// <summary>
        ///The vowels "ю", "я", "е", "ё" at the beginning of the word, 
        ///after other vowels and after "ь", "ъ" are converted into "йю", "йа", "йо", "йэ"
        /// </summary>
       
        public string MakeSoftYote(string Letter)
        {
            int index = Yote.IndexOf(Letter);
            Letter = SoftYote[index];
            return Letter;
          
        }
        /// <summary>
        /// The voicing / stunning of consonants is a ringing vowel after the deaf and 
        /// at the end of the word becomes deaf, and the deaf before the voiced-voiced
        /// </summary>
        
        public string VoicedToDeaf(string Letter)
        {
            int index = VoicedConsonants.IndexOf(Letter);
            Letter = DeafConsonants[index].ToString();
            return Letter;
        
        }
        public string DeafToVoiced(string Letter)
        {
            int index = DeafConsonants.IndexOf(Letter); 
            Letter = VoicedConsonants[index].ToString();
            return Letter;         
        }
        /// <summary>
        /// softening of consonants
        /// </summary>

        public string HardToSoft(string Letter)
        {
            return Letter + "'";
           
        }
        /// <summary>
        /// monitors outside arrays
        /// </summary>

        public bool CheckOutOfRange(int i)
        {
            return (i + 1 < str.Length);
        }
        /// <summary>
        /// Method that conatins all rule
        /// </summary>
        public void Transcriptor()
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+')
                {
                    continue;
                }
                BuffResultString.Append(str[i].ToString());
                if (CheckOutOfRange(i))
                {
                    if (str[i] == 'о' && str[i + 1] != '+')
                    {
                        BuffResultString.Replace(str[i].ToString(), StressedLetter());
                    }
                }

                if (str[i] == 'о' && i + 1 == str.Length)
                {
                    BuffResultString.Replace(str[i].ToString(), StressedLetter());
                }                              
                if (CheckOutOfRange(i))
                {
                    if (Consonant.Contains(str[i]) && Yote.Contains(str[i + 1]))
                    {
                      
                        BuffResultString.Append(str[i+1].ToString());                                         
                        BuffResultString.Replace(str[i].ToString(), HardToSoft(str[i].ToString()));
                        BuffResultString.Replace(str[i+1].ToString(), Softening(str[i+1].ToString()));
                        i++;
                    }
                }
                if (CheckOutOfRange(i))
                {
                    if ((Soundless.Contains(str[i]) || Vowel.Contains(str[i])) && Yote.Contains(str[i + 1]))
                    {
                        BuffResultString.Append(str[i+1].ToString());
                        BuffResultString.Replace(str[i+1].ToString(), MakeSoftYote(str[i + 1].ToString()));                     
                        if(Soundless.Contains(str[i]))
                        {
                            BuffResultString.Remove(i+1, 1);
                        }
                        i++;
                    }
                }               
                if (Yote.Contains(str[i]) && i == 0)
                {
                   BuffResultString.Replace(str[i].ToString(), MakeSoftYote(str[i].ToString()));
                   
                }
                if (CheckOutOfRange(i))
                {
                    if(Consonant.Contains(str[i]) && Soundless.Contains(str[i+1]))
                    {
                        BuffResultString.Append("'");
                        BuffResultString.Append(str[i + 1].ToString());
                        BuffResultString.Replace(str[i + 1].ToString(),string.Empty);                       
                    }
                }
                if(Soundless.Contains(str[i]) && i == str.Length-1)
                {
                    BuffResultString.Remove(BuffResultString.Length-1,1);
                }
                if(CheckOutOfRange(i))
                {

                    if (VoicedConsonants.Contains(str[i]) && DeafConsonants.Contains(str[i + 1]))
                    {
                                                     
                        BuffResultString.Replace(str[i].ToString(), VoicedToDeaf(str[i].ToString()));               
                    }
                    if (DeafConsonants.Contains(str[i]) && VoicedConsonants.Contains(str[i + 1]))
                    {

                        BuffResultString.Replace(str[i].ToString(), DeafToVoiced(str[i].ToString()));                       
                    }
                }
                if(VoicedConsonants.Contains(str[i]) && i+1 == str.Length)
                {
                  
                    BuffResultString.Replace(str[i].ToString(), VoicedToDeaf(str[i].ToString()));
                }
            }
            ResultString = BuffResultString.ToString();
        }

        public void DisplayResult()
        {
            Console.WriteLine(ResultString);
        }
    }
}
