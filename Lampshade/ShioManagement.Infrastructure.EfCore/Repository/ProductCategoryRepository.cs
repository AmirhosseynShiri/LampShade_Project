﻿using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using _0_FrameWork.Infrastructure;

namespace ShioManagement.Infrastructure.EfCore.Repository
{
    public class ProductCategoryRepository:RepositoryBase<long,ProductCategory>,IProductCategoryRepository
    {
        private readonly ShopContext _context;

        public ProductCategoryRepository(ShopContext context):base(context)
        {
            _context = context;
        }

        public EditProductCategory GetDetails(long id)
        {
            return _context.ProductCategories.Select(x => new EditProductCategory
            {
                Id=x.Id,
                Name=x.Name,
                Description=x.Description,
                Keywords=x.Keywords,
                MetaDescription=x.MetaDescription,
                Picture=x.Picture,
                PictureAlt=x.PictureAlt,
                PictureTitle=x.PictureTitle,
                Slug=x.Slug
            }).FirstOrDefault(x => x.Id == id);
        }

        

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            var query = _context.ProductCategories.Select(x => new ProductCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                CreationDate = x.CreationDate.ToString()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));
            return query.OrderByDescending(x => x.Id).ToList();
        }

        #region with out generic repository
        //public void Create(ProductCategory entity)
        //{
        //    _context.Add(entity);
        //}

        //public bool Exists(Expression<Func<ProductCategory, bool>> expression)
        //{
        //    return _context.ProductCategories.Any(expression);
        //}

        //public ProductCategory Get(long id)
        //{
        //    return _context.ProductCategories.Find(id);
        //}

        //public List<ProductCategory> GetAll()
        //{
        //    return _context.ProductCategories.ToList();
        //}

        //public void SaveChanges()
        //{
        //    _context.SaveChanges();
        //}
        #endregion
    }
}
