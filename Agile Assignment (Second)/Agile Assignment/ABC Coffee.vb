Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub BindData2()
        Dim db As New StorageItemDataContext()
        Dim rs = From o In db.Items
                 Where o.ItemID.Contains(txtID.Text)

        dgv.DataSource = rs
    End Sub

    Private Sub BindData()
        Dim db As New StorageItemDataContext()
        Dim rs = From o In db.Items
                 Where o.ItemName.Contains(txtName.Text)

        dgv.DataSource = rs
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        BindData()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAdd.ShowDialog()
        BindData()
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
        BindData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        frmDelete.Show()
    End Sub
End Class
