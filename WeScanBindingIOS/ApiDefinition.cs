using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace NativeLibrary
{
    // @interface HomeViewController : UIViewController
    [BaseType(typeof(UIViewController), Name = "_TtC6WeScan18HomeViewController")]
    interface HomeViewController
    {
        
    }

    // @interface ImageScannerController : UINavigationController
    [BaseType(typeof(UINavigationController), Name = "_TtC6WeScan22ImageScannerController")]
    interface ImageScannerController
    {

        // @property (readonly, nonatomic) UIInterfaceOrientationMask supportedInterfaceOrientations;
        [Export("supportedInterfaceOrientations")]
        UIInterfaceOrientationMask SupportedInterfaceOrientations { get; }
    }
}

