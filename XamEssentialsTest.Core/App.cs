using System;
using MvvmCross.ViewModels;
using XamEssentialsTest.Core.ViewModels;

namespace XamEssentialsTest.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            RegisterAppStart<LocationViewModel>();
        }
    }
}
