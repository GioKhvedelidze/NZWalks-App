﻿using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories;

public interface IRegionRepository
{
    Task<ICollection<Region>> GetAllAsync();
    Task<Region?> GetByIdAsync(Guid id);
    Task<Region> CreateRegionAsync(Region region);
    Task<Region?> UpdateRegionAsync(Guid id, Region region);
    Task<Region?> DeleteRegion(Guid id);
}