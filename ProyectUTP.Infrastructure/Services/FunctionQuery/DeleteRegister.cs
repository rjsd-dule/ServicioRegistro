namespace ProyectUTP.Infrastructure.Services.FunctionQuery
{
    public class DeleteRegister
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteRegister(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
