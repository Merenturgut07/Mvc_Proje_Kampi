﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList(string p);
		List<Content> GetListByWriter(int id);
		List<Content> GetListByHeadingId(int id);
        void ContentAdd(Content content);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
        Content GetById(int id);
    }

}