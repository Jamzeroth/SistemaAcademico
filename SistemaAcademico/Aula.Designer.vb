<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aula))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.mesasAu = New System.Windows.Forms.TextBox()
        Me.guardar = New System.Windows.Forms.Button()
        Me.nomAu = New System.Windows.Forms.TextBox()
        Me.Caula = New System.Windows.Forms.TextBox()
        Me.bloAu = New System.Windows.Forms.TextBox()
        Me.pisoAu = New System.Windows.Forms.TextBox()
        Me.dimAu = New System.Windows.Forms.TextBox()
        Me.siAu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.bus = New System.Windows.Forms.ComboBox()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TablaDgv = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 71)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(633, 335)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.mesasAu)
        Me.TabPage1.Controls.Add(Me.guardar)
        Me.TabPage1.Controls.Add(Me.nomAu)
        Me.TabPage1.Controls.Add(Me.Caula)
        Me.TabPage1.Controls.Add(Me.bloAu)
        Me.TabPage1.Controls.Add(Me.pisoAu)
        Me.TabPage1.Controls.Add(Me.dimAu)
        Me.TabPage1.Controls.Add(Me.siAu)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(625, 309)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "INGRESAR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'mesasAu
        '
        Me.mesasAu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mesasAu.Location = New System.Drawing.Point(190, 209)
        Me.mesasAu.Name = "mesasAu"
        Me.mesasAu.Size = New System.Drawing.Size(111, 22)
        Me.mesasAu.TabIndex = 6
        '
        'guardar
        '
        Me.guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.Image = CType(resources.GetObject("guardar.Image"), System.Drawing.Image)
        Me.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardar.Location = New System.Drawing.Point(410, 128)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(114, 44)
        Me.guardar.TabIndex = 8
        Me.guardar.Text = "GUARDAR"
        Me.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.guardar.UseVisualStyleBackColor = True
        '
        'nomAu
        '
        Me.nomAu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomAu.Location = New System.Drawing.Point(190, 69)
        Me.nomAu.Name = "nomAu"
        Me.nomAu.Size = New System.Drawing.Size(111, 22)
        Me.nomAu.TabIndex = 1
        '
        'Caula
        '
        Me.Caula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Caula.Location = New System.Drawing.Point(190, 97)
        Me.Caula.Name = "Caula"
        Me.Caula.Size = New System.Drawing.Size(111, 22)
        Me.Caula.TabIndex = 2
        '
        'bloAu
        '
        Me.bloAu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bloAu.Location = New System.Drawing.Point(190, 125)
        Me.bloAu.Name = "bloAu"
        Me.bloAu.Size = New System.Drawing.Size(111, 22)
        Me.bloAu.TabIndex = 3
        '
        'pisoAu
        '
        Me.pisoAu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pisoAu.Location = New System.Drawing.Point(190, 153)
        Me.pisoAu.Name = "pisoAu"
        Me.pisoAu.Size = New System.Drawing.Size(111, 22)
        Me.pisoAu.TabIndex = 4
        '
        'dimAu
        '
        Me.dimAu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dimAu.Location = New System.Drawing.Point(190, 181)
        Me.dimAu.Name = "dimAu"
        Me.dimAu.Size = New System.Drawing.Size(111, 22)
        Me.dimAu.TabIndex = 5
        '
        'siAu
        '
        Me.siAu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siAu.Location = New System.Drawing.Point(190, 237)
        Me.siAu.Name = "siAu"
        Me.siAu.Size = New System.Drawing.Size(111, 22)
        Me.siAu.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Número de Mesas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(74, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Dimensiones:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(126, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Piso:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Bloque:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Capacidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Número de Sillas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "* Nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(126, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Ingresar Nueva Aula:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.bus)
        Me.TabPage2.Controls.Add(Me.buscar)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.TablaDgv)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(625, 309)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CONSULTAR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'bus
        '
        Me.bus.FormattingEnabled = True
        Me.bus.Items.AddRange(New Object() {"Nombre", "Codigo"})
        Me.bus.Location = New System.Drawing.Point(126, 54)
        Me.bus.Name = "bus"
        Me.bus.Size = New System.Drawing.Size(121, 24)
        Me.bus.TabIndex = 12
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(306, 54)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(162, 22)
        Me.buscar.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Buscar por:"
        '
        'TablaDgv
        '
        Me.TablaDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.TablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDgv.Location = New System.Drawing.Point(27, 108)
        Me.TablaDgv.Name = "TablaDgv"
        Me.TablaDgv.Size = New System.Drawing.Size(577, 143)
        Me.TablaDgv.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(234, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 46)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ELIJA LA OPCIÓN QUE DESEE"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(16, 412)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 54)
        Me.Button4.TabIndex = 20
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(489, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 38)
        Me.Label13.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(534, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 16)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Cerrar Sesión"
        '
        'Aula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 470)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Aula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aula"
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
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents TablaDgv As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents buscar As TextBox
    Friend WithEvents mesasAu As TextBox
    Friend WithEvents guardar As Button
    Friend WithEvents nomAu As TextBox
    Friend WithEvents Caula As TextBox
    Friend WithEvents bloAu As TextBox
    Friend WithEvents pisoAu As TextBox
    Friend WithEvents dimAu As TextBox
    Friend WithEvents siAu As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents bus As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
