using MyMusic.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyMusic.Core.Services
{
    public interface IArtistService
    {
        Task<IEnumerable<Artist>> GetAllWithArtist();

        Task<Artist> GetArtistById(int id);

        Task<Artist> CreateArtist(Artist artist);

        Task UpdateArtist(Artist artistToBeUpdated, Artist artist);

        Task DeleteArtist(Artist artist);
    }
}