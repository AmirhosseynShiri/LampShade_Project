﻿using _0_FrameWork.Infrastructure;
using ShopManagement.Application.Contracts.Slide;
using ShopManagement.Domain.SlideAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShioManagement.Infrastructure.EfCore.Repository
{
    public class SlideRepository : RepositoryBase<long, Slide>, ISlideRepository
    {
        private readonly ShopContext _context;

        public SlideRepository(ShopContext context):base(context)
        {
            _context = context;
        }

        public EditSlide GetDetails(long id)
        {
            return _context.Slides.Select(x => new EditSlide
            {
                Id=x.Id,
                Picture=x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Heading =x.Heading,
                Title=x.Title,
                BtnText=x.BtnText,
                IsRemoved=x.IsRemoved,
                Text=x.Text
            }).FirstOrDefault(x=>x.Id==id);
        }

        public List<SlideViewModel> GetList()
        {
            return _context.Slides.Select(x=>new SlideViewModel
            {
                Id = x.Id,
                Heading=x.Heading,
                Picture=x.Picture,
                Title= x.Title,
                IsRemoved= x.IsRemoved,
                CreationDate=x.CreationDate.ToString()
            }).OrderByDescending(x=>x.Id).ToList();
        }
    }
}
