using Microsoft.Extensions.DependencyInjection;
using QueryPortalRepositories;
using QueryPortalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Query_Portal
{
    public static class ServiceInjection
    {
        public static void ServiceRegistation(this IServiceCollection Services)
        {
            Services.AddScoped<ILoginServices, LoginServices>();
            Services.AddScoped<ILoginRepository, LoginRepository>();
        }
    }
}
