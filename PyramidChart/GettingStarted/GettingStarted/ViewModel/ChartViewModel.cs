namespace GettingStarted
{
    public class ChartViewModel
    {
        public List<Stage> Data { get; set; }

        public ChartViewModel()
        {
            Data = new List<Stage>()
            {
                new Stage(){Name = "Stage A", Value=12},
                new Stage(){Name = "Stage B", Value=21},
                new Stage(){Name = "Stage C", Value=29},
                new Stage(){Name = "Stage D", Value=37},
            };
        }
    }
}