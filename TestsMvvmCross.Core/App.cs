using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TestsMvvmCross.Core.ViewModels;

namespace TestsMvvmCross.Core
{
    public class App : MvxApplication 
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes()
               .EndingWith("Service")
               .AsInterfaces()
               .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
