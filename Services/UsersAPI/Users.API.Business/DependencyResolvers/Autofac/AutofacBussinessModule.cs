using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Microsoft.AspNetCore.Http;
using Users.API.Business.Abstract;
using Users.API.Business.Concrete;
using Users.API.DataAccess.Abstract;
using Users.API.DataAccess.Concrete;

namespace Users.API.Business.DependencyResolvers.Autofac
{
    public class AutofacBussinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserService>().As<IUserService>().SingleInstance();
            builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<UserLogService>().As<IUserLogService>().SingleInstance();
            builder.RegisterType<UserLogDal>().As<IUserLogDal>().SingleInstance();



            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
