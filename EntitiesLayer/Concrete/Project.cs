using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description1 { get; set; } = string.Empty;
        public string Description2 { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Image2 { get; set; } = string.Empty;
        public string Image3 { get; set; } = string.Empty;
        public string Image4 { get; set; } = string.Empty;

        public List<Language> Languages { get; set; } = new();

    }
}
