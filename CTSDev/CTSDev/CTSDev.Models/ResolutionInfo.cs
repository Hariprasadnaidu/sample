using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTSDev.Models
{
	public class ResolutionInfo
	{
		public int resolution_id { get; set; }
		public int cc_number { get; set; }
		public int cc_handled_by { get; set; }
		public string comments { get; set; }
		public int last_update_by { get; set; }
		public DateTime tstamp { get; set; }
	}
}