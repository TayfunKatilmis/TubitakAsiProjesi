using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SoruImageManager : ISoruImageService
    {
        public IResult Add(IFormFile file, SoruImage soruImage)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CarImage soruImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SoruImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(IFormFile file, SoruImage soruImage)
        {
            throw new NotImplementedException();
        }
    }
}
