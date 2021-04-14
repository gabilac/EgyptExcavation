using EgyptExcavation.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgyptExcavation.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-info")]
    public class PaginationTagHelper : TagHelper
    {
        private IUrlHelperFactory urlInfo;
        //  initialization of IUrlHelperFactory in constructor
        public PaginationTagHelper(IUrlHelperFactory uhf)
        {
            urlInfo = uhf;
        }


        public PagingInfo PageInfo { get; set; }


        //  Builds dictionary of attributes
        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> CustAttributeDict { get; set; } = new Dictionary<string, object>();


        //  Setup View Context
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }



        //  Required override function
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelp = urlInfo.GetUrlHelper(ViewContext);

            TagBuilder wrapperTag = new TagBuilder("div");

            for (int i = 1; i <= 30; i++)
            {
                //  Build and populate "a" tags with asp-action attribute
                TagBuilder aTag = new TagBuilder("a");
                CustAttributeDict["pageNum"] = i;
                aTag.Attributes["href"] = urlHelp.Action("Burials", CustAttributeDict);
                aTag.InnerHtml.Append(i.ToString());
                aTag.AddCssClass("aTag");

                //  Add "a" tag to "wrapper" tag
                wrapperTag.InnerHtml.AppendHtml(aTag);
                wrapperTag.AddCssClass("wrapperTag");
            }

            //  Define output
            output.Content.AppendHtml(wrapperTag.InnerHtml);
        }
    }
}
