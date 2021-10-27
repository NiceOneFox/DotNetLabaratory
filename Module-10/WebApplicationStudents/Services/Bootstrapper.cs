﻿using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using BusinessLogic.Mappers;
using DatabaseAccess;
using BusinessLogic.ServiceInterfaces;
using BusinessLogic.Services;

namespace BusinessLogic
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services, string connectionString)
        {
            return services
                .AddScoped<IStudentService, StudentService>()
                .AddScoped<ILectorService, LectorService>()
                .AddScoped<ILectureService, LectureService>()    
                .AddScoped<IHomeworkService, HomeworkService>()
                .AddAutoMapper(typeof(MapperBl))
                //.AddAutoMapper(typeof(MapperMark))
                .AddDataAccess(connectionString);
        }
    }
}
