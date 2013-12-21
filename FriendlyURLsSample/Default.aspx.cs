using System;

using Microsoft.AspNet.FriendlyUrls;

namespace FriendlyURLsSample
{
  public partial class Default : System.Web.UI.Page
  {
    protected void Greet_Click(object sender, EventArgs e)
    {
      Response.Redirect(FriendlyUrl.Href("~/Greeting", Name.Text));
    }
  }
}