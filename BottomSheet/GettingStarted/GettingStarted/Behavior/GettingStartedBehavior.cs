namespace GettingStarted
{
    using Syncfusion.Maui.Toolkit.BottomSheet;

    /// <summary>
    /// Getting started behavior class.
    /// </summary>
    public class GettingStartedBehavior : Behavior<ContentPage>
    {
        /// <summary>
        /// Bottom sheet instance.
        /// </summary>
        SfBottomSheet? bottomSheet;

        /// <summary>
        /// Button instance.
        /// </summary>
        Button? openBottomSheet;

        /// <summary>
        /// Called when the behavior is attached to a content page.
        /// </summary>
        /// <param name="bindable">The content page.</param>
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            bottomSheet = bindable.FindByName<SfBottomSheet>("bottomSheet");
            openBottomSheet = bindable.FindByName<Button>("openBottomSheet");
            if (openBottomSheet is not null)
            {
                openBottomSheet.Clicked += OnOpenBottomSheetClicked;
            }
        }

        /// <summary>
        /// Handles the clicked event of the openBottomSheet button.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnOpenBottomSheetClicked(object? sender, EventArgs e)
        {
            if (bottomSheet is not null)
            {
                bottomSheet.Show();
            }
        }

        /// <summary>
        /// Called when the behavior is detaching from a content page.
        /// </summary>
        /// <param name="bindable">The content page.</param>
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (openBottomSheet is not null)
            {
                openBottomSheet.Clicked -= OnOpenBottomSheetClicked;
                openBottomSheet = null;
            }
        }
    }
}
