using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models.DBModels
{
    public class Place
    {
        [Key]
        public Guid Id { get; set; }

        public string PlaceName { get; set; }
        public string PlaceLocatedCity { get; set; }
        public string Address { get; set; }
        public DateTime PlaceOpenTime { get; set; }
        public DateTime PlaceCloseTime { get; set; }
        public string Description { get; set; }
        [ForeignKey("District")]
        public Guid DistrictId { get; set; }
        public virtual District District { get; set; }
        public virtual ICollection<PlaceImage> PlaceImage { get; set; }
        public virtual ICollection<PlaceVideo> PlaceVideo { get; set; }
        public virtual ICollection<PlaceComment> PlaceComment { get; set; }
    }
}
