using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class AsiIcerik: IEntity
    {
        [Key]
        public int IcerikId { get; set; }
        public string MaddeAdi { get; set; }

    }
}
