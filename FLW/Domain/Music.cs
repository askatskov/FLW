using System.ComponentModel.DataAnnotations;

namespace FLW.Domain
{
	public class Music
	{
		[Key]
		public Guid ArtistId { get; set; }

		[Required]
		[MaxLength(100)]
		public string Artist { get; set; }

		[Required]
		[MaxLength(100)]
		public string Song { get; set; }

		[Range(0, 10)]
		public float Rating { get; set; }
	}
}
