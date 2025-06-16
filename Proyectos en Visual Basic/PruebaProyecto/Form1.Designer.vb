<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BTNIngresar = New Button()
        txtNombre = New TextBox()
        lblNombre = New Label()
        SuspendLayout()
        ' 
        ' BTNIngresar
        ' 
        BTNIngresar.Location = New Point(12, 56)
        BTNIngresar.Name = "BTNIngresar"
        BTNIngresar.Size = New Size(108, 33)
        BTNIngresar.TabIndex = 0
        BTNIngresar.Text = "Ingresar"
        BTNIngresar.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.BackColor = SystemColors.ActiveCaption
        txtNombre.Location = New Point(12, 27)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(189, 23)
        txtNombre.TabIndex = 1
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(12, 9)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(51, 15)
        lblNombre.TabIndex = 2
        lblNombre.Text = "Nombre" & vbCrLf
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(800, 450)
        Controls.Add(lblNombre)
        Controls.Add(txtNombre)
        Controls.Add(BTNIngresar)
        Name = "Form1"
        Text = "Campaña"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BTNIngresar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label

End Class
