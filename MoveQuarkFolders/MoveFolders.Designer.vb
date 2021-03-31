<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoveFolders
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
        Me.btnDestPath = New System.Windows.Forms.Button()
        Me.btnSourcePath = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFolderToFind = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDestPath = New System.Windows.Forms.TextBox()
        Me.txtSourcePath = New System.Windows.Forms.TextBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDestPath
        '
        Me.btnDestPath.Location = New System.Drawing.Point(432, 44)
        Me.btnDestPath.Name = "btnDestPath"
        Me.btnDestPath.Size = New System.Drawing.Size(72, 24)
        Me.btnDestPath.TabIndex = 17
        Me.btnDestPath.Text = "Browse..."
        '
        'btnSourcePath
        '
        Me.btnSourcePath.Location = New System.Drawing.Point(432, 18)
        Me.btnSourcePath.Name = "btnSourcePath"
        Me.btnSourcePath.Size = New System.Drawing.Size(72, 24)
        Me.btnSourcePath.TabIndex = 16
        Me.btnSourcePath.Text = "Browse..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Folder To Find"
        '
        'txtFolderToFind
        '
        Me.txtFolderToFind.Location = New System.Drawing.Point(109, 73)
        Me.txtFolderToFind.Name = "txtFolderToFind"
        Me.txtFolderToFind.Size = New System.Drawing.Size(310, 20)
        Me.txtFolderToFind.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Destination Path"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Source Path"
        '
        'txtDestPath
        '
        Me.txtDestPath.Location = New System.Drawing.Point(109, 47)
        Me.txtDestPath.Name = "txtDestPath"
        Me.txtDestPath.Size = New System.Drawing.Size(310, 20)
        Me.txtDestPath.TabIndex = 11
        '
        'txtSourcePath
        '
        Me.txtSourcePath.Location = New System.Drawing.Point(109, 21)
        Me.txtSourcePath.Name = "txtSourcePath"
        Me.txtSourcePath.Size = New System.Drawing.Size(310, 20)
        Me.txtSourcePath.TabIndex = 10
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(347, 110)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(72, 23)
        Me.btnMove.TabIndex = 9
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(432, 110)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 23)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'MoveFolders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 155)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDestPath)
        Me.Controls.Add(Me.btnSourcePath)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFolderToFind)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDestPath)
        Me.Controls.Add(Me.txtSourcePath)
        Me.Controls.Add(Me.btnMove)
        Me.Name = "MoveFolders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Move Quark Folders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDestPath As Button
    Friend WithEvents btnSourcePath As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFolderToFind As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDestPath As TextBox
    Friend WithEvents txtSourcePath As TextBox
    Friend WithEvents btnMove As Button
    Friend WithEvents btnCancel As Button
End Class
