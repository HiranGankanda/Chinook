namespace Chinook.DAL.Artistx
{
    public interface IArtistDAL
    {
        Task<Models.Artist?> GetArtistById(long artistId);
        Task<List<Models.Artist>> GetArtistsByName(string artistName);
        Task<List<Models.Artist>> GetAllArtists();
    }
}
