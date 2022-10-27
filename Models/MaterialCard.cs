using MaterialDesignThemes.Wpf;
using System.Collections.Generic;

namespace Gloomath.Models
{
    public class MaterialCard
    {
        public List<Content> Contents { get; set; }
        public string Description { get; set; }
        public PackIconKind Icon { get; set; }
        public string Title { get; set; }
    }
}