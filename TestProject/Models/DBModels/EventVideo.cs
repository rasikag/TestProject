using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models.DBModels
{
    public class EventVideo
    {
        [Key]
        public Guid Id { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public bool Approved { get; set; }
    }
}
