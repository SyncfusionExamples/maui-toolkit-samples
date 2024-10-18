namespace LoadMoreSample;

public class GalleryModel
{
    public GalleryModel(string imageString)
    {
        ImageName = imageString;
    }

    private string? _imageName;

    public string? ImageName
    {
        get { return _imageName; }
        set { _imageName = value; }
    }
}