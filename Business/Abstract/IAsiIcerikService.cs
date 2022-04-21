using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAsiIcerikService
    {
        IResult Add(AsiIcerik asiIcerik);
        IResult Delete(AsiIcerik asiIcerik);
        IResult Update(AsiIcerik asiIcerik);
        IDataResult<List<AsiIcerik>> GetAll();
    }
}
