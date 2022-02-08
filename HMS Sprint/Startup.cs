using HMS_BAL.Services;
using HMS_DAL.Data;
using HMS_DAL.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMS_Sprint
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
            string connectionStr = Configuration.GetConnectionString("SqlConnection");
            services.AddDbContext<HMSDbContext>(options => options.UseSqlServer(connectionStr));
            services.AddControllers();
            services.AddTransient<IPatientRepository, PatientRepository>();
            services.AddTransient<PatientServices, PatientServices>();
            services.AddTransient<IDoctorRepository, DoctorRepository>();
            services.AddTransient<DoctorServices, DoctorServices>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<EmployeeServices, EmployeeServices>();
            services.AddTransient<IReceptionRepository, ReceptionRepository>();
            services.AddTransient<ReceptionServices, ReceptionServices>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
