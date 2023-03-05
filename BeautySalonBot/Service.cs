namespace BeautySalonBot.Model
{
    public class Service
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public TimeSpan Duration { get; set; }
        public Guid SalonId { get; set; }
        public virtual Salon Salon { get; set; }
        public Service()
        {
        }

        public Service(Guid id, string name, string description, string category, TimeSpan duration)
        {
            Id = id;
            Name = string.IsNullOrEmpty(name) ? throw new ArgumentNullException(nameof(name)) : name;
            Description = string.IsNullOrEmpty(description) ? throw new ArgumentNullException(nameof(description)) : description;
            Category = string.IsNullOrEmpty(category) ? throw new ArgumentNullException(nameof(category)) : category;
            Duration = duration;
        }
    }
}