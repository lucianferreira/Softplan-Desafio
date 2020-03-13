using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Softplan.Desafio.Servico.Classes;
using Softplan.Desafio.Servico.Interfaces;
using System.Globalization;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using System.IO;

namespace Softplan.Desafio.API
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
            services.AddControllers();
            services.AddCors();
            services.AddSingleton<ITaxaDeJuros, ServicoDeTaxaDeJuros>();
            services.AddSingleton<ICalculoDeJuros, ServicoDeCalculoDeJuros>();
            services.AddSingleton<IShowMeTheCode, ServicoDoShowMeTheCode>();

            var cultureInfo = new CultureInfo("pt-BR");
            cultureInfo.NumberFormat.CurrencySymbol = "R$";

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Desafio Softplan API",
                    Description = "Desafio Softplan API- Cálculo de juros",
                    Contact = new OpenApiContact
                    {
                        Name = "Lucian Ferreira",
                        Email = "lucianpferreira@gmail.com",
                        Url = new Uri("https://www.linkedin.com/in/lucian-ferreira"),
                    }
                });

                var caminhoDaAplicacao = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var nomeDaAplicacao = Path.Combine(AppContext.BaseDirectory, caminhoDaAplicacao);
                c.IncludeXmlComments(nomeDaAplicacao);

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseCors(option => option.AllowAnyOrigin());
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Desafio Softplan API");
            });
        }
    }
}
