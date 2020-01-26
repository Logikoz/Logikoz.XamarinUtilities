using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Logikoz.XamarinUtilities.Utilities
{
    public class PopPushViewUtil
    {
        public static async Task PushAsync(INavigation navigation, Page page, bool animated = false) => await navigation.PushAsync(page, animated);

        public static void Pop<T>(INavigation navigation)
        {
            IReadOnlyList<Page> pages = navigation.NavigationStack;
            pages.ForEach(page =>
            {
                if (page is T)
                    navigation.RemovePage(page);
            });
        }

        public static async Task PushModalAsync(Page page, bool animated = false) => await Application.Current.MainPage.Navigation.PushModalAsync(page, animated);

        public static void PopModal<T>(bool isAnimated = false)
        {
            INavigation navigation = Application.Current.MainPage.Navigation;
            IReadOnlyList<Page> pages = navigation.ModalStack;
            pages.ForEach(async page =>
            {
                if (page is T)
                    await navigation.PopModalAsync(isAnimated);
            });
        }

        public static void PopNavModal<T>(bool isAnimated = false)
        {
            INavigation navigation = Application.Current.MainPage.Navigation;
            IReadOnlyList<Page> pages = navigation.ModalStack;
            pages.ForEach(async page =>
            {
                if ((page as NavigationPage).RootPage is T)
                    await navigation.PopModalAsync(isAnimated);
            });
        }
    }
}