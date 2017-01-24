using System;
using System.Collections.Generic;
using System.Linq;

public partial class Proto_Haku : System.Web.UI.Page
{
    public struct Document
    {
        public string name;

        public int type;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        // Load documents.
    }

    [System.Web.Services.WebMethod]
    public static Document[] GetDocuments(string arg, int num)
    {
        // Load documents.
        List<Document> documents = new List<Document>()
        {
            new Document { name = "Dokumentti_01", type = 1 },
            new Document { name = "Dokumentti_02", type = 2 },
            new Document { name = "Dokumentti_03", type = 1 }
        };

        // Filter documents.
        return documents.Where(x => (x.name.ToLower().Contains(arg.ToLower()) && x.type != num)).ToArray();
    }
}