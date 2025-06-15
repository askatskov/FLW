using FLW.Domain;

namespace FLW.Data
{
	public class DbInitializer
	{
		public static void Initialize(MusicContext context)
		{
			if (context.Musics.Any())
			{
				return;
			}

			var musics = new Music[]
			{
				new Music()
				{
					Artist = "YoungBoy Never Broke Again",
					Song = "Top Tingz",
					Rating = 10f
				}
			};

			context.Musics.AddRange(musics);
			context.SaveChanges();
		}
	}
}
