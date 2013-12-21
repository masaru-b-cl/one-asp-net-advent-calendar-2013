using System;
using System.Linq;

using Microsoft.AspNet.FriendlyUrls;

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