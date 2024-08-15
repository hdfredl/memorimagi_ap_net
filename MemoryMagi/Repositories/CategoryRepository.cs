﻿using MemoryMagi.Database;
using MemoryMagi.Models;
using Microsoft.EntityFrameworkCore;

namespace MemoryMagi.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public AppDbContext _context { get; set; }

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Method to retrieve all categories along with their items and user items, 
        /// which is needed in order to be able to determine whether the user has completed a category/item or not.
        /// Only take categories that the user has created or where the userid is null. Userid null means that it's a public game that everyone can play.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Category>> GetAllCategoriesAsync(int userId)
        {
            return await _context.Categories.Where(c => c.UserId == userId || c.UserId == null).
                Include(c => c.Items).
                ThenInclude(i => i.UserItems.Where(u => u.UserId == userId)).
                ToListAsync();
        }

        public async Task<Category> AddCategoryAsync(Category newCategory)
        {
            try
            {
                await _context.Categories.AddAsync(newCategory);
                await _context.SaveChangesAsync();
                return newCategory;
            }
            catch (Exception ex)
            {
                throw new DbUpdateException($"Something went wrong when saving to the database. Detailed information about the exception:\n{ex.Message}\nInner exception:\n{ex.InnerException.Message}");
            }
        }
    }
}
