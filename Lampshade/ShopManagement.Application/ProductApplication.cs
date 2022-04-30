using _0_Framework.Application;
using _0_FrameWork.Application;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;
        private readonly IFileUploader _fileUploader;
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductApplication(IProductRepository productRepository, IFileUploader fileUploader, IProductCategoryRepository productCategoryRepository)
        {
            _productRepository = productRepository;
            _fileUploader = fileUploader;
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResult Create(CreateProduct command)
        {
            var operation = new OperationResult();
            if (_productRepository.Exists(x => x.Name == command.Name))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();

            var categorySlug = _productCategoryRepository.GetSlugById(command.CategoryId);
            var path = $"{categorySlug}/{slug}";
            var picturePath = _fileUploader.Upload(command.Picture, path);

            var product = new Product(command.Name, command.Code,
                command.ShortDescription, command.Description, picturePath, command.PictureAlt,
                command.PictureTitle, command.Keywords, command.MetaDescription, slug,
                command.CategoryId);
            _productRepository.Create(product);
            _productRepository.SaveChanges();

            return operation.Succedded();

            
        }

        public OperationResult Edit(EditProduct command)
        {
            var operation = new OperationResult();
            var product = _productRepository.GetProductWithCategory(command.Id);
            if (product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if(_productRepository.Exists(_product => _product.Name == command.Name&&_product.Id!=command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();

            var path = $"{product.Category.Slug}/{slug}";
            var picturePath = _fileUploader.Upload(command.Picture, path);

            product.Edit(command.Name, command.Code,
                command.ShortDescription, command.Description, picturePath, command.PictureAlt,
                command.PictureTitle, command.Keywords, command.MetaDescription, slug,
                command.CategoryId);

            _productRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditProduct GetDetails(long id)
        {
           return _productRepository.GetDetails(id);
        }

        public List<ProductViewModel> GetProducts()
        {
            return _productRepository.GetProducts();
        }


        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            return _productRepository.Search(searchModel);
        }
    }
}
