Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

#Region "# Creating_Nodes"
Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
		 CreateTreeView()
		End If
	End Sub

	'Create treeview nodes. 
	Private Sub CreateTreeView()
		Dim NodeNames() As String = { "Inbox", "Outbox", "Sent Items", "Deleted Items", "Search Folder" }
		For Each Text As String In NodeNames
			ASPxTreeView1.Nodes.Add(Text)
		Next Text
		ASPxTreeView1.Nodes.FindByText("Search Folder").Nodes.Add("Categorized Mail")

	End Sub
	'Add a new child node to the selected node.
	Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
		If (ASPxTreeView1.SelectedNode IsNot Nothing) AndAlso (ASPxTextBox1.Text <> "") Then
			ASPxTreeView1.SelectedNode.Nodes.Add(ASPxTextBox1.Text)
		End If
	End Sub

End Class
#End Region ' # Creating_Nodes