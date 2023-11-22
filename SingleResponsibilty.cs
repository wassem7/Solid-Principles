
class Logger
{
    public void LogInformation()
    {
        Console.WriteLine("Attendace Logged to DB");
    }
}

class MailSender
{
    public void SendAttendanceEmail()
    {
        Console.WriteLine("Attendance Email sent");
    }
}

class User
{
    private string _username;

    public User(string username)
    {
        _username = username;
    }

    public string UserName
    {
        get { return this._username; }

        set { this._username = value; }

    }

}

class Validator
{
    public void ValidateUser(User user)
    {
        Console.WriteLine($"User : {user.UserName} Validated !");
    }
}

class ForumRegisteration
{

    private readonly Validator _validator;
    private readonly MailSender _mailsender;
    private readonly Logger _logger;

    public ForumRegisteration()
    {
        _validator = new Validator();
        _mailsender = new MailSender();
        _logger = new Logger();
    }



    public void RegisterUserForForum(User user)
    {
        _validator.ValidateUser(user);
        Console.WriteLine("User Registered !");
        _logger.LogInformation();
    }

    static void Main()
    {
        ForumRegisteration F1 = new ForumRegisteration();
        User user = new User("seemzy");
        F1.RegisterUserForForum(user);
    }
}


class AttendanceSystem
{
    private readonly MailSender _email;
    private readonly Logger _logger;

    public AttendanceSystem()
    {
        _email = new MailSender();
        _logger = new Logger();
    }

    public void CreateAttendance()
    {
        Console.WriteLine("Attendance Created !");
        _email.SendAttendanceEmail();
        _logger.LogInformation();

    }


    static void main()
    {
        AttendanceSystem a = new AttendanceSystem();
        a.CreateAttendance();
    }
}