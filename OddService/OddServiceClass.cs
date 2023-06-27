namespace Odd.Services
{
    public class OddService
    {
        public bool IsOdd(int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
