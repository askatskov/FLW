using FLW.Models.Musics;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FLW.Models.Musics
{
	public class MusicCreateViewModel
	{
		[Required]
		public string Artist { get; set; }

		[Required]
		public string Song { get; set; }

		[Range(0, 10)]
		public float Rating { get; set; }
		public List<IFormFile> Files { get; set; } = new();
		public List<MusicImageViewModel> Image { get; set; } = new();
	}
}