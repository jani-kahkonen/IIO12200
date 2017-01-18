using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Proto_Haku : System.Web.UI.Page
{
    public struct Document
    {
        public string name;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        // Load documents.
        List<Document> documents = new List<Document>()
        {
            new Document { name = "Dokumentti_01" },
            new Document { name = "Dokumentti_02" },
            new Document { name = "Dokumentti_03" }
        };
    }

    public static void Filter()
    {
        // Filter documents.
    }
}

// http://www.infinetsoft.com/Post/How-to-create-autocomplete-textbox-with-database-in-asp-net-c/1254#.WH901Vw6xlw

// http://www.aspsnippets.com/Articles/Implement-jQuery-AutoComplete-TextBox-from-database-using-AJAX-PageMethods-in-ASPNet.aspx

// http://www.dotnetawesome.com/2013/12/autocomplete-textbox-without-webservice.html