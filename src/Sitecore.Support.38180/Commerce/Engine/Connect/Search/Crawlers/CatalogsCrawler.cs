namespace Sitecore.Support.Commerce.Engine.Connect.Search.Crawlers
{
    using Sitecore.ContentSearch;
    using System.Threading;

    public class CatalogsCrawler : Sitecore.Commerce.Engine.Connect.Search.Crawlers.CatalogsCrawler
    {
        public override void RefreshFromRoot(IProviderUpdateContext context, IIndexable indexableStartingPoint, IndexingOptions indexingOptions, CancellationToken cancellationToken)
        {
            return;
        }
    }
}