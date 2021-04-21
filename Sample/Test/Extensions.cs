using System;
using Foundation;
using System;
using UIKit;
using CoreFoundation;
using System.Linq;

namespace Test
{
    public static class Extensions
    {
        public static UINavigationController GetRootNavigationController()
            => UIApplication.SharedApplication.KeyWindow.RootViewController.GetNavigationController();

        public static UINavigationController GetNavigationController(this UIViewController controller)
        {
            if (controller is UINavigationController nc)
                return nc;

            return controller?.ChildViewControllers
                .Select(GetNavigationController)
                .FirstOrDefault(nc2 => nc2 != null);
        }

        //Bonus: get the UIViewController of any UIView
        public static UIViewController ParentViewController(this UIResponder view)
             => (view.NextResponder as UIViewController) ?? view.NextResponder?.ParentViewController();
    }
}
