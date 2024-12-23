namespace BottomSheetFoodOrder
{
    public partial class MainPage : ContentPage
    {
#if ANDROID || IOS
        GettingStartedMobile gettingStartedMobile;
#elif WINDOWS || MACCATALYST
    GettingStartedDesktop gettingStartedDesktop;
#endif

        public MainPage()
        {
            InitializeComponent();

#if ANDROID || IOS
            gettingStartedMobile = new GettingStartedMobile();
            this.Content = gettingStartedMobile.Content;
#elif WINDOWS || MACCATALYST
        gettingStartedDesktop = new GettingStartedDesktop();
        this.Content = gettingStartedDesktop.Content;
#endif
        }


    }

}
