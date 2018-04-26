namespace Sitecore.Support.Commerce.Engine.Connect.Search.Crawlers
{
    using Sitecore.ContentSearch;
    using System.Threading;

    public class CategoriesCrawler : Sitecore.Commerce.Engine.Connect.Search.Crawlers.CategoriesCrawler
    {
        public override void RefreshFromRoot(IProviderUpdateContext context, IIndexable indexableStartingPoint, IndexingOptions indexingOptions, CancellationToken cancellationToken)
        {
            return;
        }
    }
}
