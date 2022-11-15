using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1.Concrete;
using FluentValidation;

namespace BusinessLayer1.ValidatiorRules
{
  public  class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresini boş gecemezsiniz..");

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş gecemezsiniz..");

            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş gecemezsiniz..");

            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az üç karakter girişi yapın");


            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen 50 karaktarden fazla giriş yapmayınız.");

        }
    }
}
