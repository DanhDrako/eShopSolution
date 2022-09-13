﻿using eShopSolution.Data.EF;
using eShopSolution.ViewModels.Catalog.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly EShopDbContext _context;
        public CategoryService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            var query= from c in _context.Categories
                       join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                       where ct.LanguageId == languageId
                       select new {c,ct};
            return await query.Select(x=> new CategoryVm()
            {
                Id= x.c.Id,
                Name =x.ct.Name
            }).ToListAsync();
        }
    }
}
