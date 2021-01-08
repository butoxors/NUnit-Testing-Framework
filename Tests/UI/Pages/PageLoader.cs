using Framework.Main.Core.Advices;

namespace Tests.Pages
{
    public static class PageLoader
    {
        public static IGoogleHomePage GetGoogleHomePage => StepAdvice<IGoogleHomePage>.Create(new GoogleHomePage());
        public static IGoogleResultPage GetGoogleResultPage => StepAdvice<IGoogleResultPage>.Create(new GoogleResultPage());
    }
}
