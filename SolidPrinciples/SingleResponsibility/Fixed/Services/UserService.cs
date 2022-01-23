using SolidPrinciples.SingleResponsibility.Fixed.Data;

namespace SolidPrinciples.SingleResponsibility.Fixed.Services
{
    internal class UserService
    {
        private readonly EmailService _emailService;
        //private readonly DbContext _context;

        public UserService(EmailService emailService/*, DbContext context*/)
        {
            _emailService = emailService;
            //_context = context;
        }
        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new Exception("Email is not an email");

            var user = new User() { EmailAddress = email, Password = password };

            //_context.Save(user);

            _emailService.SendRegistrationEmail(user.EmailAddress);
        }
    }
}
