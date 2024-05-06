
using bem_mais_cuidado.API.Persistence;
using bem_mais_cuidado.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace bem_mais_cuidado.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //** 1� --> add AddSingleton para persistir em mem�ria
            //builder.Services.AddDbContext<MassoterapiaBemMaisCuidadoDbContext>(
            //    o => o.UseInMemoryDatabase("BemMaisCuidadoDb"));

            //** 1� --> com SQL Server
            var connectionString = builder.Configuration.GetConnectionString("MassoterapiaCs");
            builder.Services.AddDbContext<MassoterapiaBemMaisCuidadoDbContext>(
                o => o.UseSqlServer(connectionString));

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: "MyPolicy",
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:3000")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("MyPolicy");
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
