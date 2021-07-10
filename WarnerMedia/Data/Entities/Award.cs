using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarnerMedia.Data.Entities
{
	public class Award
	{
		public int Id { get; set; }
		public Title Title { get; set; }
		
		public bool AwardWon { get; set; }
		public int  AwardYear { get; set; }
		public string AwardName { get; set; }
		public string AwardCompany { get; set; }

	}
}
