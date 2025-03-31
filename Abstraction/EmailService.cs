﻿namespace ObjectOrientedProgramming.Abstraction
{
    /// <summary>
    /// EmailService class.
    /// </summary>
    public class EmailService
    {
        /// <summary>
        /// To send E-mail.
        /// </summary>
        public void SendEmail()
        {
            Connect();
            Authenticate();
            System.Console.WriteLine("Sending email...");
            Disconnect();
        }

        // ALL THE BELOW METHODS ARE PRIVATE -- THEY ARE NOT EXPOSED TO OTHER CLASSES. OTHER CLASSES JUST WANT TO SEND EMAILS, NO NEED FOR THEM TO SEE ALL THE COMPLEX DETAILS OF CONNECTING TO MAIL SERVER, AUTHENTICATING, DISCONNECTING.

        private void Connect()
        {
            System.Console.WriteLine("Connecting to email server...");
        }

        private void Authenticate()
        {
            System.Console.WriteLine("Authenticating...");
        }

        private void Disconnect()
        {
            System.Console.WriteLine("Disconnecting from email server...");
        }
    }
}
