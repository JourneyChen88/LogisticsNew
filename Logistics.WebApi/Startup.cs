using Logistics.AppServices;
using Logistics.EF.Core;
using Logistics.EF.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Logistics.WebApi
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
            services.AddDbContext<LogisticsDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddMvc();

            ////集中注册服务
            foreach (var item in GetClassName("Logistics.AppServices"))
            {
                foreach (var typeArray in item.Value)
                {
                    if (typeArray.Name.EndsWith("AppService"))
                    {
                        services.AddScoped(typeArray, item.Key);
                    }
                   
                }
            }
            services.AddSignalR();
            //注册仓储
            services.AddScoped(typeof(IRepository<, >), typeof(Repository<, >));

            //services.AddScoped<IUserAppService, UserAppService>();
            //services.AddScoped<IOrderAppService, OrderAppService>();
            //services.AddScoped<IAddressAppService, AddressAppService>();
            //services.AddScoped<IAccountAppService, AccountAppService>();
            //services.AddScoped<IDataDicAppService, DataDicAppService>();
            //services.AddScoped<IDistributionAppService, DistributionAppService>();
            #region CORS
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder => builder.WithOrigins("http://*:5008").AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            });
            #endregion
            //注册swager生成器
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1.1.0",
                    Title = "Logistics_API_Doc",
                    Description = "物流后台接口"
                });
                //添加注释服务
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);//获取应用程序所在目录（绝对，不受工作目录影响，建议采用此方法获取路径）
                var xmlPath = Path.Combine(basePath, "Logistics.WebApi.xml");
                c.IncludeXmlComments(xmlPath);
                //添加对控制器的标签(描述)
               // c.DocumentFilter<SwaggerDocTag>();
              
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseDefaultFiles();

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/Files")),
                RequestPath = new PathString("/src")
            });
            app.UseSignalR(builder => builder.MapHub<Chat>("/Chat"));
            //{
            //    routes.MapHub<Chat>("/Chat");
            //});
            //app.UseSwaggerUi ( typeof ( Startup ).GetTypeInfo ( ).Assembly, settings =>
            //        {
            //            settings.GeneratorSettings.DefaultPropertyNameHandling = PropertyNameHandling.CamelCase;
            //            //settings.GeneratorSettings.DefaultUrlTemplate = "app/{controller}/{id}";
            //            settings.GeneratorSettings.IsAspNetCore = true;
            //        } );

            app.UseMvc();

            app.UseCors("AllowSpecificOrigin");
            app.UseSwagger();
            //启用中间件服务对swagger-ui，指定Swagger JSON终结点
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Logistics API V1");
            });
        }

        /// <summary>  
        /// 获取程序集中的实现类对应的多个接口
        /// </summary>  
        /// <param name="assemblyName">程序集</param>
        public Dictionary<Type, Type[]> GetClassName(string assemblyName)
        {
            if (!String.IsNullOrEmpty(assemblyName))
            {
                Assembly assembly = Assembly.Load(assemblyName);
                List<Type> ts = assembly.GetTypes().ToList();

                var result = new Dictionary<Type, Type[]>();
                foreach (var item in ts.Where(s => !s.IsInterface))
                {
                    var interfaceType = item.GetInterfaces();
                    result.Add(item, interfaceType);
                }
                return result;
            }
            return new Dictionary<Type, Type[]>();
        }
     
    }
}
