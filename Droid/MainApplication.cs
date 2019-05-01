using System;
using Android.App;
using Android.Runtime;
using Core;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace XamEssentialsTest.Droid
{
    [Application]
    public class MainApplication : MvxAppCompatApplication<MvxAppCompatSetup<App>, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}
