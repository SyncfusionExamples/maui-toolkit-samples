namespace GettingStarted
{
    public class ViewModel
    {
        public List<Sales> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Sales>()
        {
            new Sales(){Product = "iPad", SalesRate = 70},
            new Sales(){Product = "iPhone", SalesRate = 65},
            new Sales(){Product = "MacBook", SalesRate = 60},
            new Sales(){Product = "Mac", SalesRate = 55},
            new Sales(){Product = "Others", SalesRate = 50},
        };
        }
    }
}