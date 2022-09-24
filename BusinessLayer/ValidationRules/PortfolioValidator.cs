using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez !");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Yolu Boş Geçilemez !");
            RuleFor(x => x.BigImageUrl).NotEmpty().WithMessage("Büyük Görsel Yolu Boş Geçilemez !");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Proje Adresi  Boş Geçilemez !");
        }
    }
}
