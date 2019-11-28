Public Class frmUpdate
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim db As New StorageItemDataContext()

        Dim i As Item = db.Items.FirstOrDefault(Function(o) o.ItemID = txtID.Text)
        i.ItemName = txtName.Text
        i.ItemPrice = mskPrice.Text
        i.ItemDescription = txtDescription.Text
        i.ItemQuantity = txtQuantity.Text

        db.SubmitChanges()

        MessageBox.Show("Details of item " + txtID.Text + " had been modified successfully.")

        txtID.Text = ""
        txtName.Text = ""
        mskPrice.Text = ""
        txtDescription.Text = ""
        txtQuantity.Text = ""

        Me.Close()
    End Sub

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class