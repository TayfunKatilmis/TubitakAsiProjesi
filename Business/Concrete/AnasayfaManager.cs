using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AnasayfaManager : IAnasayfaService
    {
        IAnasayfaDal _anasayfaDal;
        public AnasayfaManager(IAnasayfaDal anasayfaDal)
        {
            _anasayfaDal = anasayfaDal ;
            
        }
        public IResult Add(Anasayfa anasayfa)
        {
            _anasayfaDal.Add(anasayfa);
            return new SuccessResult();
        }

        public IResult Delete(Anasayfa anasayfa)
        {
            _anasayfaDal.Delete(anasayfa);
            return new SuccessResult();
        }

        public IDataResult<List<Anasayfa>> GetAll()
        {
            return new SuccessDataResult<List<Anasayfa>>(_anasayfaDal.GetAll());
        }

        public IResult Update(Anasayfa anasayfa)
        {
            _anasayfaDal.Update(anasayfa);
            return new SuccessResult();
        }
    }
}
