namespace GettingStarted
{
    /// <summary>
    /// View model class for providing menu item data.
    /// </summary>
    public class ListViewModel
    {
        /// <summary>
        /// Gets or sets the collection of menu items.
        /// </summary>
        public List<string> MenuItems { get; set; }

        /// <summary>
        /// Initializes a new instance of the ListViewModel class.
        /// </summary>
        public ListViewModel()
        {
            MenuItems = new List<string>
            {
                "Home", "Profile", "Inbox", "Outbox", "Sent", "Draft"
            };
        }
    }
}