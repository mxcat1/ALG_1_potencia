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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nuddia = New System.Windows.Forms.NumericUpDown()
        Me.nudmes = New System.Windows.Forms.NumericUpDown()
        Me.nudano = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbt3 = New System.Windows.Forms.RadioButton()
        Me.rbt2 = New System.Windows.Forms.RadioButton()
        Me.rbt1 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.btnfecha = New System.Windows.Forms.Button()
        CType(Me.nuddia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudmes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(185, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AÑO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(21, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DÍA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(100, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MES"
        '
        'nuddia
        '
        Me.nuddia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nuddia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuddia.ForeColor = System.Drawing.Color.Black
        Me.nuddia.Location = New System.Drawing.Point(24, 107)
        Me.nuddia.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nuddia.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nuddia.Name = "nuddia"
        Me.nuddia.Size = New System.Drawing.Size(64, 21)
        Me.nuddia.TabIndex = 3
        Me.nuddia.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudmes
        '
        Me.nudmes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nudmes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudmes.ForeColor = System.Drawing.Color.Black
        Me.nudmes.Location = New System.Drawing.Point(91, 107)
        Me.nudmes.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudmes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudmes.Name = "nudmes"
        Me.nudmes.Size = New System.Drawing.Size(69, 21)
        Me.nudmes.TabIndex = 4
        Me.nudmes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudano
        '
        Me.nudano.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nudano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudano.ForeColor = System.Drawing.Color.Black
        Me.nudano.Location = New System.Drawing.Point(162, 107)
        Me.nudano.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudano.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudano.Name = "nudano"
        Me.nudano.Size = New System.Drawing.Size(81, 21)
        Me.nudano.TabIndex = 5
        Me.nudano.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(21, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "INGRESE LOS DATOS SIGUIENTES EN DOS DIGITOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rbt3)
        Me.GroupBox1.Controls.Add(Me.rbt2)
        Me.GroupBox1.Controls.Add(Me.rbt1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(24, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 91)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECIONA EL TIPO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Martes, 27 de junio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Junio, 27 del 2017"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = " 27 de Junio del 2017"
        '
        'rbt3
        '
        Me.rbt3.AutoSize = True
        Me.rbt3.Location = New System.Drawing.Point(7, 67)
        Me.rbt3.Name = "rbt3"
        Me.rbt3.Size = New System.Drawing.Size(68, 19)
        Me.rbt3.TabIndex = 2
        Me.rbt3.Text = "TIPO 3"
        Me.rbt3.UseVisualStyleBackColor = True
        '
        'rbt2
        '
        Me.rbt2.AutoSize = True
        Me.rbt2.Location = New System.Drawing.Point(7, 43)
        Me.rbt2.Name = "rbt2"
        Me.rbt2.Size = New System.Drawing.Size(68, 19)
        Me.rbt2.TabIndex = 1
        Me.rbt2.Text = "TIPO 2"
        Me.rbt2.UseVisualStyleBackColor = True
        '
        'rbt1
        '
        Me.rbt1.AutoSize = True
        Me.rbt1.BackColor = System.Drawing.Color.Transparent
        Me.rbt1.Checked = True
        Me.rbt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbt1.Location = New System.Drawing.Point(7, 20)
        Me.rbt1.Name = "rbt1"
        Me.rbt1.Size = New System.Drawing.Size(68, 19)
        Me.rbt1.TabIndex = 0
        Me.rbt1.TabStop = True
        Me.rbt1.Text = "TIPO 1"
        Me.rbt1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(24, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "FECHA==>"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblfecha.Location = New System.Drawing.Point(106, 289)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(12, 15)
        Me.lblfecha.TabIndex = 9
        Me.lblfecha.Text = "-"
        '
        'btnfecha
        '
        Me.btnfecha.Location = New System.Drawing.Point(80, 253)
        Me.btnfecha.Name = "btnfecha"
        Me.btnfecha.Size = New System.Drawing.Size(105, 23)
        Me.btnfecha.TabIndex = 10
        Me.btnfecha.Text = "FECHA"
        Me.btnfecha.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ALG_FUNCIONESFECHASFRM.My.Resources.Resources.fondo3
        Me.ClientSize = New System.Drawing.Size(267, 313)
        Me.Controls.Add(Me.btnfecha)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudano)
        Me.Controls.Add(Me.nudmes)
        Me.Controls.Add(Me.nuddia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "PROGRAMA1"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveBorder
        CType(Me.nuddia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudmes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbt3 As RadioButton
    Friend WithEvents rbt2 As RadioButton
    Friend WithEvents rbt1 As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents lblfecha As Label
    Private WithEvents nuddia As NumericUpDown
    Private WithEvents nudmes As NumericUpDown
    Private WithEvents nudano As NumericUpDown
    Friend WithEvents btnfecha As Button
End Class
