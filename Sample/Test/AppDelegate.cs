using Foundation;
using UIKit;

namespace Test
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIResponder, IUIApplicationDelegate
    {
        UINavigationController navController;

        [Export("window")]
        public UIWindow Window { get; set; }

        [Export("application:didFinishLaunchingWithOptions:")]
        public bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            //Window = new UIWindow(UIScreen.MainScreen.Bounds);
            //navController = new UINavigationController(new UIViewController());
            //Window.RootViewController = navController;
            //Window.MakeKeyAndVisible();
            //navController = Window.RootViewController;

            //// Override point for customization after application launch.
            //// If not required for your application you can safely delete this method
            ////navController = new UINavigationController(Window.RootViewController);
            ////Window = new UIWindow(UIScreen.MainScreen.Bounds);
            ////Window.RootViewController = navController;
            ////Window.MakeKeyAndVisible();

            //Binding.ZDKChat.InitializeWithAccountKey("lfZ0FzNxlBjD6OYWFVA30Ir3aOP3574T", "5edba4bb00c08337fd9c7332998e75b7365a49e9a29ca971",
            //    CoreFoundation.DispatchQueue.GetGlobalQueue(CoreFoundation.DispatchQueuePriority.Default));
            //NSError error = null;
            //NSError engineError = null;

            //Binding.ZDKConfiguration messagingConfig = new Binding.ZDKMessagingConfiguration();

            //var configuration = new Binding.ZDKChatConfiguration();

            //Binding.ZDKEngine engine = Binding.ZDKChatEngine.EngineAndReturnError(out engineError);

            //Binding.ZDKEngine[] engines = { engine };

            //Binding.ZDKConfiguration[] configurations = { messagingConfig, configuration };

            //UIViewController uIViewController = Binding.ZDKMessaging.Instance.BuildUIWithEngines(engines, configurations, out error);

            //navController.PushViewController(uIViewController, true);
            return true;
        }
        

        // UISceneSession Lifecycle

        [Export("application:configurationForConnectingSceneSession:options:")]
        public UISceneConfiguration GetConfiguration(UIApplication application, UISceneSession connectingSceneSession, UISceneConnectionOptions options)
        {
            // Called when a new scene session is being created.
            // Use this method to select a configuration to create the new scene with.
            return UISceneConfiguration.Create("Default Configuration", connectingSceneSession.Role);
        }

        

        [Export("application:didDiscardSceneSessions:")]
        public void DidDiscardSceneSessions(UIApplication application, NSSet<UISceneSession> sceneSessions)
        {
            // Called when the user discards a scene session.
            // If any sessions were discarded while the application was not running, this will be called shortly after `FinishedLaunching`.
            // Use this method to release any resources that were specific to the discarded scenes, as they will not return.
        }
    }
}

