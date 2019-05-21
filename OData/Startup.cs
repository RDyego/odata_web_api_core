using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;
using OData.Contexto;
using OData.Modelo;

namespace OData
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
            services.AddOData();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<Context>(options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc(
                b =>
                {
                    b.MapODataServiceRoute("aluno", "odata", GetEdmModelAluno());
                    b.MapODataServiceRoute("cadeiras", "odata", GetEdmModelCadeiras());
                    b.MapODataServiceRoute("curso", "odata", GetEdmModelCurso());
                    b.MapODataServiceRoute("matricula", "odata", GetEdmModelMatricula());
                    b.MapODataServiceRoute("situacao", "odata", GetEdmModelSituacao());
                    b.MapODataServiceRoute("usuario", "odata", GetEdmModelUsuario());
                });
        }

        public static IEdmModel GetEdmModelSituacao()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            // Habilita funções OData como $filter, $select e etc..
            builder.EntitySet<Situacao>(nameof(Situacao))
                   .EntityType
                   .Filter()
                   .Count()
                   .Expand()
                   .OrderBy()
                   .Page()
                   .Select();
            return builder.GetEdmModel();
        }

        public static IEdmModel GetEdmModelCurso()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            // Habilita funções OData como $filter, $select e etc..
            builder.EntitySet<Curso>(nameof(Curso))
                   .EntityType
                   .Filter()
                   .Count()
                   .Expand()
                   .OrderBy()
                   .Page()
                   .Select();
            return builder.GetEdmModel();
        }

        public static IEdmModel GetEdmModelAluno()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            // Habilita funções OData como $filter, $select e etc..
            builder.EntitySet<Aluno>(nameof(Aluno))
                   .EntityType
                   .Filter()
                   .Count()
                   .Expand()
                   .OrderBy()
                   .Page()
                   .Select();
            return builder.GetEdmModel();
        }

        public static IEdmModel GetEdmModelMatricula()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            // Habilita funções OData como $filter, $select e etc..
            builder.EntitySet<Matricula>(nameof(Matricula))
                   .EntityType
                   .Filter()
                   .Count()
                   .Expand()
                   .OrderBy()
                   .Page()
                   .Select();
            return builder.GetEdmModel();
        }

        public static IEdmModel GetEdmModelCadeiras()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            // Habilita funções OData como $filter, $select e etc..
            builder.EntitySet<Cadeiras>(nameof(Cadeiras))
                   .EntityType
                   .Filter()
                   .Count()
                   .Expand()
                   .OrderBy()
                   .Page()
                   .Select();
            return builder.GetEdmModel();
        }

        public static IEdmModel GetEdmModelUsuario()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            // Habilita funções OData como $filter, $select e etc..
            builder.EntitySet<Usuario>(nameof(Usuario))
                   .EntityType
                   .Filter()
                   .Count()
                   .Expand()
                   .OrderBy()
                   .Page()
                   .Select();
            return builder.GetEdmModel();
        }
    }
}
