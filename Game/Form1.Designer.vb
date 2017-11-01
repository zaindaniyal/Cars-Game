<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cars
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.pctFinish = New System.Windows.Forms.PictureBox()
        Me.pctblue = New System.Windows.Forms.PictureBox()
        Me.pctgreen = New System.Windows.Forms.PictureBox()
        CType(Me.pctFinish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctblue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctgreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(12, 236)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(106, 26)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'pctFinish
        '
        Me.pctFinish.BackColor = System.Drawing.Color.Red
        Me.pctFinish.Location = New System.Drawing.Point(342, 12)
        Me.pctFinish.Name = "pctFinish"
        Me.pctFinish.Size = New System.Drawing.Size(23, 219)
        Me.pctFinish.TabIndex = 3
        Me.pctFinish.TabStop = False
        '
        'pctblue
        '
        Me.pctblue.Image = Global.Game.My.Resources.Resources.untitled
        Me.pctblue.Location = New System.Drawing.Point(12, 133)
        Me.pctblue.Name = "pctblue"
        Me.pctblue.Size = New System.Drawing.Size(44, 19)
        Me.pctblue.TabIndex = 1
        Me.pctblue.TabStop = False
        '
        'pctgreen
        '
        Me.pctgreen.Image = Global.Game.My.Resources.Resources._2
        Me.pctgreen.Location = New System.Drawing.Point(12, 82)
        Me.pctgreen.Name = "pctgreen"
        Me.pctgreen.Size = New System.Drawing.Size(44, 19)
        Me.pctgreen.TabIndex = 0
        Me.pctgreen.TabStop = False
        '
        'Cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(513, 274)
        Me.Controls.Add(Me.pctFinish)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.pctblue)
        Me.Controls.Add(Me.pctgreen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cars"
        Me.Text = "Form1"
        CType(Me.pctFinish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctblue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctgreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctgreen As System.Windows.Forms.PictureBox
    Friend WithEvents pctblue As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents pctFinish As System.Windows.Forms.PictureBox

End Class
