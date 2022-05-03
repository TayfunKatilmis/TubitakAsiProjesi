using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISoruImageService
    {
        IDataResult<List<SoruImage>> GetAll();
        IResult Add(IFormFile file, SoruImage soruImage);
        IResult Update(IFormFile file, SoruImage soruImage);
        IResult Delete(SoruImage soruImage);

    }
}
