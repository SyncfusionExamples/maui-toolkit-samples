namespace LoadMoreSample;

public class ImageModel
{
    public ImageModel(string imageString)
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