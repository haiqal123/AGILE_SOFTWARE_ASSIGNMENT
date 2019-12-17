Imports System.IO
Imports System.Data.SqlClient
Public Class frmAdd
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\KENNE\DOWNLOADS\AGILE ASSIGNMENT\AGILE ASSIGNMENT (SPRINT 1 FULL)- KENNEY\AGILE ASSIGNMENT\STORAGE.MDF;Integrated Security=True")
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAdd_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ResetForm()
    End Sub
    Private Sub ResetForm()
        txtId.Clear()
        txtName.Clear()
        mskPrice.Clear()
        txtDescription.Clear()
        txtId.Focus()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Dim s As New Item()
        's.ItemID = txtId.Text
        's.ItemName = txtName.Text
        's.ItemPrice = mskPrice.Text
        's.ItemDescription = txtDescription.Text


        Dim ms As New MemoryStream
        Dim cmd As New SqlCommand("insert into Items(ItemID,ItemName,ItemPrice,ItemDescription,ItemImage) values(@id,@name,@price,@desc,@img)", con)
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtId.Text
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text
        cmd.Parameters.Add("@price", SqlDbType.VarChar).Value = mskPrice.Text
        cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = txtDescription.Text
        cmd.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()

        con.Open()
        If cmd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Successfull Upload")
        Else
            MessageBox.Show("Failed Upload")
        End If

        con.Close()
        'Dim db As New StorageItemDataContext()
        'db.Items.InsertOnSubmit(s)
        'db.SubmitChanges()
        'MessageBox.Show("Item " & s.ItemName & " had been added successfully.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)


        'ResetForm()
    End Sub

    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If



    End Sub
End Class