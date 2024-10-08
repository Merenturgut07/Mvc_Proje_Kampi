﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
	public class Context:DbContext
	{
			public DbSet<About> Abouts { get; set; }
			public DbSet<Category> Categories { get; set; }
			public DbSet<Contact> Contacts { get; set; }
			public DbSet<Content> Contents { get; set; }
			public DbSet<Heading> Headings { get; set; }
			public DbSet<Writer> Writers { get; set; }
			public DbSet<Message> Messages { get; set; }
			public DbSet<ImageFile>ımageFiles { get; set; }
			public DbSet<Admin>Admins { get; set; }
			public DbSet<YetenekKartım>yetenekKartıms { get; set; }

		public DbSet<TemaAnaSayfa> temaAnaSayfas { get; set; }


	}
}
