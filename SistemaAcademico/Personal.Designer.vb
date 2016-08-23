<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Personal))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.fnPer = New System.Windows.Forms.DateTimePicker()
        Me.carPer = New System.Windows.Forms.TextBox()
        Me.guardar = New System.Windows.Forms.Button()
        Me.nomPer = New System.Windows.Forms.TextBox()
        Me.dirPer = New System.Windows.Forms.TextBox()
        Me.telPer = New System.Windows.Forms.TextBox()
        Me.emailPer = New System.Windows.Forms.TextBox()
        Me.CiPer = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.bus = New System.Windows.Forms.ComboBox()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TablaDgv = New System.Windows.Forms.DataGridView()
        Me.Consultar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 86)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(633, 373)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.fnPer)
        Me.TabPage1.Controls.Add(Me.carPer)
        Me.TabPage1.Controls.Add(Me.guardar)
        Me.TabPage1.Controls.Add(Me.nomPer)
        Me.TabPage1.Controls.Add(Me.dirPer)
        Me.TabPage1.Controls.Add(Me.telPer)
        Me.TabPage1.Controls.Add(Me.emailPer)
        Me.TabPage1.Controls.Add(Me.CiPer)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(625, 347)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "INGRESAR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'fnPer
        '
        Me.fnPer.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fnPer.Location = New System.Drawing.Point(163, 141)
        Me.fnPer.Name = "fnPer"
        Me.fnPer.Size = New System.Drawing.Size(100, 20)
        Me.fnPer.TabIndex = 3
        '
        'carPer
        '
        Me.carPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carPer.Location = New System.Drawing.Point(162, 257)
        Me.carPer.Name = "carPer"
        Me.carPer.Size = New System.Drawing.Size(220, 22)
        Me.carPer.TabIndex = 7
        '
        'guardar
        '
        Me.guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.Image = CType(resources.GetObject("guardar.Image"), System.Drawing.Image)
        Me.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardar.Location = New System.Drawing.Point(208, 294)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(117, 47)
        Me.guardar.TabIndex = 8
        Me.guardar.Text = "GUARDAR"
        Me.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.guardar.UseVisualStyleBackColor = True
        '
        'nomPer
        '
        Me.nomPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomPer.Location = New System.Drawing.Point(162, 112)
        Me.nomPer.Name = "nomPer"
        Me.nomPer.Size = New System.Drawing.Size(284, 22)
        Me.nomPer.TabIndex = 2
        '
        'dirPer
        '
        Me.dirPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dirPer.Location = New System.Drawing.Point(162, 167)
        Me.dirPer.Name = "dirPer"
        Me.dirPer.Size = New System.Drawing.Size(284, 22)
        Me.dirPer.TabIndex = 4
        '
        'telPer
        '
        Me.telPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telPer.Location = New System.Drawing.Point(162, 197)
        Me.telPer.Name = "telPer"
        Me.telPer.Size = New System.Drawing.Size(121, 22)
        Me.telPer.TabIndex = 5
        '
        'emailPer
        '
        Me.emailPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailPer.Location = New System.Drawing.Point(162, 225)
        Me.emailPer.Name = "emailPer"
        Me.emailPer.Size = New System.Drawing.Size(284, 22)
        Me.emailPer.TabIndex = 6
        '
        'CiPer
        '
        Me.CiPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiPer.Location = New System.Drawing.Point(162, 82)
        Me.CiPer.Name = "CiPer"
        Me.CiPer.Size = New System.Drawing.Size(121, 22)
        Me.CiPer.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Cargo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "E-mail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Teléfono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Dirección:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Fecha Nacimiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "* Cédula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "* Nombres y Apellidos:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(171, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 16)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Ingresar Nueva Persona"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.bus)
        Me.TabPage2.Controls.Add(Me.buscar)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TablaDgv)
        Me.TabPage2.Controls.Add(Me.Consultar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(625, 347)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CONSULTAR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'bus
        '
        Me.bus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bus.FormattingEnabled = True
        Me.bus.Items.AddRange(New Object() {"Cédula", "Nombre", "Cargo"})
        Me.bus.Location = New System.Drawing.Point(115, 50)
        Me.bus.Name = "bus"
        Me.bus.Size = New System.Drawing.Size(137, 24)
        Me.bus.TabIndex = 1
        Me.bus.Text = "Seleccione opción"
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(280, 50)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(162, 22)
        Me.buscar.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Buscar por:"
        '
        'TablaDgv
        '
        Me.TablaDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.TablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDgv.Location = New System.Drawing.Point(27, 108)
        Me.TablaDgv.Name = "TablaDgv"
        Me.TablaDgv.Size = New System.Drawing.Size(559, 143)
        Me.TablaDgv.TabIndex = 10
        '
        'Consultar
        '
        Me.Consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consultar.Image = CType(resources.GetObject("Consultar.Image"), System.Drawing.Image)
        Me.Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Consultar.Location = New System.Drawing.Point(225, 270)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(143, 47)
        Me.Consultar.TabIndex = 3
        Me.Consultar.Text = "CONSULTAR"
        Me.Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Consultar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ELIJA LA OPCIÓN QUE DESEE"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(12, 461)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 55)
        Me.Button2.TabIndex = 25
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(506, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "user"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(551, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Cerrar Sesión"
        '
        'Label13
        '
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(501, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 39)
        Me.Label13.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(498, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 48)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "MODIFICAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 522)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Personal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents carPer As TextBox
    Friend WithEvents guardar As Button
    Friend WithEvents nomPer As TextBox
    Friend WithEvents dirPer As TextBox
    Friend WithEvents telPer As TextBox
    Friend WithEvents emailPer As TextBox
    Friend WithEvents CiPer As TextBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents buscar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents bus As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents fnPer As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
End Class
