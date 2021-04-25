
namespace EmailService
{
    /// <summary>
    /// Send email.
    /// </summary>
    public interface IEmailSender
    {
        /// <summary>
        /// Send email.
        /// </summary>
        /// <param name="message">Email message.</param>
        void SendEmail(Message message);
    }
}
