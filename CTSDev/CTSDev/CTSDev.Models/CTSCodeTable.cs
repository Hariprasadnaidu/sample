using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTSDev.Models
{
	public class CTSCodeTable
	{
		public int table_no { get; set; }
		public int table_code { get; set; }
		public string short_description { get; set; }
		public string long_description { get; set; }
		public int display_order { get; set; }
		public string visibleyn { get; set; }
        public string adm_flag { get; set; }
		public string check1_flag { get; set; }
		public byte show_long_desc_info { get; set; }
		public DateTime tstamp { get; set; }
	}
}