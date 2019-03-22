
namespace DEV_3
{
    class Lead:Senior
    {      
        public Lead()
        {
            Cost *= 2;
            Productivity += 30;
        }
        public override string GetName()
        {
            return "Lead";
        }
    }
}
