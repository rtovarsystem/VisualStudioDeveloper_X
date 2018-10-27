using Models;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public interface ITrackRepository : IRepository<Track>
    {
        IEnumerable<Track> GetByPlaylistId(int playlistId);

      
    }
}
