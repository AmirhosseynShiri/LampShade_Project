using _0_Framework.Application;
using _0_FrameWork.Application;
using BlogManagement.Domain.ArticleAgg;
using BlogManagement.Domain.ArticleCategoryAgg;
using BlogMangement.Application.Contracts.Article;
using System;
using System.Collections.Generic;

namespace BlogManagement.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IFileUploader _fileUploader;

        public ArticleApplication(IArticleRepository articleRepository, IFileUploader fileUploader, IArticleCategoryRepository articleCategoryRepository)
        {
            _articleRepository = articleRepository;
            _fileUploader = fileUploader;
            _articleCategoryRepository = articleCategoryRepository;
        }

        public OperationResult Create(CreateArticle command)
        {
            var operation=new OperationResult();

            if(_articleRepository.Exists(x=>x.Title == command.Title))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var publishDate=command.PublishDate.ToGeorgianDateTime();
            var slug=command.Slug.Slugify();
            var articleCategurySlug = _articleCategoryRepository.GetSlugBy(command.CategoryId);
            var path = $"{articleCategurySlug}/{slug}";
            var pictureName = _fileUploader.Upload(command.Picture, path);

            var article = new Article(command.Title,command.ShortDescription,
                command.Description, pictureName, command.PictureAlt,command.PictureTitle
                ,publishDate,slug,command.Keywords,command.MetaDescription
                ,command.CanonicalAddress,command.CategoryId);

            _articleRepository.Create(article);
            _articleRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditArticle command)
        {
            var operation = new OperationResult();
            var article = _articleRepository.GetWithCategory(command.Id);
            if(article == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_articleRepository.Exists(x => x.Title == command.Title&&x.Id!=command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var publishDate = command.PublishDate.ToGeorgianDateTime();
            var slug = command.Slug.Slugify();
            var path = $"{article.Category.Slug}/{slug}";
            var pictureName = _fileUploader.Upload(command.Picture, path);

            article.Edit(command.Title, command.ShortDescription,
                command.Description, pictureName, command.PictureAlt, command.PictureTitle
                , publishDate, slug, command.Keywords, command.MetaDescription
                , command.CanonicalAddress, command.CategoryId);

            _articleRepository.SaveChanges();
            return operation.Succedded();

        }

        public EditArticle GetDatails(long id)
        {
            return _articleRepository.GetDetails(id);
        }

        public List<ArticleViewModel> Search(ArticleSearchModel searchModel)
        {
            return _articleRepository.Search(searchModel);
        }
    }
}
