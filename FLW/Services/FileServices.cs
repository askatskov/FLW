using FLW.Data;
using FLW.Domain;
using FLW.Dto;
using FLW.ServiceInterface;
using Microsoft.EntityFrameworkCore;

namespace FLW.Services
{
	public class FileServices : IFileServices
	{
		private readonly IHostEnvironment _webHost;
		private readonly MusicContext _context;

		public FileServices
			(
			IHostEnvironment webHost,
			MusicContext context
			)
		{
			_webHost = webHost;
			_context = context;
		}
		public void UploadFileToDatabase(MusicDto dto, Music domain)
		{
			if (dto.Files is not null && dto.Files.Count > 0)
			{
				foreach (var image in dto.Files)
				{
					using (var target = new MemoryStream())
					{
						FileToDatabase files = new FileToDatabase()
						{
							Id = Guid.NewGuid(),
							ImageTitle = image.Name,
							ArtistId = domain.ArtistId,
						};

						image.CopyTo(target);
						files.ImageData = target.ToArray();
						_context.FileToDatabase.Add(files);
					}
				}
			}
		}
		public async Task<FileToDatabase> RemoveImageFromDatabase(FileToDatabase dto)
		{
			var imageID = await _context.FileToDatabase
				.FirstOrDefaultAsync(x => x.Id == dto.Id);
			var filePath = _webHost.ContentRootPath + "\\multipleFileUpload\\" + imageID.ImageData;
			if (File.Exists(filePath))
			{
				File.Delete(filePath);
			}

			_context.FileToDatabase.Remove(imageID);
			await _context.SaveChangesAsync();

			return null;
		}
	}
}