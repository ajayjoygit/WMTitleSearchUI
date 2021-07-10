using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarnerMedia.Data.Entities
{
	public class Title
	{
		public int Id { get; set; }
		public string TitleName { get; set; }

		public string TitleNameSortable { get; set; }
		public int TitleTypeId { get; set; }
		public int ReleaseYear { get; set; }
		/*
		public DateTime ProcessedDateTimeUTC { get; set; }		
		public ICollection<TitleParticipant> TitleParticipantsItems { get; set; }
		public ICollection<TitleGenre> TTitleGenreItems { get; set; }
		public ICollection<StoryLine> StoryLineItems { get; set; }
		public ICollection<Award> AwardItems { get; set; }
		public ICollection<OtherName> OtherNameItems { get; set; }
		*/

	}
}
