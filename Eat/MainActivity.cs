using Android.App;
using Android.Widget;
using Android.OS;

namespace Eat
{
    [Activity(Label = "Eat", MainLauncher = true, Icon = "@drawable/icon" , Theme = "@android:style/Theme.DeviceDefault.NoActionBar")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            Button btnenter = FindViewById<Button>(Resource.Id.btnEnter);
            btnenter.Click += delegate
            {
                StartActivity(typeof(BookActivity));
            };
        }
        
    }
}

