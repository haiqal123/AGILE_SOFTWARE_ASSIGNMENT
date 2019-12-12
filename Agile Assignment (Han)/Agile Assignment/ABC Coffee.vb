Imports System.ComponentModel

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub BindData2()
        Dim db As New StorageItemDataContext()
        Dim rs = From o In db.Items
                 Where o.ItemID.Contains(txtID.Text)

        dgv.DataSource = rs
        lblCount.Text = rs.Count().ToString("Total: 0 item(s)")
    End Sub

    Private Sub BindData()
        Dim db As New StorageItemDataContext()
        Dim rs = From o In db.Items
                 Where o.ItemName.Contains(txtName.Text)

        dgv.DataSource = rs
        lblCount.Text = rs.Count().ToString("Total: 0 item(s)")

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            dgv.Sort(dgv.Columns(2), ListSortDirection.Ascending)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            dgv.Sort(dgv.Columns(2), ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        With PrintPreviewDialog1
            .ShowIcon = False
            .WindowState = FormWindowState.Maximized
            .Document = PrintDocument1
            .ShowDialog()
        End With
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fntHeading As New Font("Consolas", 24, FontStyle.Bold)
        Dim fntSubHeading As New Font("Consolas", 12, FontStyle.Bold)
        Dim fntPrint As New Font("Consolas", 12)
        Dim fntFooter As New Font("Consolas", 12)
        Dim sngLineHeight As Single = fntPrint.GetHeight + 2
        Dim sngXLocation As Single = e.MarginBounds.Left
        Dim sngYLocation As Single = e.MarginBounds.Top
        Dim sngy1 As Single = e.MarginBounds.Bottom

        Dim subheader As String = String.Format("Printed on {0:dd-mmmm-yyyy hh:mm:ss tt}", DateTime.Now)

        'Header
        With e.Graphics
            .DrawString("ABC Coffee Daily Report", fntHeading, Brushes.Blue, sngXLocation, sngYLocation)
            sngYLocation += sngLineHeight
            sngYLocation += sngLineHeight
            .DrawString(subheader, fntSubHeading, Brushes.Black, sngXLocation, sngYLocation)
            sngYLocation += sngLineHeight
        End With

        'Body
        Dim mRow As Integer = 0
        Dim newpage As Boolean = True
        With dgv
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Single = e.MarginBounds.Top + 80
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)

                    If (newpage) Then
                        e.Graphics.DrawString(dgv.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                    Else
                        e.Graphics.DrawString(dgv.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                    End If
                    x += rc.Width
                    h = Math.Max(h, rc.Height)


                Next

                y += h

                If (newpage) = False Then
                    mRow += 1
                End If

                newpage = False

                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
        End With

        'footer
        With e.Graphics
            .DrawString($"{dgv.RowCount - 1} record(s)", fntFooter, Brushes.Black, sngXLocation, sngy1 - 30)
            .DrawString("--- End ---", fntFooter, Brushes.Black, sngXLocation, sngy1)
        End With
    End Sub
End Class
