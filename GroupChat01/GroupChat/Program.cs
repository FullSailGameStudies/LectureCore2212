namespace GroupChat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1) return a true or false
            //2) using the out parameter, return the # if the string can be converted to an int
            string usersInput = "5";
            if(int.TryParse(usersInput, out int theNumber) == false)
                Console.WriteLine($"{usersInput} is NOT a number." );
            else //isANumber is true
                Console.WriteLine($"{usersInput} is a number: {theNumber}.");
        }
    }
}