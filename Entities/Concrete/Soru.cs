using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Soru: IEntity
    {
        public int SoruId { get; set; }
        public int CevapId { get; set; }
        public string SoruAdi { get; set; }

    }
}
