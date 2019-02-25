using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC91Training.Feature.Metadata.Models
{
    public interface IMetadata
    {
        string PageTitle { get; set; }
        string SiteTitle { get; set; }
        string Description { get; set; }

        ICollection<String> KeywordsList { get; }

        String Title { get; set; }

        ICollection<string> Robots { get; }

        ICollection<KeyValuePair<String, String>> CustomMetadata { get; }
    }
}
