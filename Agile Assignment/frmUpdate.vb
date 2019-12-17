Imports System.Data.SqlClient
Imports System.IO

Public Class frmUpdate
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\KENNE\DOWNLOADS\AGILE ASSIGNMENT\AGILE ASSIGNMENT (SPRINT 1 FULL)- KENNEY\AGILE ASSIGNMENT\STORAGE.MDF;Integrated Security=True")
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Dim db As New StorageItemDataContext()

        'Dim i As Item = db.Items.FirstOrDefault(Function(o) o.ItemID = txtID.Text)
        'i.ItemName = txtName.Text
        'i.ItemPrice = mskPrice.Text
        'i.ItemDescription = txtDescription.Text

        ' db.SubmitChanges()
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim img() As Byte
        img = ms.ToArray()

        Dim updateQuery As String = "Update Items SET ItemName= '" & txtName.Text & "',ItemDescription= '" & txtDescription.Text & "',ItemPrice= '" & mskPrice.Text & "',ItemImage= @img Where ItemID= " & txtID.Text

        Dim cmd As New SqlCommand(updateQuery, con)
        cmd.Parameters.Add("@img", SqlDbType.Image).Value = img

        ExecuteQuery(cmd, "Image Update")


        txtID.Text = ""
        txtName.Text = ""
        mskPrice.Text = ""
        txtDescription.Text = ""

        Me.Close()
    End Sub

    Public Sub ExecuteQuery(cmd As SqlCommand, query As String)

        con.Open()

        If cmd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Successfull Upload")
        Else
            MessageBox.Show("Failed Upload")
        End If

        con.Close()

    End Sub

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class