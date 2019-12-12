Public Class frmDelete
    Private Sub frmDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim db As New StorageItemDataContext()

        Dim i As Item = db.Items.FirstOrDefault(Function(o) o.ItemID = txtID.Text)

        If i Is Nothing Then
            Console.WriteLine("Record not found")
        Else
            db.Items.DeleteOnSubmit(i)
            db.SubmitChanges()
            MessageBox.Show("Item " + txtID.Text + " had been deleted successfully.")
            txtID.Text = ""
            Me.Close()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class