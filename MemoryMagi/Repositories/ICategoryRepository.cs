﻿using MemoryMagi.Database;
using MemoryMagi.Models;

namespace MemoryMagi.Repositories
{
    public interface ICategoryRepository
    {
        public AppDbContext _context { get; set; }
        public Task<List<Category>> GetAllCategoriesAsync(string userId);
        public Task<Category> AddCategoryAsync(Category newCategory);
    }
}
