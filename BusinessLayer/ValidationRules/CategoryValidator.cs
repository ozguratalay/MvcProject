using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adı boş bırakılamaz!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En az 3 karakter girişi yapılmalıdır!");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("20 karakterden fazla giriş yapılamaz!");
        }
    }
}
