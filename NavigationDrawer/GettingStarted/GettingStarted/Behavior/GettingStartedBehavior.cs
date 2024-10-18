namespace GettingStarted
{
    using Syncfusion.Maui.Toolkit.NavigationDrawer;

    /// <summary>
    /// Getting started behavior class.
    /// </summary>
    public class GettingStartedBehavior : Behavior<ContentPage>
    {
        /// <summary>
        /// Navigation drawer instance.
        /// </summary>
        private SfNavigationDrawer? navigationDrawer;

        /// <summary>
        /// Image button instance.
        /// </summary>
        private ImageButton? imageButton;

        /// <summary>
        /// List view instance.
        /// </summary>
        private ListView? listView;

        /// <summary>
        /// Label instance.
        /// </summary>
        private Label? contentLabel;

        /// <summary>
        /// Instance of the list view model.
        /// </summary>
        private ListViewModel listViewModel = new ListViewModel();

        /// <summary>
        /// Called when the behavior is attached to a content page.
        /// </summary>
        /// <param name="bindable">The content page.</param>
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.Appearing += Bindable_Appearing;
        }

        /// <summary>
        /// Handles the appearing event of the content page.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void Bindable_Appearing(object? sender, EventArgs e)
        {
            var page = sender as ContentPage;
            if (page == null)
            {
                return;
            }

            this.navigationDrawer = page.Content.FindByName<SfNavigationDrawer>("navigationDrawer");
            this.imageButton = page.Content.FindByName<ImageButton>("hamburgerButton");
            this.listView = page.Content.FindByName<ListView>("listView");
            this.contentLabel = page.Content.FindByName<Label>("contentLabel");
            if (this.imageButton != null)
            {
                this.imageButton.Clicked += ImageButton_Clicked;
            }

            if (this.listView != null)
            {
                this.listView.ItemsSource = listViewModel.MenuItems;
                this.listView.ItemSelected += ListView_ItemSelected;
            }
        }

        /// <summary>
        /// Handles the item selected event of the list view.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ListView_ItemSelected(object? sender, SelectedItemChangedEventArgs e)
        {
            if (this.navigationDrawer == null || this.contentLabel == null)
            {
                return;
            }

            if (e.SelectedItem.ToString() == "Home")
            {
                this.contentLabel.Text = "Home";
            }
            else if (e.SelectedItem.ToString() == "Profile")
            {
                this.contentLabel.Text = "Profile";
            }
            else if (e.SelectedItem.ToString() == "Inbox")
            {
                this.contentLabel.Text = "Inbox";
            }
            else if (e.SelectedItem.ToString() == "Outbox")
            {
                this.contentLabel.Text = "Outbox";
            }
            else if (e.SelectedItem.ToString() == "Sent")
            {
                this.contentLabel.Text = "Sent";
            }
            else if (e.SelectedItem.ToString() == "Draft")
            {
                this.contentLabel.Text = "The folder is empty";
            }

            this.navigationDrawer.ToggleDrawer();
        }

        /// <summary>
        /// Handles the clicked event of the hamburger button.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ImageButton_Clicked(object? sender, EventArgs e)
        {
            this.navigationDrawer?.ToggleDrawer();
        }

        /// <summary>
        /// Called when the behavior is detaching from a content page.
        /// </summary>
        /// <param name="bindable">The content page.</param>
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.imageButton != null)
            {
                this.imageButton.Clicked -= ImageButton_Clicked;
                this.imageButton = null;
            }

            if (this.listView != null)
            {
                this.listView.ItemSelected += ListView_ItemSelected;
                this.listView = null;
            }
        }
    }
}
