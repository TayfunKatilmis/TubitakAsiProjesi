using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Asi : IEntity
    {
        public int AsiId { get; set; }
        public int HastalikId { get; set; }
        public int IcerikId { get; set; }
        public string AsiAd { get; set; }
        public string AsiAciklama { get; set; }
    }
}
