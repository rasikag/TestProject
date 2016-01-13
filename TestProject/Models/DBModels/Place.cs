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

        [Column("Name", TypeName = "varchar")]
        [StringLength(25)]
        public string PlaceName { get; set; }

        [Column("City", TypeName = "varchar")]
        [StringLength(25)]
        public string PlaceLocatedCity { get; set; }

        [Column("Address", TypeName = "varchar")]
        [StringLength(250)]
        public string Address { get; set; }
        public DateTime PlaceOpenTime { get; set; }
        public DateTime PlaceCloseTime { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [ForeignKey("District")]
        public Guid DistrictId { get; set; }
        public virtual District District { get; set; }
        public virtual ICollection<PlaceImage> PlaceImage { get; set; }
        public virtual ICollection<PlaceVideo> PlaceVideo { get; set; }
        public virtual ICollection<PlaceComment> PlaceComment { get; set; }
    }
}
