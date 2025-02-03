using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProyectUTP.Application.Contracts.Identity;
using ProyectUTP.Application.Models.Identity;
using ProyectUTP.Infrastructure.Services.EServiceTipoCultivo;
using ProyectUTP.Infrastructure.Services.EserviceUbicacion;
using ProyectUTP.Infrastructure.Services.FunctionQuery;
using ProyectUTP.Infrastructure.Services.FunctionResponse;
using ProyectUTP.Infrastructure.Services.TokenService;
using System.Text;

namespace ProyectUTP.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            services.AddSingleton(sp => sp.GetRequiredService<IOptions<JwtSettings>>().Value);

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("ConnectionStringServer"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

           services.AddTransient<ITipoCultivo, EServiceTipoCultivo>();
           services.AddTransient<IUbicacion, EserviceUbicacion>();
           services.AddTransient<IToken, EToken>();

           services.AddScoped<FunctionResponse>();
           services.AddScoped<AddQuerys>();
           services.AddScoped<GetQuerys>();
           services.AddScoped<UpdateRegister>();
           services.AddScoped<TokenService>();

            //services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidIssuer = configuration["JwtSettings:Issuer"],
                    ValidAudience = configuration["JwtSettings:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]))
                };

            });

            return services;
        }
    }
}
