namespace BeautySalonBot.Domain.Model
{
    public class Salon
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<Specialist> Specialists { get; set; }
        public virtual List<Service> Services { get; set; }

        public Salon() { }

        public Salon(Guid id, string name, List<Specialist> specialists, List<Service> services)
        {
            Id = id;
            Name = string.IsNullOrEmpty(name) ? throw new ArgumentNullException(nameof(name)) : name;
            Specialists = specialists ?? throw new ArgumentNullException(nameof(specialists));
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }
    }
}