using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class ServiceValidator : AbstractValidator<Service>
	{
		public ServiceValidator()
		{
			RuleFor(x => x.Title).NotEmpty().WithMessage("Bu alan boş geçilemez.");
			RuleFor(x => x.Title).MinimumLength(3).WithMessage("Minimum 3 (üç) karakter girmelisiniz.");
			RuleFor(x => x.Title).MaximumLength(100).WithMessage("Maksimum 100 (yüz) karakter girmelisiniz.");

			

		}
	}
}
