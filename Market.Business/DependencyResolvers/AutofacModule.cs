using Autofac;
using Market.Business.Services;
using MarketMicroservice.Business.Services;

namespace Business.DependencyResolvers
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerDependency();
            builder.RegisterType<SaleService>().As<ISaleService>().InstancePerDependency();

        }
    }
}
