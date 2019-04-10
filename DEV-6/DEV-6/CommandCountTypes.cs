
namespace DEV_6
{
    class CommandCountTypes: Command
    {
        private int CountOfTypes;
        public CommandCountTypes(Company company):base(company)
        {
            CountOfTypes = 0;
        }
        public override double Execute()
        {
            foreach(var el in company.allBrands)
            {
                CountOfTypes++;
            }
            return CountOfTypes;
        }      

    }
}
