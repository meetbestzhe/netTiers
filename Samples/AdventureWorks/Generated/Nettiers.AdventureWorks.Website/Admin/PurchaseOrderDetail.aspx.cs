﻿

#region Using directives
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Nettiers.AdventureWorks.Web.UI;
#endregion

public partial class PurchaseOrderDetail : System.Web.UI.Page
{	
    protected void Page_Load(object sender, EventArgs e)
	{
		FormUtil.RedirectAfterUpdate(GridView1, "PurchaseOrderDetail.aspx?page={0}");
		FormUtil.SetPageIndex(GridView1, "page");
		FormUtil.SetDefaultButton((Button)GridViewSearchPanel1.FindControl("cmdSearch"));
    }

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("PurchaseOrderId={0}&PurchaseOrderDetailId={1}", GridView1.SelectedDataKey.Values[0], GridView1.SelectedDataKey.Values[1]);
		Response.Redirect("PurchaseOrderDetailEdit.aspx?" + urlParams, true);
	}
	
}


