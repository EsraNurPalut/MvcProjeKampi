using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1.Concrete;
using FluentValidation;

namespace BusinessLayer1.ValidatiorRules
{
   public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz!");
                 RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu adını boş geçemezsin.");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adını boş geçemezsin.");

            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az üç karekter giriniz.");

            RuleFor(x => x.UserName).MaximumLength(3).WithMessage("Lütfen en fazla üç karekter giriniz.");

            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen50 karakterden fazla değer girişi yapmayınız.");
        }
    }
}
