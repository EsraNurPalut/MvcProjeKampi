using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1.Concrete;
using FluentValidation;

namespace BusinessLayer1.ValidatiorRules
{
   public  class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator() //yapıcı bir metot
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsin.");

            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçemezsin.");

            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını  boş geçemezsin.");

            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az iki karekter giriniz.");

            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karekter giriniz.");
        }
    }
}
