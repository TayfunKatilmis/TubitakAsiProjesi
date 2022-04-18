using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class AsiIcerik: IEntity
    {
        public int IcerikId { get; set; }
        public string MaddeAdi { get; set; }

    }
}
