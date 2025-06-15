using FLW.Domain;
using FLW.Dto;

namespace FLW.ServiceInterface
{
	public interface IFileServices
	{
		void UploadFileToDatabase(MusicDto dto, Music music);
		Task<FileToDatabase> RemoveImageFromDatabase(FileToDatabase dto);
	}
}