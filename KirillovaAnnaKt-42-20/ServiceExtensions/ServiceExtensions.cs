using KirillovaAnnaKt_42_20.Interfaces.StudentsInterfaces;

namespace KirillovaAnnaKt_42_20.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();

            return services;
        }
    }
}