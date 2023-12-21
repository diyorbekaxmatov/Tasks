﻿using DiyorMarket.Domain.Common;

namespace DiyorMarket.Domain.Pagination
{
    public static class PaginationExtensions
    {
        public static async Task<PaginatedList<T>> ToPaginatedListAsync<T>(
            this IQueryable<T> source,
            int pageSize,
            int pageNumber) where T : EntityBase
        {
           var count =  source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PaginatedList<T>(items, count, pageNumber, pageSize);
        }

        public static PaginatedList<T> ToPaginatedList<T>(
            this IQueryable<T> source,
            int pageSize,
            int pageNumber) where T : EntityBase
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PaginatedList<T>(items, count, pageNumber, pageSize);
        }
    }
}