namespace Sample1Data
{
    public class PlayerService
    {
        private readonly IDataContext _context;

        public PlayerService(IDataContext context)
        {
            _context = context;
        }

        public void AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
        }
    }
}
