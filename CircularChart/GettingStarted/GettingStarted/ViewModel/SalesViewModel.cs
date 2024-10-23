namespace GettingStarted
{
    public class SalesViewModel
    {
        public List<SalesModel> Data { get; set; }

        public SalesViewModel()
        {
            Data = new List<SalesModel>()
        {
            new SalesModel(){Product = "iPad", SalesRate = 70},
            new SalesModel(){Product = "iPhone", SalesRate = 65},
            new SalesModel(){Product = "MacBook", SalesRate = 60},
            new SalesModel(){Product = "Mac", SalesRate = 55},
            new SalesModel(){Product = "Others", SalesRate = 50},
        };
        }
    }
}