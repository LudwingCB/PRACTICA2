﻿using DPAUESAN.Shopping.DOMAIN.Core.Entities;

namespace DPAUESAN.Shopping.DOMAIN.Core.Interfaces
{
    public interface IFavoriteRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Favorite>> GetAll();
        Task<Favorite> GetById(int id);
        Task<bool> Insert(Favorite favorite);
        Task<bool> Update(Favorite favorite);
    }
}