using AngelaAraujo;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;




var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

app.MapGet("/", () => "API rodando com Supabase PostgreSQL!");

app.Run();
