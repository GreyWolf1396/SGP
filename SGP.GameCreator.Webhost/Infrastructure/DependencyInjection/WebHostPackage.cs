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
            container.Register<IGameService, GameService>();
        }
    }

}
