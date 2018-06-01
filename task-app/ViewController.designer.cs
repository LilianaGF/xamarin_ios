// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace taskapp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonNew { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonShowAll { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView TextViewDoing { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView TextViewDone { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView TextViewSummary { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView TextViewToDo { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonNew != null) {
                ButtonNew.Dispose ();
                ButtonNew = null;
            }

            if (ButtonShowAll != null) {
                ButtonShowAll.Dispose ();
                ButtonShowAll = null;
            }

            if (TextViewDoing != null) {
                TextViewDoing.Dispose ();
                TextViewDoing = null;
            }

            if (TextViewDone != null) {
                TextViewDone.Dispose ();
                TextViewDone = null;
            }

            if (TextViewSummary != null) {
                TextViewSummary.Dispose ();
                TextViewSummary = null;
            }

            if (TextViewToDo != null) {
                TextViewToDo.Dispose ();
                TextViewToDo = null;
            }
        }
    }
}