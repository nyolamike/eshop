using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eshop.Hubs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace eshop
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
            ///
            /// Adopted from 
            /// https://auth0.com/blog/securing-asp-dot-net-core-2-applications-with-jwts/
            ///
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true, //validate server that created the token
                        ValidateAudience = true, //ensure that the recepient of the token is authorised to receive it
                        ValidateLifetime = true, //check that the tokken is not expired and that the sigining key of the issuer is valid
                        ValidateIssuerSigningKey = true, //verify that the key used to validate the incoming key is part of a list of trusted keys
                        ValidIssuer = Configuration["Jwt:Issuer"],
                        ValidAudience = Configuration["Jwt:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                    };
                });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //nexmo
            //Refs.NexmoClient = new Client(creds: new Nexmo.Api.Request.Credentials
            //{
            //    ApiKey = Configuration["Nexmo:Key"],
            //    ApiSecret = Configuration["Nexmo:Secret"],
            //});


            //signalr
            services.AddSignalR();


            //actor system
            //var actorSystem = ActorSystem.Create("EshopActorSystem");
            //actorSystem.ActorOf(BaseActor.Props(), BaseActor.I);
            //services.AddSingleton(typeof(ActorSystem), (serviceProvider) => actorSystem);

            //should be the last invocation here
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader()
                      .AllowCredentials()
                .Build());
            });
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
            app.UseStaticFiles();
            app.UseSignalR(routes =>
            {
                routes.MapHub<SignupHub>("/SignupHub");
            });


            app.UseMvc();

            app.UseCors("CorsPolicy");

            //var _hub = app.ApplicationServices.GetService<IHubContext<SignupHub>>();
            //var _actorSystem = app.ApplicationServices.GetService<ActorSystem>();
            //var baseActorRef = _actorSystem.ActorSelection(BaseActor.ME);
            //baseActorRef.Tell(new SetSignupHub_(_hub));
        }
    }
}
