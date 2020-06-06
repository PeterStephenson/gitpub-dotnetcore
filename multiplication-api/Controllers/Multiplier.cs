namespace multiplication_api.Controllers
{
    public class Multiplier : IMultiplier
    {
        public int MultiplyNumbers(int lhs, int rhs)
        {
            return lhs * rhs;
        }
    }
}