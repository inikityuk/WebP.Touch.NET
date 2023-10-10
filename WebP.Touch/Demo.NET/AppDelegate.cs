﻿namespace Demo.NET;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	public override UIWindow? Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
		// create a new window instance based on the screen size
		Window = new UIWindow (UIScreen.MainScreen.Bounds);

		// create a UIViewController 
		Window.RootViewController = new DemoViewController();

		// make the window visible
		Window.MakeKeyAndVisible ();

		return true;
	}
}

