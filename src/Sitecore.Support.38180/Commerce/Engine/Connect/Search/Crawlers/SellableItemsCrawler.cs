namespace Sitecore.Support.Commerce.Engine.Connect.Search.Crawlers
{
    using Sitecore.ContentSearch;
    using System.Threading;

    public class SellableItemsCrawler : Sitecore.Commerce.Engine.Connect.Search.Crawlers.SellableItemsCrawler
    {
        public override void RefreshFromRoot(IProviderUpdateContext context, IIndexable indexableStartingPoint, IndexingOptions indexingOptions, CancellationToken cancellationToken)
        {
            return;
        }
    }
}
