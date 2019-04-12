using System.Linq;

namespace DEV_6
{
    class CommandCountTypes: Command
    {
        public CommandCountTypes(Company company):base(company)
        {}

        public override double Execute() => company.allBrands.Distinct().Count();
    }
}
