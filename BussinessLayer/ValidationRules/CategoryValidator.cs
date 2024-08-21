using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
	public class CategoryValidator : AbstractValidator<Category>
	{
		public CategoryValidator()
		{
			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsin");
			RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsiniz");
			RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Litfen En Az 3 Karakterli Giriş Yapınız");
			RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Litfen 20  Karakterden Fazla Değer  Girişi Yapmayın");
		}
	}
}
