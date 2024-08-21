using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {


            RuleFor(x => x.ReciverMail).NotEmpty().WithMessage("Alıcı Adresini Boş Geçemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu  Boş Geçemezsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı Boş Geçemezsin");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen  En Az 3 Karakterli Giriş Yapınız");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen Mesaj  Bilgisini  100  Karakterden Fazla Değer  Girişi Yapmayın");
        }
    }
}
