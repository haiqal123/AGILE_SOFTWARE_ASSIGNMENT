Public Class frmAdd
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
        Dim s As New Item()
        s.ItemID = txtId.Text
        s.ItemName = txtName.Text
        s.ItemPrice = mskPrice.Text
        s.ItemDescription = txtDescription.Text

        Dim db As New StorageItemDataContext()
        db.Items.InsertOnSubmit(s)
        db.SubmitChanges()
        MessageBox.Show("Item " & s.ItemName & " had been added successfully.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ResetForm()
    End Sub

    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class