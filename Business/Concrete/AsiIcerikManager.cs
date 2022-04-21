using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AsiIcerikManager : IAsiIcerikService
    {
        IAsiIcerikDal _asiIcerikDal;
        public AsiIcerikManager(IAsiIcerikDal asiIcerikDal)
        {
            _asiIcerikDal = asiIcerikDal;

        }
        public IResult Add(AsiIcerik asiIcerik)
        {
            _asiIcerikDal.Add(asiIcerik);
            return new SuccessResult();
        }

        public IResult Delete(AsiIcerik asiIcerik)
        {
            _asiIcerikDal.Delete(asiIcerik);
            return new SuccessResult();
        }

        public IDataResult<List<AsiIcerik>> GetAll()
        {
            return new SuccessDataResult<List<AsiIcerik>>(_asiIcerikDal.GetAll());
        }

        public IResult Update(AsiIcerik asiIcerik)
        {
            _asiIcerikDal.Update(asiIcerik);
            return new SuccessResult();
        }
    }
}
