using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class FeatureValidator : AbstractValidator<Feature>
	{
		public FeatureValidator()
		{
			RuleFor(x => x.Header).NotEmpty().WithMessage("Bu alan boş geçilemez.");
			RuleFor(x => x.Header).MinimumLength(5).WithMessage("Minimum 5 (beş) karakter girmelisiniz.");
			RuleFor(x => x.Header).MaximumLength(100).WithMessage("Maksimum 100 (yüz) karakter girmelisiniz.");

			RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alan boş geçilemez.");
			RuleFor(x => x.Name).MinimumLength(5).WithMessage("Minimum 5 (beş) karakter girmelisiniz.");
			RuleFor(x => x.Name).MaximumLength(100).WithMessage("Maksimum 100 (yüz) karakter girmelisiniz.");

			RuleFor(x => x.Title).NotEmpty().WithMessage("Bu alan boş geçilemez.");
			RuleFor(x => x.Title).MinimumLength(5).WithMessage("Minimum 5 (beş) karakter girmelisiniz.");
		}
	}
}
