using Framework.Main.Core.Advices;

namespace Tests.Pages
{
    public static class PageLoader
    {
        public static IGoogleHomePage GetGoogleHomePage => Advice<IGoogleHomePage>.Create(new GoogleHomePage());
        public static IGoogleResultPage GetGoogleResultPage => Advice<IGoogleResultPage>.Create(new GoogleResultPage());
    }
}
