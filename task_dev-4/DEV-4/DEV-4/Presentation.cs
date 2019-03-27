using System.Linq;

namespace DEV_4
{
    /// <summary>
    /// Class thath conatin URI adn Format of presentation
    /// </summary>
    class Presentation : Materials
    {
        /// <summary>
        /// <param name="URI">URI</param>
        /// <param name="Format">Format</param>
        /// <param name="ExistingFormats">array of formats that can be use</param>
        /// </summary>
        public string URI { get; protected set; }
        public string Format { get; protected set; }
        private string[] ExistingFormats = new string[] { "Unknow", "PDF", "PPT" };

        /// <summary>
        /// Construct if Presentation
        /// </summary>
        public Presentation()
        {
            URI = "Default URI";
            Format = "Unknow";
        }

        /// <summary>
        /// Construct if Presentation with param
        /// </summary>
        /// <param name="Format">name of Format</param>
        public Presentation(string Format)
        {
            if (ExistingFormats.Contains(Format))
            {
                this.Format = Format;
            }
            else
                this.Format = "Unknow";
        }
    }
}
