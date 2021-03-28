using SGP.DAL;
using SGP.DAL.Interfaces;
using SGP.GameCreator.Webhost.Services;
using SGP.GameCreator.Webhost.Services.Interfaces;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace SGP.GameCreator.Webhost.Infrastructure.DependencyInjection
{
    public class WebHostPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            RegisterBLL(container);
            RegisterDAL(container);            
        }

        public void RegisterBLL(Container container)
        {
            container.Register<IGameService, GameService>();
        }

        public void RegisterDAL(Container container)
        {
            container.Register(
                typeof(IRepository<>),
                typeof(InMemoryRepository<>),
                Lifestyle.Transient);
        }
    }
}
