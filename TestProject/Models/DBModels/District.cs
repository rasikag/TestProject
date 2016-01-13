using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models.DBModels
{
    public class District
    {
        public int Id { get; set; }
        [Column("DistrictName", TypeName = "varchar")]
        [StringLength(25)]
        public string DistrictName { get; set; }

    }
}
