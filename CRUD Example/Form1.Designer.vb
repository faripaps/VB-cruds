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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grbDisplay = New System.Windows.Forms.GroupBox()
        Me.grbOptions = New System.Windows.Forms.GroupBox()
        Me.dgvDisplay = New System.Windows.Forms.DataGridView()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.grbDisplay.SuspendLayout()
        Me.grbOptions.SuspendLayout()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbDisplay
        '
        Me.grbDisplay.Controls.Add(Me.dgvDisplay)
        Me.grbDisplay.Location = New System.Drawing.Point(12, 12)
        Me.grbDisplay.Name = "grbDisplay"
        Me.grbDisplay.Size = New System.Drawing.Size(482, 335)
        Me.grbDisplay.TabIndex = 0
        Me.grbDisplay.TabStop = False
        Me.grbDisplay.Text = "DISPLAY DATA"
        '
        'grbOptions
        '
        Me.grbOptions.Controls.Add(Me.btnSearch)
        Me.grbOptions.Controls.Add(Me.btnDelete)
        Me.grbOptions.Controls.Add(Me.btnUpdate)
        Me.grbOptions.Controls.Add(Me.btnRead)
        Me.grbOptions.Controls.Add(Me.btnCreate)
        Me.grbOptions.Location = New System.Drawing.Point(12, 353)
        Me.grbOptions.Name = "grbOptions"
        Me.grbOptions.Size = New System.Drawing.Size(482, 80)
        Me.grbOptions.TabIndex = 1
        Me.grbOptions.TabStop = False
        Me.grbOptions.Text = "OPTIONS"
        '
        'dgvDisplay
        '
        Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDisplay.Location = New System.Drawing.Point(3, 16)
        Me.dgvDisplay.Name = "dgvDisplay"
        Me.dgvDisplay.Size = New System.Drawing.Size(476, 316)
        Me.dgvDisplay.TabIndex = 0
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(6, 19)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(82, 43)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(94, 19)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(82, 43)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(182, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 43)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(270, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(82, 43)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(358, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(82, 43)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 445)
        Me.Controls.Add(Me.grbOptions)
        Me.Controls.Add(Me.grbDisplay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "User Details"
        Me.grbDisplay.ResumeLayout(False)
        Me.grbOptions.ResumeLayout(False)
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDisplay As GroupBox
    Friend WithEvents grbOptions As GroupBox
    Friend WithEvents dgvDisplay As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnCreate As Button
End Class
