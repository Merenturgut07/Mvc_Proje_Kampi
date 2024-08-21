using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini Boş Geçemezsiniz");


            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş Geçemezsin");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçemezsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Kullanıcı Adını En Az 3 Karakterli Giriş Yapınız");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı Adını En Az 3 Karakterli Giriş Yapınız");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Konu Bilgisini  50  Karakterden Fazla Değer  Girişi Yapmayın");
        }
    }
}
