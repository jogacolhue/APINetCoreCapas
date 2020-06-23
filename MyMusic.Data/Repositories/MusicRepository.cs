using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Models;
using MyMusic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Data.Repositories
{
    public class MusicRepository : Repository<Music>, IMusicRepository
    {
        private MyMusicDbContext MyMusicDbContext
        {
            get { return Context as MyMusicDbContext; }
        }

        public MusicRepository(DbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Music>> GetAllWithArtistAsync()
        {
            return await MyMusicDbContext.Musics
                .Include(m => m.Artist)
                .ToListAsync();
        }

        public async Task<IEnumerable<Music>> GetAllWithArtistByArtistsIdAsync(int artistId)
        {
            return await MyMusicDbContext.Musics
                .Include(m => m.Artist)
                .Where(m => m.ArtistId == artistId).ToListAsync();
        }

        public async Task<Music> GetWithArtistByIdAsync(int id)
        {
            return await MyMusicDbContext.Musics
                .SingleOrDefaultAsync(m => m.Id == id);
        }
    }
}