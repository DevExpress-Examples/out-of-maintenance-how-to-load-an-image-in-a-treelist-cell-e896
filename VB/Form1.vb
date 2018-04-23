Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace LoadImage
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.AutoNodeHeight = False
			Me.treeList1.OptionsBehavior.KeepSelectedOnClick = False
			Me.treeList1.OptionsBehavior.ShowToolTips = False
			Me.treeList1.OptionsBehavior.SmartMouseHover = False
			Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1})
			Me.treeList1.RowHeight = 50
			Me.treeList1.Size = New System.Drawing.Size(354, 283)
			Me.treeList1.TabIndex = 0
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "treeListColumn1"
			Me.treeListColumn1.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(354, 283)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "How to Load an Image in a TreeList Cell"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn

		Private ImageFileName As String = "gdn.jpg"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
			Dim image As Image

			' load image
			If (Not System.IO.File.Exists(ImageFileName)) Then
				Throw New Exception("Image file not found: " & ImageFileName)
			End If

			image = Image.FromFile(ImageFileName)

			' the first node
            node = treeList1.AppendNode(Nothing, -1)

			node.SetValue(0, image) ' use SetValue method

			' the second node
			treeList1.AppendNode(New Object() {image}, node)

			node.Expanded = True
		End Sub
	End Class
End Namespace
