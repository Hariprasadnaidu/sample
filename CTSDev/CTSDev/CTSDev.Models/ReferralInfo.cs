using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTSDev.Models
{
	public class ReferralInfo
	{
		public int referral_id { get; set; }
		public int cc_number { get; set; }
		public string referred_to_group { get; set; }
		public DateTime due_date { get; set; }
		public string referral_status { get; set; }
		public string comments { get; set; }
        public string referral_accpt_yn { get; set; }
		public string referral_rejected_comments { get; set; }
		public int last_update_by { get; set; }
		public DateTime tstamp { get; set; }
	}
}