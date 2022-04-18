using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Hastalik:IEntity
    {
        public int HastalikId { get; set; }
        public int AsiId { get; set; }
        public string HastalikAd { get; set; }
        public string Aciklama { get; set; }
    }
}
