using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace Bootstrapdemo.Views.MyExtension
{
    public static class MyHelper
    {
        public static MvcHtmlString Submit(this HtmlHelper html, string caption, string cssClass)
        {
            //string str = string.Format("<input type = \"submit\" value=\"{0}\"class=\"{1}\"", caption, cssClass);

            //return new MvcHtmlString(str);

            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "submit");
            tb.Attributes.Add("value", caption);
            tb.Attributes.Add("class", cssClass);
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }
        public static MvcHtmlString MyCheckBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, object value)
        {
            ModelMetadata model = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string prop = model.PropertyName;

            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "checkbox");
            tb.Attributes.Add("id", "propName");
            tb.Attributes.Add("name", "propName");
            tb.Attributes.Add("value", value.ToString());
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }

    }
}