using AndroidLib1;
using AndroidLib2;

namespace AndroidApp1
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var baseClass = new BaseClass();
            var derivedClass1 = new DerivedClass1();
            var derivedClass2 = new DerivedClass2();
            var derivedClass3 = new DerivedClass3();

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }
}