using System.Text;

namespace DEV_1
{
    /// <summary>
    /// The class that search sub strings
    /// </summary>
    public class FinderUniqueSubString
    {
        /// <summary>
        /// <param name="str"></param> string that is subject to change
        /// <param name="BuffResultSting"></param>buffer StringBuilder that will be contain all unique subsequences
        /// <param name="ResultString"></param> Result string which contain all unique subsequences
        /// </summary>
        private string str = string.Empty;
        private StringBuilder BuffResultString = new StringBuilder(string.Empty);
        private string ResultString = string.Empty;

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="_str"></param>
        public FinderUniqueSubString(string _str)
        {
            str = _str;
        }

        /// <summary>
        ///The method that search substrings
        /// </summary>
        public void SearchSubString()
        {
            /// <summary>
            ///<param name="flag"></param> variable that monitors whether the loop has reached repeated letters
            ///<param name="buff"></param> buffer variable that contain substring
            /// <param name="buff2"></param> buffer variable that contain substring of substring 
            /// </summary>
            bool flag = false;
            string buff = string.Concat(str[0]);
            string buff2 = string.Empty;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i - 1])
                {
                    buff += str[i];
                }
                else
                {
                    flag = true;
                }
                if (flag || (i == str.Length - 1))
                    while (buff.Length >= 2)
                    {
                        for (int k = 0; k < buff.Length; k++)
                        {
                            buff2 += buff[k];
                            if (buff2.Length >= 2)
                            {
                                BuffResultString.Append($"{buff2}\n");
                            }
                        }
                        buff = buff.TrimStart(buff[0]);
                        buff2 = string.Empty;
                    }
                flag = false;
            }
            ResultString = BuffResultString.ToString();
        }
    }
}
