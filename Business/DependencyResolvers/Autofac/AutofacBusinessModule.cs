using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Helper.FileHelper;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HastalikManager>().As<IHastalikService>().SingleInstance();
            builder.RegisterType<EfHastalikDal>().As<IHastalikDal>().SingleInstance();

            builder.RegisterType<AsiManager>().As<IAsiService>().SingleInstance();
            builder.RegisterType<EfAsiDal>().As<IAsiDal>().SingleInstance();

            builder.RegisterType<AsiIcerikManager>().As<IAsiIcerikService>().SingleInstance();
            builder.RegisterType<EfAsiIcerikDal>().As<IAsiIcerikDal>().SingleInstance();

            builder.RegisterType<AnasayfaManager>().As<IAnasayfaService>().SingleInstance();
            builder.RegisterType<EfAnasayfaDal>().As<IAnasayfaDal>().SingleInstance();

            builder.RegisterType<SoruManager>().As<ISoruService>().SingleInstance();
            builder.RegisterType<EfSoruDal>().As<ISoruDal>().SingleInstance();


            builder.RegisterType<SoruImageManager>().As<ISoruImageService>();
            builder.RegisterType<EfSoruImageDal>().As<ISoruImageDal>().SingleInstance();

            builder.RegisterType<CevapManager>().As<ICevapService>();
            builder.RegisterType<EfCevapDal>().As<ICevapDal>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
