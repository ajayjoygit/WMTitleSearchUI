using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarnerMedia.Data.Models
{
    public class TitleDetails
    {
        public int titleId { get; set; }
        public string titleName { get; set; }
        public string titleNameSortable { get; set; }
        public object titleTypeId { get; set; }
        public int releaseYear { get; set; }
        public DateTime processedDateTimeUTC { get; set; }
    }
}
