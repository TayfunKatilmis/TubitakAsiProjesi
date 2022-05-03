using Business.Abstract;
using Core.Utilities.Helper.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SoruImageManager : ISoruImageService
    {
        private readonly ISoruImageDal _soruImageDal;
        public SoruImageManager(ISoruImageDal soruImageDal)
        {
            _soruImageDal = soruImageDal;
        }
        public IResult Add(IFormFile file, SoruImage soruImage)
        {
            var imageLımıt = _soruImageDal.GetAll(c => c.SoruId == soruImage.SoruId).Count;
            if (imageLımıt > 2)
            {
                return new ErrorResult();
            }
            var soruImageResult = FileHelper.Upload(file);
            if (!soruImageResult.Success)
            {
                return new ErrorResult(soruImageResult.Message);
            }
            soruImage.ImagePath = soruImageResult.Message;
            _soruImageDal.Add(soruImage);
            return new SuccessResult();
        }

        public IResult Delete(SoruImage soruImage)
        {
            var image = _soruImageDal.Get(c => c.SoruImageId == soruImage.SoruImageId);
            if (image != null)
            {
                FileHelper.Delete(image.ImagePath);
                _soruImageDal.Delete(soruImage);
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IDataResult<List<SoruImage>> GetAll()
        {
            return new SuccessDataResult<List<SoruImage>>(_soruImageDal.GetAll());
        }

        public IResult Update(IFormFile file, SoruImage soruImage)
        {
            var image = _soruImageDal.Get(c => c.SoruImageId == soruImage.SoruImageId);
            if (image == null)
            {
                return new ErrorResult();
            }
            var updated = FileHelper.Update(file, image.ImagePath);
            if (!updated.Success)
            {
                return new ErrorResult(updated.Message);
            }
            soruImage.ImagePath = updated.Message;
            _soruImageDal.Update(soruImage);
            return new SuccessResult();
        }
    }
}
