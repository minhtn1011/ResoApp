using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResoWeb.WebPage.Pages
{
    public class SingleModel
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public IEnumerable<Characteristic> Characteristics { get; set; }
        public string Description { get; set; }
        public IEnumerable<Feature> Features { get; set; }
     
        public IEnumerable<Document> Documents { get; set; }
    }

    public class Document
    {
        public string Title { get; set; }
        public string Link { get; set; }
    }

    public class Feature
    {
        public string Title { get; set; }
        public string SmallText { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public IEnumerable<FeatureDetail> FeatureDetails { get; set; }
    }
    public class FeatureDetail
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
    }

    public class Characteristic
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
    }
}
