namespace VirtualizationSample;

public class GalleryViewModel
{
    public GalleryViewModel()
    {
        for(int i = 0; i < 50; i++)
        {
            ImageCollection.Add(new ImageModel("austria.jpg"));
            ImageCollection.Add(new ImageModel("india.jpg"));
            ImageCollection.Add(new ImageModel("dubai.jpg"));
            ImageCollection.Add(new ImageModel("canada.jpg"));
            ImageCollection.Add(new ImageModel("kremlin.jpg"));
            ImageCollection.Add(new ImageModel("colombia.jpg"));
            ImageCollection.Add(new ImageModel("france.jpg"));
            ImageCollection.Add(new ImageModel("germany.jpg"));
            ImageCollection.Add(new ImageModel("italy.jpg"));
        }
    }
    private List<ImageModel> imageCollection = new List<ImageModel>();
    public List<ImageModel> ImageCollection
    {
        get { return imageCollection; }
        set { imageCollection = value; }
    }
}