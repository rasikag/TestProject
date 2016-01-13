using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models.DBModels
{
    public class PlaceImage
    {
        [Key]
        public Guid Id { get; set; }
        public virtual ICollection<Place> Event { get; set; }
        public bool Approved { get; set; }
    }
}
