using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Core;
using Umbraco.Community.Contentment.DataEditors;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Extensions;

namespace Clean.Core.Contentment
{
    public class AuthorDataListSource : IDataListSource
    {
        private readonly IUmbracoContextFactory _contextFactory;

        public AuthorDataListSource(IUmbracoContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public string Name => "Author Content Items";

        public string Description => "Use authors content items as a data source.";

        public string Icon => "icon-users";

        public OverlaySize OverlaySize => OverlaySize.Small;

        public Dictionary<string, object> DefaultValues => new Dictionary<string, object>();

        public IEnumerable<ConfigurationField> Fields => Enumerable.Empty<ConfigurationField>();

        public string Group => "Custom";

        public IEnumerable<DataListItem> GetItems(Dictionary<string, object> config)
        {
            var contextReference = _contextFactory.EnsureUmbracoContext();

            IPublishedContentCache contentCache = contextReference.UmbracoContext.Content;

            List<DataListItem> results = new List<DataListItem>();

            //get call content items which are using the document type alias of 'person'
            var authorList = contentCache.GetSingleByXPath("//authorList");

            if (authorList == null) return Enumerable.Empty<DataListItem>();

            var authors = authorList.ChildrenOfType("author");

            //make sure there are some author items
            if (authors == null || !authors.Any()) return Enumerable.Empty<DataListItem>();

            //loop through the people itmes
            foreach (var author in authors)
            {

                //generate a udi from the key property of the content item
                //we will use this to store as the value of the author picker
                var udi = Udi.Create(Constants.UdiEntityType.Document, author.Key);
                if (udi == null) break;

                //create a new DataListItem object to store the data
                var item = new DataListItem()
                {
                    Name = author.Name,
                    Value = udi.ToString()
                };

                //check if the person record has a photo
                if (author.HasValue("mainImage"))
                {
                    var photo = author.Value<IPublishedContent>("mainImage");
                    item.Icon = photo.GetCropUrl(120, 120);
                }

                //add the item to our list of results
                results.Add(item);
            }

            return results;

        }

    }
}
