using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonBot.Domain.Model
{
    public class ServiceRecord
    {
        public Guid Id { get; set; }
        public Guid SpecialistId { get; set; }
        public virtual Specialist Specialist { get; set; }
        public Guid ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
