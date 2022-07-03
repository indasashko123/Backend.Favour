namespace Favour.Api
{
    public class Person
    {
        public string Email { get; set; }
        public string Pass { get; set; }
        public Person(string email, string pass)
        {
            Email = email;
            Pass = pass;
        }
    }
}
