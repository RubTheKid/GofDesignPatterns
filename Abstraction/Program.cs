namespace Abstraction;

class Program
{
    static void Main(string[] args)
    {
        var emailService = new EmailService();

        //the methods connect and disconnect are unnecessary for the user
        emailService.SendEmail();
    }
}