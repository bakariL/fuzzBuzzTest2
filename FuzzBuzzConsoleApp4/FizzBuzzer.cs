
namespace FuzzBuzzConsoleApp4
{
    public class FizzBuzzer
    {
     

        public string Get(int v)
        {
            if (v % 15 == 0)
                return "FizzBuzz";
            if (v % 5 == 0)
                return "Buzz";
            if (v % 3 == 0)
                return "Fizz";
            return v.ToString();
        }
    }
}