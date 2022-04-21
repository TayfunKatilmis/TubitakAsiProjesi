using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SoruManager : ISoruService
    {
        ISoruDal _soruDal;
        public SoruManager(ISoruDal soruDal)
        {
            _soruDal = soruDal;
        }
        public IResult Add(Soru soru)
        {
            _soruDal.Add(soru);
            return new SuccessResult();
        }

        public IResult Delete(Soru soru)
        {
            _soruDal.Delete(soru);
            return new SuccessResult();
        }

        public IDataResult<List<Soru>> GetAll()
        {
            return new SuccessDataResult<List<Soru>>(_soruDal.GetAll());
        }

        public IResult Update(Soru soru)
        {
            _soruDal.Update(soru);
            return new SuccessResult();
        }
    }
}
