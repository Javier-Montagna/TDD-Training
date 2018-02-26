namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public string Print(int i)
        {
            if (IsDivisableByThree(i) && IsDivisableByFive(i)) {
                return "FizzBuzz";
            } else if (IsDivisableByFive(i)) {
                return "Buzz";
            } else if (IsDivisableByThree(i)) {
                return "Fizz";
            }
            return i.ToString();
        }

        private bool IsDivisableByThree(int n)
        {
            return n % 3 == 0;
        }
    
        private bool IsDivisableByFive(int n)
        {
            return n % 5 == 0;
        }
    }
}