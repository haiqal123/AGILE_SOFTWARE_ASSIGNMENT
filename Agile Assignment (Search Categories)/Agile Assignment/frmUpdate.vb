Public Class frmUpdate
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim db As New StorageItemDataContext()

        Dim i As Item = db.Items.FirstOrDefault(Function(o) o.ItemID = txtID.Text)
        i.ItemName = txtName.Text
        i.ItemPrice = mskPrice.Text
        i.ItemDescription = txtDescription.Text
        i.ItemQuantity = txtQuantity.Text

        If RadioButton1.Checked Then
            i.ItemCategory = "Coffee"
        ElseIf RadioButton2.Checked Then
            i.ItemCategory = "Fruit Juice"
        End If

        If RadioButton1.Checked Or RadioButton2.Checked Then
            db.SubmitChanges()

            MessageBox.Show("Details of item " + txtID.Text + " had been modified successfully.")

            txtID.Text = ""
            txtName.Text = ""
            mskPrice.Text = ""
            txtDescription.Text = ""
            txtQuantity.Text = ""
            RadioButton1.Checked = False
            RadioButton2.Checked = False

            Me.Close()

        Else
            MessageBox.Show("Please select an Item Category.")
        End If
    End Sub

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class