using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnasayfaService
    {
        IResult Add(Anasayfa anasayfa);
        IResult Delete(Anasayfa anasayfa);
        IResult Update(Anasayfa anasayfa);
        IDataResult<List<Anasayfa>> GetAll();
    }
}
