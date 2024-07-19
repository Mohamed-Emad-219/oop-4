using oop_4.EmailNotificationService;
using oop_4.Interfacee;
namespace oop_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          






            #region EmailNotificationService
            ////IAuthenticationService authService = new BasicAuthenticationService();

            ////string username = "Ali";
            ////string password = "122";
            ////string role = "user";

            ////bool isAuthenticated = authService.AuthenticateUser(username, password);
            ////bool isAuthorized = authService.AuthorizeUser(username, role);

            ////Console.WriteLine($"User authenticated: {isAuthenticated}"); 
            /////Console.WriteLine($"User authorized: {isAuthorized}");
            #endregion

            #region Q3
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //string emailRecipient = "mm@gmail.com";
            //string smsRecipient = "01143434613";
            //string pushRecipient = "tito@gmail.com";

            //string emailMessage = "lllll.";
            //string smsMessage = "y r code 525254.";
            //string pushMessage = " msg inbox.";

            //emailService.SendNotification(emailRecipient, emailMessage);
            //smsService.SendNotification(smsRecipient, smsMessage);
            //pushService.SendNotification(pushRecipient, pushMessage);

            #endregion

        }
    }
}
