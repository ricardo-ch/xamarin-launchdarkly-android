using Android.App;
using Android.Widget;
using Android.OS;
using Com.Launchdarkly.Android;

namespace Ricardo.LaunchDarkly.Android.Sample
{
    [Activity(Label = "Ricardo.LaunchDarkly.Android.Sample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            LDConfig ldConfig = new LDConfig.Builder().SetMobileKey("YOUR_MOBILE_KEY").Build();
			LDUser user = new LDUser.Builder("user key").Email("fake@example.com").Build();

			// NOTE: This method blocks for up to 5 seconds. See Javadoc or http://docs.launchdarkly.com/docs/android-sdk-reference
			// for nonblocking options.
            LDClient ldClient = LDClient.Init(Application, ldConfig, user, 5);
        }
    }
}

