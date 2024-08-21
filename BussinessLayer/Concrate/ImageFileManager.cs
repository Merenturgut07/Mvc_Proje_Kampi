using BussinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrate
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _ımagefileDal;

        public ImageFileManager(IImageFileDal ımagefileDal)
        {
            _ımagefileDal = ımagefileDal;
        }

        public List<ImageFile> GetList()
        {

            return _ımagefileDal.List();
        }
    }
}
