namespace BeautySalonBot.Domain.Model
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public virtual List<ServiceRecord> Records { get; set; }
        public Client()
        {
        }

        public Client(Guid id, string name, string phoneNumber, List<ServiceRecord> records)
        {
            Id = id;
            Name = string.IsNullOrEmpty(name) ? throw new ArgumentNullException(nameof(name)) : name;
            PhoneNumber = string.IsNullOrEmpty(phoneNumber) ? throw new ArgumentNullException(nameof(phoneNumber)) : phoneNumber;
            Records = records ?? throw new ArgumentNullException(nameof(records));
        }
    }
}
