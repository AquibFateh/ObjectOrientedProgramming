using ObjectOrientedProgramming.Abstraction;

namespace ObjectOrientedProgramming
{
    /// <summary>
    /// Program class.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();

            emailService.SendEmail();
        }
    }
}
