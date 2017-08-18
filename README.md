LaunchDarkly SDK for Xamarin
================

Xamarin.Android binding library for [Launchdarkly SDK](https://github.com/launchdarkly/android-client).

For more information on LaunchDarkly see the Android SDK [reference](https://docs.launchdarkly.com/v2.0/docs/android-sdk-reference).

This binding library is available on [Nuget](https://www.nuget.org/packages/Ricardo.LaunchDarkly.Android/).

Documentation
=============

    LDConfig ldConfig = new LDConfig.Builder().SetMobileKey("YOUR_MOBILE_KEY").Build();
		LDUser user = new LDUser.Builder("user key").Email("fake@example.com").Build();

		// NOTE: This method blocks for up to 5 seconds. See Javadoc or http://docs.launchdarkly.com/docs/android-sdk-reference
		// for nonblocking options.
    LDClient ldClient = LDClient.Init(Application, ldConfig, user, 5);


See the Ricardo.LaunchDarkly.Android.Sample app.

License
=======

- xamarin-launchdarkly-android is licensed under [MIT](http://opensource.org/licenses/mit-license)
