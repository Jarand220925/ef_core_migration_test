using Microsoft.EntityFrameworkCore;
using System.Net;
using ef_core_migration_test.models.classes;






var builder = WebApplication.CreateBuilder(args);

// DbContext
builder.Services.AddDbContext<CoordinateDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("Postgres"),
        o => o.UseNetTopologySuite()
    )
);

var app = builder.Build();

app.MapGet("/",(CoordinateDbContext dbContext)=> dbContext.Coordinates);
// Hvis du bare vil bruke appen til migrasjoner / bakgrunnsjobb
app.Run();