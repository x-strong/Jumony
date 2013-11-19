﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ivony.Html.Web
{

  /// <summary>
  /// 进行列表数据绑定的时候的绑定上下文信息
  /// </summary>
  public sealed class HtmlListBindingContext : HtmlBindingContext
  {

    internal HtmlListBindingContext( HtmlBindingContext context, IHtmlElement element, IHtmlListDataContext dataContext )
      : base( context, element, dataContext.ListData )
    {
      ListDataContext = dataContext;
    }


    public IHtmlListDataContext ListDataContext
    {
      private set;
      get;
    }

    


  }
}