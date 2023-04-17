namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            passwordrule4 passWord = new passwordrule4();
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();
            Console.WriteLine(passWord.ValidatePassword(password));
        }
    }
}