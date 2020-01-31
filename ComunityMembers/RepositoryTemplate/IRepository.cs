// ------------------------------------------------------------------------------
//     <copyright file="IRepository.cs" company="BlackLine">
//         Copyright (C) BlackLine. All rights reserved.
//     </copyright>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

using CommunityMembersModels.Contracts;

namespace CommunityRepository
{
    public interface IRepository<T> where T : IModel
    {
        /// <summary>This method gets the total number of records from a table.</summary>
        /// <returns>It returns total number of record from a table.</returns>
        Task<int> CountAsync();

        /// <summary>This method deletes asynchronously an item based on the given id.</summary>
        /// <param name="id"></param>
        /// <returns>Nothing.</returns>
        Task DeleteAsync(int id);

        /// <summary>Gets all items.</summary>
        /// <returns>An awaitable Task of <see cref="IList{T}"/> of <see cref="T"/>.</returns>
        Task<IList<T>> GetAllAsync();

        /// <summary>Gets an item by id.</summary>
        /// <param name="id">The id of the item.</param>
        /// <returns>An awaitable Task of <see cref="T"/>.</returns>
        Task<T> GetAsync(int id);

        /// <summary>This method saves (insert/update) asynchronously an item and the user number which called this method.</summary>
        /// <param name="item"></param>
        /// <param name="loggedUserId"></param>
        /// <returns>It returns the item which was saved.</returns>
        Task<T> SaveAsync(T item, int loggedUserId);
    }
}