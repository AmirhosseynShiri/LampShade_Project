namespace BlogMangement.Application.Contracts.AricleCategory
{
    public class ArticleCategoryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Desription { get; set; }
        public int ShowOrder { get; set; }
        public string CreationDate { get; set; }
        public long ArticleCount { get; set; }
    }
}
