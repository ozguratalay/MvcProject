using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator: AbstractValidator<Message>
    {
        public MessageValidator() {
            RuleFor(x => x.SenderMail).NotEmpty().WithMessage("Boş bırakılamaz!");
            RuleFor(x => x.SenderMail).MaximumLength(50).WithMessage("50 karakterden fazla giriş yapılamaz!");
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Boş bırakılamaz!");
            RuleFor(x => x.ReceiverMail).MaximumLength(50).WithMessage("50 karakterden fazla giriş yapılamaz!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Boş bırakılamaz!");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("100 karakterden fazla giriş yapılamaz!");
        }
    }
}
