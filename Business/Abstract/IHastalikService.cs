using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHastalikService
    {
        IResult Add(Hastalik hastalik);
        IResult Delete(Hastalik hastalik);
        IResult Update(Hastalik hastalik);
        IDataResult<List<Hastalik>> GetAll();
    }
}
