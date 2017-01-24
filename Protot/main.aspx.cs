using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            setPage();
        }
    }

    private void setPage()
    {
        ddlmove.Items.Clear();
        ddlmove2.Items.Clear();
        whichfile.Items.Clear();
        whichfolder.Items.Clear();
        whereto.Items.Clear();
        //folder1
        string[] filePaths = Directory.GetFiles(Server.MapPath("~/Resources/folder1/"));
        List<ListItem> files = new List<ListItem>();
        foreach (string filePath in filePaths)
        {
            ddlmove.Items.Add(new ListItem(Path.GetFileName(filePath), filePath));
        }

        //folder2
        string[] filePaths2 = Directory.GetFiles(Server.MapPath("~/Resources/folder2/"));
        List<ListItem> files2 = new List<ListItem>();
        foreach (string filePath2 in filePaths2)
        {
            ddlmove2.Items.Add(new ListItem(Path.GetFileName(filePath2), filePath2));
        }


        string[] folderPaths = Directory.GetDirectories(Server.MapPath("~/Resources/"));
        List<ListItem> folders = new List<ListItem>();
        foreach (string folderPath in folderPaths)
        {
            whichfolder.Items.Add(new ListItem(Path.GetFileName(folderPath), folderPath));
        }

        string[] folderPaths2 = Directory.GetDirectories(Server.MapPath("~/Resources/"));
        List<ListItem> folders2 = new List<ListItem>();
        foreach (string folderPath2 in folderPaths2)
        {
            whereto.Items.Add(new ListItem(Path.GetFileName(folderPath2), folderPath2));
        }
    }

    protected void UploadButton_Click(object sender, EventArgs e)
    {
        if (FileUploadControl.HasFile)
        {
            try
            {
                string filename = Path.GetFileName(FileUploadControl.FileName);
                FileUploadControl.SaveAs(Server.MapPath("~/Resources/folder1/") + filename);
                StatusLabel.Text = "Upload status: File uploaded!";
            }
            catch (Exception ex)
            {
                StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
            }
        }
    }

    protected void moveDocument_Click(object sender, EventArgs e)
    {
        try
        {
            string fileToMove = whichfile.SelectedValue;
            string moveTo = whereto.SelectedValue + "\\" + Path.GetFileName(fileToMove);

            //moving file
            File.Move(fileToMove, moveTo);
            setPage();
        }
        catch (Exception ex)
        {

            throw ex;
        }
        
    }

    protected void whichfolder_SelectedIndexChanged(object sender, EventArgs e)
    {
        whichfile.Items.Clear();

        string[] filePaths = Directory.GetFiles(whichfolder.SelectedValue + @"\");
        List<ListItem> files = new List<ListItem>();
        foreach (string filePath in filePaths)
        {
            whichfile.Items.Add(new ListItem(Path.GetFileName(filePath), filePath));
        }
    }
}