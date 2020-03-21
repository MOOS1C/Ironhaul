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
        Me.lblWorld = New System.Windows.Forms.Label()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWorld
        '
        Me.lblWorld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWorld.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorld.Location = New System.Drawing.Point(12, 136)
        Me.lblWorld.Name = "lblWorld"
        Me.lblWorld.Size = New System.Drawing.Size(260, 116)
        Me.lblWorld.TabIndex = 0
        Me.lblWorld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHello
        '
        Me.btnHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHello.Location = New System.Drawing.Point(12, 12)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(260, 112)
        Me.btnHello.TabIndex = 1
        Me.btnHello.Text = "Hello World"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.lblWorld)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWorld As Label
    Friend WithEvents btnHello As Button
End Class
