
namespace DEV_3
{
    class Senior:Middle
    {       
        public Senior()
        {
            Cost *= 2;
            Productivity *= 5;
        }
        public override string GetName()
        {
            return "Senior";
        }
    }
}
