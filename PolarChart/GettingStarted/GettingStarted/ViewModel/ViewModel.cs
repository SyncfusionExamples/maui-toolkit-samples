﻿using System.Collections.ObjectModel;

namespace GettingStarted
{
    public class ViewModel
    {
        public ObservableCollection<Model> PlantDetails { get; set; }
        public ViewModel()
        {
            PlantDetails = new ObservableCollection<Model>()
            {
                new Model(){ Direction = "North", Tree = 80, Flower = 42, Weed = 63},
                new Model(){ Direction = "NorthEast", Tree = 85, Flower = 40, Weed = 70},
                new Model(){ Direction = "East", Tree = 78 , Flower = 47, Weed = 65},
                new Model(){ Direction = "SouthEast", Tree = 90 , Flower = 40, Weed = 70},
                new Model(){ Direction = "South", Tree = 78 , Flower = 27, Weed = 47},
                new Model(){ Direction = "SouthWest", Tree = 83 , Flower = 45, Weed = 65},
                new Model(){ Direction = "West", Tree = 79 , Flower = 40, Weed = 58},
                new Model(){ Direction = "NorthWest", Tree = 88 , Flower = 38, Weed = 73}
            };
        }
    }
}