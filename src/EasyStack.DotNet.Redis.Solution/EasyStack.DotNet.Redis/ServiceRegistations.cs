using EasyStack.DotNet.Redis.Abstractions;
using EasyStack.DotNet.Redis.Implementations;

using Microsoft.Extensions.DependencyInjection;

namespace EasyStack.DotNet.Redis
{
    public static class ServiceRegistations
    {
        public static void RegisterEasyStackRedisServices(IServiceCollection services)
        {
            services.AddTransient<IRedisService, RedisService>();
        }

    }
}
