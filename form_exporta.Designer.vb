'
' Created by SharpDevelop.
' User: loviedo
' Date: 16/6/2018
' Time: 18:56
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form_exporta
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.Facturacion = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.button3 = New System.Windows.Forms.Button()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.fec_hasta = New System.Windows.Forms.DateTimePicker()
		Me.fec_desde = New System.Windows.Forms.DateTimePicker()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.button1 = New System.Windows.Forms.Button()
		Me.tabPage2 = New System.Windows.Forms.TabPage()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.button2 = New System.Windows.Forms.Button()
		Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		Me.Facturacion.SuspendLayout
		Me.tabPage1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.panel1.SuspendLayout
		Me.tabPage2.SuspendLayout
		Me.panel3.SuspendLayout
		Me.SuspendLayout
		'
		'Facturacion
		'
		Me.Facturacion.Controls.Add(Me.tabPage1)
		Me.Facturacion.Controls.Add(Me.tabPage2)
		Me.Facturacion.Location = New System.Drawing.Point(12, 12)
		Me.Facturacion.Name = "Facturacion"
		Me.Facturacion.SelectedIndex = 0
		Me.Facturacion.Size = New System.Drawing.Size(562, 440)
		Me.Facturacion.TabIndex = 4
		'
		'tabPage1
		'
		Me.tabPage1.Controls.Add(Me.panel2)
		Me.tabPage1.Controls.Add(Me.panel1)
		Me.tabPage1.Location = New System.Drawing.Point(4, 22)
		Me.tabPage1.Name = "tabPage1"
		Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage1.Size = New System.Drawing.Size(554, 414)
		Me.tabPage1.TabIndex = 0
		Me.tabPage1.Text = "tabPage1"
		Me.tabPage1.UseVisualStyleBackColor = true
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.button3)
		Me.panel2.Controls.Add(Me.textBox1)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.label2)
		Me.panel2.Controls.Add(Me.label1)
		Me.panel2.Controls.Add(Me.fec_hasta)
		Me.panel2.Controls.Add(Me.fec_desde)
		Me.panel2.Location = New System.Drawing.Point(6, 6)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(542, 246)
		Me.panel2.TabIndex = 5
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(326, 173)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(102, 23)
		Me.button3.TabIndex = 6
		Me.button3.Text = "SELECCIONAR"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'textBox1
		'
		Me.textBox1.HideSelection = false
		Me.textBox1.Location = New System.Drawing.Point(141, 147)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(287, 20)
		Me.textBox1.TabIndex = 5d
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(41, 150)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(74, 26)
		Me.label3.TabIndex = 4
		Me.label3.Text = "Guardar en:"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(79, 72)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 3
		Me.label2.Text = "Fecha Hasta:"
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(79, 36)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 2
		Me.label1.Text = "Fecha Desde:"
		'
		'fec_hasta
		'
		Me.fec_hasta.Location = New System.Drawing.Point(228, 72)
		Me.fec_hasta.Name = "fec_hasta"
		Me.fec_hasta.Size = New System.Drawing.Size(200, 20)
		Me.fec_hasta.TabIndex = 1
		'
		'fec_desde
		'
		Me.fec_desde.Location = New System.Drawing.Point(228, 36)
		Me.fec_desde.Name = "fec_desde"
		Me.fec_desde.Size = New System.Drawing.Size(200, 20)
		Me.fec_desde.TabIndex = 0
		Me.fec_desde.Value = New Date(2018, 6, 11, 0, 0, 0, 0)
		'
		'panel1
		'
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.button1)
		Me.panel1.Cursor = System.Windows.Forms.Cursors.Default
		Me.panel1.Location = New System.Drawing.Point(6, 340)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(542, 68)
		Me.panel1.TabIndex = 4
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(342, 3)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(183, 43)
		Me.button1.TabIndex = 1
		Me.button1.Text = "Exportar Listado"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'tabPage2
		'
		Me.tabPage2.Controls.Add(Me.panel3)
		Me.tabPage2.Location = New System.Drawing.Point(4, 22)
		Me.tabPage2.Name = "tabPage2"
		Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage2.Size = New System.Drawing.Size(554, 414)
		Me.tabPage2.TabIndex = 1
		Me.tabPage2.Text = "tabPage2"
		Me.tabPage2.UseVisualStyleBackColor = true
		'
		'panel3
		'
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel3.Controls.Add(Me.button2)
		Me.panel3.Cursor = System.Windows.Forms.Cursors.Default
		Me.panel3.Location = New System.Drawing.Point(6, 138)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(542, 103)
		Me.panel3.TabIndex = 5
		'
		'button2
		'
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(134, 31)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(268, 43)
		Me.button2.TabIndex = 1
		Me.button2.Text = "Exportar Listado de Clientes"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'form_exporta
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(586, 464)
		Me.Controls.Add(Me.Facturacion)
		Me.Name = "form_exporta"
		Me.Text = "Seleccionar"
		AddHandler Load, AddressOf Me.Form_exportaLoad
		Me.Facturacion.ResumeLayout(false)
		Me.tabPage1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.panel1.ResumeLayout(false)
		Me.tabPage2.ResumeLayout(false)
		Me.panel3.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
	Private label3 As System.Windows.Forms.Label
	Private textBox1 As System.Windows.Forms.TextBox
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private panel3 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private tabPage2 As System.Windows.Forms.TabPage
	Private fec_desde As System.Windows.Forms.DateTimePicker
	Private fec_hasta As System.Windows.Forms.DateTimePicker
	Private tabPage1 As System.Windows.Forms.TabPage
	Private Facturacion As System.Windows.Forms.TabControl
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	Private button1 As System.Windows.Forms.Button
End Class
