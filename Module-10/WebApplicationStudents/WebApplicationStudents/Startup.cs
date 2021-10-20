using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using AutoMapper;
using DatabaseAccess;
using Microsoft.EntityFrameworkCore;
using WebApplicationStudents.Validation;

namespace WebApplicationStudents
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

            services.AddFluentValidation(fv =>
            {
                fv.RegisterValidatorsFromAssemblyContaining<LectorValidation>();
                fv.RegisterValidatorsFromAssemblyContaining<StudentValidation>();
                fv.RegisterValidatorsFromAssemblyContaining<LectureValidation>();
                fv.RegisterValidatorsFromAssemblyContaining<HomeworkValidation>();
                fv.RegisterValidatorsFromAssemblyContaining<MarkValidation>();
            });

           //services.AddMappers();

            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddAutoMapper(typeof(Startup));

            services.AddBusinessLogic(Configuration.GetConnectionString("CourseDb"));

            services.AddDataAccess(Configuration.GetConnectionString("CourseDb"));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApplicationStudents", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApplicationStudents v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
