using Core.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

[assembly: MvxNavigation(typeof(DeepLinkViewModel), @"mvvmcross-test://deeplink/\?testid=(?<testid>[0-9]{1,3})$")]
namespace Core.ViewModels
{
    public class DeepLinkViewModel : MvxViewModel
    {
        private int _initCount;

        public DeepLinkViewModel()
        {
            _testText = "Deep Link View";
        }

        private string _testText;
        public string TestText
        {
            get
            {
                return _testText;
            }
            set
            {
                _testText = value;
                RaisePropertyChanged(() => TestText);
            }
        }

        public void Init(int testid)
        {
            _initCount++;
            TestText = $"Init() has been called {_initCount} times";
        }
    }
}
