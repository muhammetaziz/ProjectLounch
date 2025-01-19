using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{
    public class Language
    {
        public int ID { get; set; }
        public Project Project { get; set; }= null!;
        public int ProjectId { get; set; }
    }
}
