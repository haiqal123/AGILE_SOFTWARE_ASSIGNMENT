Imports System.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\KENNE\DOWNLOADS\AGILE ASSIGNMENT\AGILE ASSIGNMENT (SPRINT 1 FULL)- KENNEY\AGILE ASSIGNMENT\STORAGE.MDF;Integrated Security=True")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StorageDataSet.Items' table. You can move, or remove it, as needed.
        'Me.ItemsTableAdapter.Fill(Me.StorageDataSet.Items)
        'BindData()
        Dim cmd As New SqlCommand("select * from Items")
        cmd.Connection = con

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable()

        adapter.Fill(table)

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        dgv.RowTemplate.Height = 100

        Dim imgc As New DataGridViewImageColumn()

        dgv.DataSource = table

        imgc = dgv.Columns(4)

        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch


    End Sub

    Private Sub BindData2()
        'Dim db As New StorageItemDataContext()
        'Dim rs = From o In db.Items
        'Where o.ItemID.Contains(txtID.Text)

        'dgv.DataSource = rs
    End Sub

    'Private Sub BindData()
    'Dim db As New StorageItemDataContext()
    'Dim rs = From o In db.Items
    '         Where o.ItemName.Contains(txtName.Text)

    ' dgv.DataSource = rs
    ' End Sub



    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        ' BindData()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAdd.ShowDialog()
        'BindData()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        BindData2()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        frmUpdate.Show()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' BindData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        frmDelete.Show()
    End Sub
End Class
