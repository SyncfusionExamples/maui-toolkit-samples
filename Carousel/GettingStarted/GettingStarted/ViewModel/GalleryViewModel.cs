namespace GettingStarted;

public class GalleryViewModel
{
    public GalleryViewModel()
    {
        ImageCollection.Add(new GalleryModel("austria.jpg"));
        ImageCollection.Add(new GalleryModel("india.jpg"));
        ImageCollection.Add(new GalleryModel("dubai.jpg"));
        ImageCollection.Add(new GalleryModel("canada.jpg"));
        ImageCollection.Add(new GalleryModel("kremlin.jpg"));
        ImageCollection.Add(new GalleryModel("colombia.jpg"));
        ImageCollection.Add(new GalleryModel("france.jpg"));
        ImageCollection.Add(new GalleryModel("germany.jpg"));
        ImageCollection.Add(new GalleryModel("italy.jpg"));
    }
    private List<GalleryModel> imageCollection = new List<GalleryModel>();
    public List<GalleryModel> ImageCollection
    {
        get { return imageCollection; }
        set { imageCollection = value; }
    }
}