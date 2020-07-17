using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Web.TagHelpers
{
    [HtmlTargetElement("sectionhelper")]
    public class Section : TagHelper
    {
        public string Data { get; set; } = "Eralp";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
        var stringBuilder = new StringBuilder();
            stringBuilder.Append("<b> Merhabalar </b>" +Data);
            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }
       

    }
}
