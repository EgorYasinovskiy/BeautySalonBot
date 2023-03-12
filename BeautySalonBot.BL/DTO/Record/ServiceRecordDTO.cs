namespace BeautySalonBot.BL.DTO.Record
{
    public class ServiceRecordDTO
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string ServiceName { get; set; }
        public string ClientName { get; set; }
        public string SpecialistName { get; set; }
        public bool Cancelled { get; set; }
    }
}
