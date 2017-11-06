using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CTSDev.Models;

namespace CTSDEV.Mappers
{
	public class ResolutionInfoMap : EntityTypeConfiguration<ResolutionInfo>
	{
		public ResolutionInfoMap()
		{
			this.HasKey(t => t.resolution_id);
			this.ToTable("ResolutionInfoMap");
			this.Property(t => t.resolution_id).HasColumnName("resolution_id");
			this.Property(t => t.cc_number).HasColumnName("cc_number");
			this.Property(t => t.cc_handled_by).HasColumnName("cc_handled_by");
			this.Property(t => t.comments).HasColumnName("comments");
			this.Property(t => t.last_update_by).HasColumnName("last_update_by");
			this.Property(t => t.tstamp).HasColumnName("tstamp");
		}
	}
}