using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AboutValidator : AbstractValidator<About>
	{
		public AboutValidator()
		{
			RuleFor(x => x.Title).NotEmpty().WithMessage("Bu alan boş geçilemez.");
			RuleFor(x => x.Title).MinimumLength(5).WithMessage("Minimum 5 (beş) karakter girmelisiniz.");
			RuleFor(x => x.Title).MaximumLength(100).WithMessage("Maksimum 100 (yüz) karakter girmelisiniz.");

			RuleFor(x => x.Description).NotEmpty().WithMessage("Bu alan boş geçilemez.");
			RuleFor(x => x.Description).MinimumLength(5).WithMessage("Minimum 5 (beş) karakter girmelisiniz.");


			RuleFor(x => x.ImageURL).NotEmpty().WithMessage("Bu alan boş geçilemez.");
		}
	}
}
