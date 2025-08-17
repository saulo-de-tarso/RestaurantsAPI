﻿using FluentValidation;

namespace Restaurants.Application.Restaurants.Commands.UpdateRestaurant;

public class UpdateRestaurantCommandValidator : AbstractValidator<UpdateRestaurantCommand>
{
    private readonly List<string> validCategories = ["Italian", "Mexican", "Japanese", "American", "Indian"];

    public UpdateRestaurantCommandValidator()
    {
        RuleFor(command => command.Name)
            .Length(3, 100);
    }
}
