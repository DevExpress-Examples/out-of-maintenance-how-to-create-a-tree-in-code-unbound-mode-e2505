using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

#region #Creating_Nodes
public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
         CreateTreeView(); 
        }
    }

    //Create treeview nodes. 
    void CreateTreeView() {
        string[] NodeNames = { "Inbox", "Outbox", "Sent Items", "Deleted Items", "Search Folder" };
        foreach (string Text in NodeNames) {
            ASPxTreeView1.Nodes.Add(Text);
        }
        ASPxTreeView1.Nodes.FindByText("Search Folder").Nodes.Add("Categorized Mail");

    }
    //Add a new child node to the selected node.
    protected void ASPxButton1_Click(object sender, EventArgs e) {
        if ((ASPxTreeView1.SelectedNode != null) && (ASPxTextBox1.Text != "")) {
            ASPxTreeView1.SelectedNode.Nodes.Add(ASPxTextBox1.Text);
        }
    }

}
#endregion #Creating_Nodes