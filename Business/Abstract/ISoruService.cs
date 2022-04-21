using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISoruService
    {
        IResult Add(Soru soru );
        IResult Delete(Soru soru);
        IResult Update(Soru soru);
        IDataResult<List<Soru>> GetAll();
    }
}
