﻿using Restaurants.Domain.Entities;

namespace Restaurants.Domain.Respositories;

public interface IRestaurantsRepository
{
    Task<IEnumerable<Restaurant>> GetAllAsync();
    Task<Restaurant?> GetByIdAsync(int id);
    Task<int> Create(Restaurant entity);
}
