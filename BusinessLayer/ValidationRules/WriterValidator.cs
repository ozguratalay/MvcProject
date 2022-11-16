using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar adı boş bırakılamaz!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadı boş bırakılamaz!");
            RuleFor(x => x.About).NotEmpty().WithMessage("Hakkında bölümü boş bırakılamaz!");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("En az 3 karakter girişi yapılmalıdır!");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("50 karakterden fazla giriş yapılamaz!");
        }
    }
}
