using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models.DBModels
{
    public class SliderImages
    {
        public int Id { get; set; }
        public Guid ImageName { get; set; }
        public bool Active { get; set; }
        public bool Delete { get; set; }

    }
}
