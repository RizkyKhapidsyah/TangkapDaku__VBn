<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTangkapDaku
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
        Me.tombolTangkapDaku = New System.Windows.Forms.Button()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'tombolTangkapDaku
        '
        Me.tombolTangkapDaku.Location = New System.Drawing.Point(116, 128)
        Me.tombolTangkapDaku.Name = "tombolTangkapDaku"
        Me.tombolTangkapDaku.Size = New System.Drawing.Size(87, 23)
        Me.tombolTangkapDaku.TabIndex = 0
        Me.tombolTangkapDaku.Text = "TangkapDaku"
        Me.tombolTangkapDaku.UseVisualStyleBackColor = True
        '
        'tmrGame
        '
        Me.tmrGame.Enabled = True
        Me.tmrGame.Interval = 1000
        '
        'FormTangkapDaku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 296)
        Me.Controls.Add(Me.tombolTangkapDaku)
        Me.Name = "FormTangkapDaku"
        Me.Text = "Tangkap Daku"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tombolTangkapDaku As System.Windows.Forms.Button
    Friend WithEvents tmrGame As System.Windows.Forms.Timer

End Class
