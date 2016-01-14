using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models.DBModels
{
    public class PlaceImage
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Place")]
        public Guid PlaceId { get; set; }
        public virtual Place Place { get; set; }
        public bool Approved { get; set; }
    }
}
