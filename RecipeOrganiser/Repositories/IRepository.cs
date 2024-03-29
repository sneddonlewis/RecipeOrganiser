﻿namespace RecipeOrganiser.Repositories
{
    interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Add(T recipe);
        T GetByName(string name);
    }
}
