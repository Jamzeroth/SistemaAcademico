<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profesor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.fnPro = New System.Windows.Forms.DateTimePicker()
        Me.titPro = New System.Windows.Forms.TextBox()
        Me.sueldo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.guardar = New System.Windows.Forms.Button()
        Me.nompro = New System.Windows.Forms.TextBox()
        Me.dirPro = New System.Windows.Forms.TextBox()
        Me.telPro = New System.Windows.Forms.TextBox()
        Me.emailPro = New System.Windows.Forms.TextBox()
        Me.Cipro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.bus = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TablaDgv = New System.Windows.Forms.DataGridView()
        Me.Consultar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ELIJA LA OPCIÓN QUE DESEE"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 84)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(490, 389)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.fnPro)
        Me.TabPage1.Controls.Add(Me.titPro)
        Me.TabPage1.Controls.Add(Me.sueldo)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.guardar)
        Me.TabPage1.Controls.Add(Me.nompro)
        Me.TabPage1.Controls.Add(Me.dirPro)
        Me.TabPage1.Controls.Add(Me.telPro)
        Me.TabPage1.Controls.Add(Me.emailPro)
        Me.TabPage1.Controls.Add(Me.Cipro)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(482, 363)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "INGRESAR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'fnPro
        '
        Me.fnPro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fnPro.Location = New System.Drawing.Point(158, 118)
        Me.fnPro.Name = "fnPro"
        Me.fnPro.Size = New System.Drawing.Size(106, 22)
        Me.fnPro.TabIndex = 3
        '
        'titPro
        '
        Me.titPro.Location = New System.Drawing.Point(161, 234)
        Me.titPro.Name = "titPro"
        Me.titPro.Size = New System.Drawing.Size(220, 22)
        Me.titPro.TabIndex = 7
        '
        'sueldo
        '
        Me.sueldo.Location = New System.Drawing.Point(161, 267)
        Me.sueldo.Name = "sueldo"
        Me.sueldo.Size = New System.Drawing.Size(67, 22)
        Me.sueldo.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(101, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 16)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Sueldo:"
        '
        'guardar
        '
        Me.guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.Image = CType(resources.GetObject("guardar.Image"), System.Drawing.Image)
        Me.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardar.Location = New System.Drawing.Point(178, 308)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(113, 49)
        Me.guardar.TabIndex = 9
        Me.guardar.Text = "GUARDAR"
        Me.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.guardar.UseVisualStyleBackColor = True
        '
        'nompro
        '
        Me.nompro.Location = New System.Drawing.Point(161, 89)
        Me.nompro.Name = "nompro"
        Me.nompro.Size = New System.Drawing.Size(284, 22)
        Me.nompro.TabIndex = 2
        '
        'dirPro
        '
        Me.dirPro.Location = New System.Drawing.Point(161, 144)
        Me.dirPro.Name = "dirPro"
        Me.dirPro.Size = New System.Drawing.Size(284, 22)
        Me.dirPro.TabIndex = 4
        '
        'telPro
        '
        Me.telPro.Location = New System.Drawing.Point(161, 170)
        Me.telPro.Name = "telPro"
        Me.telPro.Size = New System.Drawing.Size(121, 22)
        Me.telPro.TabIndex = 5
        '
        'emailPro
        '
        Me.emailPro.Location = New System.Drawing.Point(161, 202)
        Me.emailPro.Name = "emailPro"
        Me.emailPro.Size = New System.Drawing.Size(284, 22)
        Me.emailPro.TabIndex = 6
        '
        'Cipro
        '
        Me.Cipro.Location = New System.Drawing.Point(161, 59)
        Me.Cipro.Name = "Cipro"
        Me.Cipro.Size = New System.Drawing.Size(121, 22)
        Me.Cipro.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(111, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Título:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "E-mail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Teléfono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Dirección:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Fecha Nacimiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "* Cédula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "* Nombres y Apellidos:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(146, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 16)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Ingresar Nuevo Profesor"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.buscar)
        Me.TabPage2.Controls.Add(Me.bus)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.TablaDgv)
        Me.TabPage2.Controls.Add(Me.Consultar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(482, 363)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CONSULTAR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(272, 42)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(162, 22)
        Me.buscar.TabIndex = 2
        '
        'bus
        '
        Me.bus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bus.FormattingEnabled = True
        Me.bus.Items.AddRange(New Object() {"Cédula", "Nombre", "Asignatura"})
        Me.bus.Location = New System.Drawing.Point(115, 40)
        Me.bus.Name = "bus"
        Me.bus.Size = New System.Drawing.Size(137, 24)
        Me.bus.TabIndex = 1
        Me.bus.Text = "Seleccione opción"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(33, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Buscar por:"
        '
        'TablaDgv
        '
        Me.TablaDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.TablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDgv.Location = New System.Drawing.Point(36, 109)
        Me.TablaDgv.Name = "TablaDgv"
        Me.TablaDgv.Size = New System.Drawing.Size(407, 143)
        Me.TablaDgv.TabIndex = 10
        '
        'Consultar
        '
        Me.Consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consultar.Image = CType(resources.GetObject("Consultar.Image"), System.Drawing.Image)
        Me.Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Consultar.Location = New System.Drawing.Point(170, 284)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(138, 48)
        Me.Consultar.TabIndex = 3
        Me.Consultar.Text = "CONSULTAR"
        Me.Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Consultar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(12, 482)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 55)
        Me.Button2.TabIndex = 25
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(395, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Cerrar Sesión"
        '
        'Label13
        '
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(350, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 39)
        Me.Label13.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(378, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 16)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "user"
        '
        'Profesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 544)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Profesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profesor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents titPro As TextBox
    Friend WithEvents sueldo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents guardar As Button
    Friend WithEvents nompro As TextBox
    Friend WithEvents dirPro As TextBox
    Friend WithEvents telPro As TextBox
    Friend WithEvents emailPro As TextBox
    Friend WithEvents Cipro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TablaDgv As DataGridView
    Friend WithEvents Consultar As Button
    Friend WithEvents buscar As TextBox
    Friend WithEvents bus As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents fnPro As DateTimePicker
End Class
