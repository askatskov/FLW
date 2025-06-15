using FLW.Domain;
using FLW.Dto;

namespace FLW.ServiceInterface
{
	public interface IMusicServices
	{
		Task<Music> Create(MusicDto dto);
		Task<Music> Delete(Guid id);
		Task<Music> DetailsAsync(Guid id);

	}
}