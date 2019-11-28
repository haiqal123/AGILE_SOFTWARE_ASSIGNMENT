<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblCoffee = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 183)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(789, 349)
        Me.dgv.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(342, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(106, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Product Name: "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(454, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(168, 22)
        Me.txtName.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 609)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(142, 47)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add Product"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(18, 40)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(78, 17)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "Product ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 85)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Product By"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(103, 40)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(160, 22)
        Me.txtID.TabIndex = 5
        '
        'lblCoffee
        '
        Me.lblCoffee.AutoSize = True
        Me.lblCoffee.Font = New System.Drawing.Font("Brush Script MT", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoffee.ForeColor = System.Drawing.Color.Aqua
        Me.lblCoffee.Location = New System.Drawing.Point(181, 31)
        Me.lblCoffee.Name = "lblCoffee"
        Me.lblCoffee.Size = New System.Drawing.Size(446, 40)
        Me.lblCoffee.TabIndex = 6
        Me.lblCoffee.Text = "ABC Coffee Shop Inventory System"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(650, 609)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 47)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(225, 609)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(145, 47)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update Details"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(435, 609)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(147, 47)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete Product"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(13, 539)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(183, 33)
        Me.lblCount.TabIndex = 10
        Me.lblCount.Text = "x item(s)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(813, 668)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCoffee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "ABC Coffee Shop"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblID As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblCoffee As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblCount As Label
End Class
