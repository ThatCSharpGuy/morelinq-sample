using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasLinq
{
    public class Data
    {
        private static Dinosaur[] _dinosaurs;

        public static Dinosaur[] Dinosaurs
        {
            get
            {
                return _dinosaurs ?? (_dinosaurs = new Dinosaur[]
                {
                    new Dinosaur { Name="Argentinosaurus", Height = 6.5, Length = 35, Weight = 75000},
                    new Dinosaur { Name="Sauroposeidon", Height = 15, Length = 38, Weight = 60000},
                    new Dinosaur { Name="Sauropelta", Height = 2, Length = 38, Weight = 60000},
                    new Dinosaur { Name="Chasmosaurus", Height = 2, Length =5.2, Weight = 4000},
                    new Dinosaur { Name="Beipiaosaurus", Height = 1, Length = 2.2, Weight = 85},
                    new Dinosaur { Name="Hypsilophodon", Height = 1, Length = 1.7, Weight = 43},
                    new Dinosaur { Name="Brachylophosaurus", Height = 2.5, Length =7, Weight = 3700},
                    new Dinosaur { Name="Acrocanthosaurus", Height = 3.7, Length = 12.5, Weight = 6000},
                    new Dinosaur { Name="Eoabelisaurus", Height = 2.2, Length =6.5, Weight = 700}
                });
            }
        }
    }
}
