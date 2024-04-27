namespace LombardApi.Context
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password {  get; set; }
        public string? Email { get; set; }
        public string? DateOfBirth { get; set; }
        
    }
}
