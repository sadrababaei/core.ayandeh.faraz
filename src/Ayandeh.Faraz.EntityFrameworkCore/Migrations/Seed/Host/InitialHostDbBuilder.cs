using Ayandeh.Faraz.EntityFrameworkCore;

namespace Ayandeh.Faraz.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly FarazDbContext _context;

        public InitialHostDbBuilder(FarazDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
