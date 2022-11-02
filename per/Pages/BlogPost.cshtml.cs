using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using OrchardCore;



namespace per.Pages
{
    public class BlogPostModel : BaseModel
    {
        private IOrchardHelper _orchard;
        public BlogPostModel(IOrchardHelper orchard)
        {
            _orchard = orchard;
        }

        [FromRoute]
        public string Slug { get; set; }

        public dynamic blogPostObj { get; set; }

        public void OnGet()
        {

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
    }                          
}