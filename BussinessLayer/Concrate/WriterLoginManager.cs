﻿using BussinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrate
{
	public class WriterLoginManager: IWriterLoginService
	{
		IWriterDal _writerDal;

		public WriterLoginManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}

		public Writer GetWriter(string username, string password)
		{
			return _writerDal.Get(x=>x.WriterMail==username&&x.WriterPassword==password);
		}
	}
}
