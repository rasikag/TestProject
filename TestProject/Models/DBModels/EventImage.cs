using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models.DBModels
{
    public class EventImage
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Event")]
        public Guid EventId { get; set; }

        public virtual Event Event { get; set; }
        public bool Approved { get; set; }

    }
}
