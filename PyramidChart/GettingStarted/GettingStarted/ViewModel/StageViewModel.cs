﻿namespace GettingStarted
{
    public class StageViewModel
    {
        public List<StageModel> Data { get; set; }

        public StageViewModel()
        {
            Data = new List<StageModel>()
            {
                new StageModel(){Name = "Stage A", Value=12},
                new StageModel(){Name = "Stage B", Value=21},
                new StageModel(){Name = "Stage C", Value=29},
                new StageModel(){Name = "Stage D", Value=37},
            };
        }
    }
}