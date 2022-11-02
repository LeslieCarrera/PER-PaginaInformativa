using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrchardCore;
using Newtonsoft.Json.Linq;


namespace per.Pages
{
    public class BlogModel : BaseModel
    {
        private IOrchardHelper _orchard;

        public BlogModel(IOrchardHelper orchard)
        {
            _orchard = orchard;
        }

        public void OnGet()
        {

        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 10;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        [FromRoute]
        public string Slug { get; set; }

        public dynamic blogPostObj { get; set; }

        public async Task<IEnumerable<OrchardCore.ContentManagement.ContentItem>> GetBlogPosts()
        {
            return await _orchard.GetRecentContentItemsByContentTypeAsync("BlogPost", 10000);
        }

        public async Task<OrchardCore.ContentManagement.ContentItem> GetPostObj()
        {
            return await _orchard.GetContentItemByHandleAsync($"alias:{Slug}");
        }

        public async Task<Microsoft.AspNetCore.Html.IHtmlContent> GetMarkdown()
        {
            blogPostObj = await GetPostObj();
            return await _orchard.MarkdownToHtmlAsync((string)blogPostObj.Content.MarkdownBodyPart.Markdown);
        }

        public string TruncateForDisplay(string value, int length)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;
            var returnValue = value;
            if (value.Length > length)
            {
                var tmp = value.Substring(0, length);
                if (tmp.LastIndexOf(' ') > 0)
                    returnValue = tmp.Substring(0, tmp.LastIndexOf(' ')) + "...";
            }
            return returnValue;
        }


        public async Task<IEnumerable<OrchardCore.ContentManagement.ContentItem>> GetPaginatedResult(int currentPage, int pageSize = 10)
        {
            var data = await GetBlogPosts();
            return data.Skip((currentPage - 1) * pageSize).Take(pageSize);
        }

        public async Task<int> GetCount()
         {
           var data = await GetBlogPosts();
           return data.Count();
         }

    }
}