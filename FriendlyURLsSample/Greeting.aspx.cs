using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FriendlyURLsSample
{
  public partial class Greeting : System.Web.UI.Page
  {
    public string Name { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
      Name = FriendlyUrl.Segments.First();
    }
  }
}