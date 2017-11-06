using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSDev.Models
{
    public class CorrCompDescResolution
    {
        public int cc_desc_id { get; set; }
        public int cc_number { get; set; }
        public byte cc_description { get; set; }
        public string cc_description_text { get; set; }
        public byte cc_resolution { get; set; }
        public string cc_resolution_text { get; set; }
        public int last_update_by { get; set; }
        public DateTime tstamp { get; set; }

    }
}
