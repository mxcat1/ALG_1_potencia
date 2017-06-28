<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.nudnum = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnomnum = New System.Windows.Forms.Label()
        CType(Me.nudnum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudnum
        '
        Me.nudnum.Location = New System.Drawing.Point(60, 84)
        Me.nudnum.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nudnum.Name = "nudnum"
        Me.nudnum.Size = New System.Drawing.Size(178, 20)
        Me.nudnum.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PROGRAMA PARA OBTENER EL NOMBRE DE UN NUMERO DE 9 DIGITOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "INGRESE UN NUMERO DE 9 DIGITOS"
        '
        'btnmostrar
        '
        Me.btnmostrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnmostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrar.ForeColor = System.Drawing.Color.Black
        Me.btnmostrar.Location = New System.Drawing.Point(107, 118)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(85, 23)
        Me.btnmostrar.TabIndex = 3
        Me.btnmostrar.Text = "MOSTRAR"
        Me.btnmostrar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(97, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "EL NUMERO ES :"
        '
        'lblnomnum
        '
        Me.lblnomnum.BackColor = System.Drawing.Color.Black
        Me.lblnomnum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnomnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomnum.ForeColor = System.Drawing.Color.White
        Me.lblnomnum.Location = New System.Drawing.Point(26, 177)
        Me.lblnomnum.Name = "lblnomnum"
        Me.lblnomnum.Size = New System.Drawing.Size(263, 73)
        Me.lblnomnum.TabIndex = 5
        Me.lblnomnum.Text = "-"
        Me.lblnomnum.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ALG_FUNCIONESEJER2FRM.My.Resources.Resources.FONDOA
        Me.ClientSize = New System.Drawing.Size(315, 259)
        Me.Controls.Add(Me.lblnomnum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudnum)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudnum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudnum As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnmostrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblnomnum As Label
End Class
