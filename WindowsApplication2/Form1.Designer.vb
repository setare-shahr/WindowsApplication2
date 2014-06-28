<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cn
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
        Me.SuspendLayout()
        '
        'cn
        '
        Me.AccessibleDescription = "hi"
        Me.AccessibleName = "sallm"
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(744, 348)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Name", Global.WindowsApplication2.My.MySettings.Default, "vbvbvbv", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Coral
        Me.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.KeyPreview = True
        Me.Name = Global.WindowsApplication2.My.MySettings.Default.vbvbvbv
        Me.Tag = "hghghghg"
        Me.Text = "esii"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)

    End Sub

End Class
