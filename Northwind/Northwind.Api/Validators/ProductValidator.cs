using FluentValidation;
using Northwind.Persistance.Entities;

namespace Northwind.Api.Validators;

public class ProductValidator : AbstractValidator<Product>
{
	public ProductValidator()
	{
		RuleFor(t => t.Name).NotEmpty();
		RuleFor(t=>t.CategoryId).NotEmpty();
		RuleFor(t=>t.UnitPrice).GreaterThan(0);
		RuleFor(t => t.UnitsInStock).GreaterThan((short)0);
		RuleFor(t => t.QuantityPerUnit).NotEmpty().Length(3, 20);
	}
}
