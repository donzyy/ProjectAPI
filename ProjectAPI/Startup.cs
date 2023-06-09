using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ProjectAPI.DatabaseContext;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ProjectAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //This Code contains the protocol conntrols used by the API's to communicate with a front-end
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });

            //This Code contains the protocol conntrols used by the API's to communicate with a front-end

            //This code handles the JWT token
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "your-issuer",
                    ValidAudience = "your-audience",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your-secret-key"))
                };
            });
            //This code handles the JWT token

            //Database context connection for In-Memory
            //services.AddDbContext<Database>(options => options.UseInMemoryDatabase("ProjectDatabase"));
            //Database context connection for In-Memory

            //This connects connects and creates the database
            services.AddDbContext<Database>(options => options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnectionString")));
            //This connects connects and creates the database

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProjectAPI", Version = "v1" });

                 // Define the security scheme
                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Description = "JWT Authorization header using the Bearer scheme.",
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT"
                };

                // Add the security scheme to the Swagger UI
                c.AddSecurityDefinition("Bearer", securityScheme);

                // Add the security requirement to the Swagger UI
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        securityScheme,
                        new List<string>()
                    }
                });
           
           
            }); 
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjectAPI v1"));
            }

            app.UseHttpsRedirection();

            //This code enables the Cors handle Http request to the api
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });

            //This code enables the Cors handle Http request to the api

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
