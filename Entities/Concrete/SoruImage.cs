using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SoruImage
    {
        public int SoruImageId { get; set; }
        public int SoruId { get; set; }
        public string ImagePath { get; set; }
    }
}
