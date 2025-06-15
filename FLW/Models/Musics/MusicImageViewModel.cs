using Microsoft.AspNetCore.Mvc;

namespace Flow.Models.Musics
{
	public class MusicImageViewModel
	{

		public Guid ImageID { get; set; }
		public string ImageTitle { get; set; }
		public byte[] ImageData { get; set; }
		public string Image { get; set; }
		public Guid? ArtistId { get; set; }
	}
}