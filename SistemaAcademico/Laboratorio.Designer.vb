<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laboratorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laboratorio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tipLab = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.maqLab = New System.Windows.Forms.TextBox()
        Me.guardar = New System.Windows.Forms.Button()
        Me.nomLab = New System.Windows.Forms.TextBox()
        Me.capLab = New System.Windows.Forms.TextBox()
        Me.bloLab = New System.Windows.Forms.TextBox()
        Me.piLab = New System.Windows.Forms.TextBox()
        Me.dimLab = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.bus = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TablaDgv = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ELIJA LA OPCIÓN QUE DESEE"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 89)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(633, 335)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tipLab)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.maqLab)
        Me.TabPage1.Controls.Add(Me.guardar)
        Me.TabPage1.Controls.Add(Me.nomLab)
        Me.TabPage1.Controls.Add(Me.capLab)
        Me.TabPage1.Controls.Add(Me.bloLab)
        Me.TabPage1.Controls.Add(Me.piLab)
        Me.TabPage1.Controls.Add(Me.dimLab)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(625, 309)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "INGRESAR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tipLab
        '
        Me.tipLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipLab.FormattingEnabled = True
        Me.tipLab.Items.AddRange(New Object() {"Química", "Física", "Informática", "Anatomía", "Circuitos"})
        Me.tipLab.Location = New System.Drawing.Point(165, 264)
        Me.tipLab.Name = "tipLab"
        Me.tipLab.Size = New System.Drawing.Size(159, 24)
        Me.tipLab.TabIndex = 7
        Me.tipLab.Text = "Seleccione tipo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(151, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 16)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Ingresar Nuevo Laboratorio:"
        '
        'maqLab
        '
        Me.maqLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maqLab.Location = New System.Drawing.Point(164, 224)
        Me.maqLab.Name = "maqLab"
        Me.maqLab.Size = New System.Drawing.Size(110, 22)
        Me.maqLab.TabIndex = 6
        '
        'guardar
        '
        Me.guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.Image = CType(resources.GetObject("guardar.Image"), System.Drawing.Image)
        Me.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardar.Location = New System.Drawing.Point(419, 150)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(113, 46)
        Me.guardar.TabIndex = 8
        Me.guardar.Text = "GUARDAR"
        Me.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.guardar.UseVisualStyleBackColor = True
        '
        'nomLab
        '
        Me.nomLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomLab.Location = New System.Drawing.Point(164, 50)
        Me.nomLab.Name = "nomLab"
        Me.nomLab.Size = New System.Drawing.Size(110, 22)
        Me.nomLab.TabIndex = 1
        '
        'capLab
        '
        Me.capLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.capLab.Location = New System.Drawing.Point(164, 83)
        Me.capLab.Name = "capLab"
        Me.capLab.Size = New System.Drawing.Size(110, 22)
        Me.capLab.TabIndex = 2
        '
        'bloLab
        '
        Me.bloLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bloLab.Location = New System.Drawing.Point(164, 122)
        Me.bloLab.Name = "bloLab"
        Me.bloLab.Size = New System.Drawing.Size(110, 22)
        Me.bloLab.TabIndex = 3
        '
        'piLab
        '
        Me.piLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.piLab.Location = New System.Drawing.Point(164, 160)
        Me.piLab.Name = "piLab"
        Me.piLab.Size = New System.Drawing.Size(110, 22)
        Me.piLab.TabIndex = 4
        '
        'dimLab
        '
        Me.dimLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dimLab.Location = New System.Drawing.Point(164, 192)
        Me.dimLab.Name = "dimLab"
        Me.dimLab.Size = New System.Drawing.Size(138, 22)
        Me.dimLab.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 16)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Número de Máquinas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(71, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Dimensiones:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(123, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Piso:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(107, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Bloque:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Capacidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "* Nombre:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.buscar)
        Me.TabPage2.Controls.Add(Me.bus)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.TablaDgv)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(625, 309)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CONSULTAR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(314, 51)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(162, 22)
        Me.buscar.TabIndex = 2
        '
        'bus
        '
        Me.bus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bus.FormattingEnabled = True
        Me.bus.Items.AddRange(New Object() {"Nombre", "Bloque", "Piso"})
        Me.bus.Location = New System.Drawing.Point(126, 51)
        Me.bus.Name = "bus"
        Me.bus.Size = New System.Drawing.Size(138, 24)
        Me.bus.TabIndex = 1
        Me.bus.Text = "Seleccione opción"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Button1.Location = New System.Drawing.Point(246, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(510, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 39)
        Me.Label10.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(17, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 55)
        Me.Button2.TabIndex = 22
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(549, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 16)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Cerrar Sesión"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(503, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "user"
        '
        'Laboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 488)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Laboratorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laboratorio"
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
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents buscar As TextBox
    Friend WithEvents bus As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TablaDgv As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents tipLab As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents maqLab As TextBox
    Friend WithEvents guardar As Button
    Friend WithEvents nomLab As TextBox
    Friend WithEvents capLab As TextBox
    Friend WithEvents bloLab As TextBox
    Friend WithEvents piLab As TextBox
    Friend WithEvents dimLab As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
End Class
