using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Company.API.Business.Abstract;
using Company.API.Business.Concrete;
using Company.API.DataAccess.Abstract;
using Company.API.DataAccess.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBussinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CityService>().As<ICityService>().SingleInstance();
            builder.RegisterType<CityDal>().As<ICityDal>().SingleInstance();

            builder.RegisterType<CountryService>().As<ICountryService>().SingleInstance();
            builder.RegisterType<CountryDal>().As<ICountryDal>().SingleInstance();



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
