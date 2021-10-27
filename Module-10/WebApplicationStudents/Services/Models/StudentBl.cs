namespace BusinessLogic.Models
{
    public record StudentBl
    {
        public int Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public int Age { get; init; }
        public string Email { get; init; }
        public int Score { get; init; }
    }
}
