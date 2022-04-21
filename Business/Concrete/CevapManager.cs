using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CevapManager : ICevapService
    {
        ICevapDal _cevapDal;
        public CevapManager(ICevapDal cevapDal)
        {
            _cevapDal = cevapDal;

        }
        public IResult Add(Cevap cevap)
        {
            _cevapDal.Add(cevap);
            return new SuccessResult();

        }

        public IResult Delete(Cevap cevap)
        {
            _cevapDal.Delete(cevap);
            return new SuccessResult();
        }

        public IDataResult<List<Cevap>> GetAll()
        {
            return new SuccessDataResult<List<Cevap>>(_cevapDal.GetAll());
        }

        public IResult Update(Cevap cevap)
        {
            _cevapDal.Update(cevap);
            return new SuccessResult();
        }
    }
}
