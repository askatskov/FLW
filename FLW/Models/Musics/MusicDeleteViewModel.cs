using FLW.Models.Musics;
using Microsoft.AspNetCore.Mvc;

namespace FLW.Models.Musics
{
	public class MusicDeleteViewModel
	{
		public Guid ArtistId { get; set; }
		public string Artist { get; set; }
		public string Song { get; set; }
		public float Rating { get; set; }
		public List<IFormFile> Files { get; set; }
		public List<MusicImageViewModel> Image { get; set; } = new List<MusicImageViewModel>();
	}
}