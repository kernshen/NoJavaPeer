#if ANDROID
using MauiLib1;
using MauiLib2;
#endif

namespace MauiApp1
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            MainPage = new AppShell();

#if ANDROID
            var baseClass = new BaseClass();
            var derivedClass1 = new DerivedClass1();
            var derivedClass2 = new DerivedClass2();
#endif
        }
    }
}
