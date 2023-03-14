namespace RegeUserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                UC-01As a User need to enter a valid First Name
                    - First name starts with Cap and has minimum 3 characters
            */
            Console.WriteLine("Enter The First Name Of User");
            string first_Name = Console.ReadLine();
            if (UserDetailCheck.ValidateFirstName(first_Name))
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }
    }
}