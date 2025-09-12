using GettingStarted.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted.ViewModel
{
    public class SparkDataViewModel
    {
        public List<SparkDataModel> Data { get; set; }

        public SparkDataViewModel()
        {
            Data = new List<SparkDataModel>
            {
                new SparkDataModel(){ Value = 5000},
                new SparkDataModel(){ Value = 9000},
                new SparkDataModel(){ Value = 5000},
                new SparkDataModel(){ Value = 0},
                new SparkDataModel(){ Value = 3000},
                new SparkDataModel(){ Value = -4000},
                new SparkDataModel(){ Value = 5000},
                new SparkDataModel(){ Value = 0},
                new SparkDataModel(){ Value = 9000},
                new SparkDataModel(){ Value = -9000},
            };
        }
    }
}
