using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1.Concrete;
using FluentValidation;

namespace BusinessLayer1.ValidationRules
{
   public  class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsin.");

            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı adını boş geçemezsin.");

            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az üç karekter giriniz.");

            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karekter giriniz.");
        }
    }
}
