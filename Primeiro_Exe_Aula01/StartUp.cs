using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Primeiro_Exe_Aula01
{
    public class StartUp
    {
        int count = 0;
        public void Configure(IApplicationBuilder app)
        {
            //app.Use(Contagem);
            //app.Run(RespondeAoMundo);
            app.UseMvcWithDefaultRoute();
        }

        public Task Contagem(HttpContext context, Func<Task> next)
        {
            count++;
            return next.Invoke();           
        }

        private Task RespondeAoMundo(HttpContext context)
        {
            context.Response.WriteAsync(context.Request.Path.ToString());
            
            return context.Response.WriteAsync("Hello Word!" + count);
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
    }
}