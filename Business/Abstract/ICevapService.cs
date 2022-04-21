using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICevapService
    {
        IResult Add(Cevap cevap);
        IResult Delete(Cevap cevap);
        IResult Update(Cevap cevap);
        IDataResult<List<Cevap>> GetAll();

    }
}
