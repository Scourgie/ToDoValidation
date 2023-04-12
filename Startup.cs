using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using ToDoListAdolfson.Models;
using ToDoListAdolfson.Models.DataLayer;

namespace ToDoListAdolfson
{
    public class Startup
    {
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ToDoContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ToDoContext")));
        }

    }
}
