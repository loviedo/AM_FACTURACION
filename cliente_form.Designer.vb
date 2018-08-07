'
' Created by SharpDevelop.
' User: loviedo
' Date: 27/5/2018
' Time: 12:31
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class cliente_form
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
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.label6 = New System.Windows.Forms.Label()
		Me.textBox5 = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.textBox4 = New System.Windows.Forms.TextBox()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.textBox6 = New System.Windows.Forms.TextBox()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.button3)
		Me.panel1.Controls.Add(Me.button2)
		Me.panel1.Location = New System.Drawing.Point(12, 558)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(762, 54)
		Me.panel1.TabIndex = 0
		'
		'button3
		'
		Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button3.Location = New System.Drawing.Point(64, 6)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(204, 43)
		Me.button3.TabIndex = 1
		Me.button3.Text = "Cancelar"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'button2
		'
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(483, 6)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(208, 43)
		Me.button2.TabIndex = 0
		Me.button2.Text = "Cargar datos"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'panel2
		'
		Me.panel2.Controls.Add(Me.textBox6)
		Me.panel2.Controls.Add(Me.label6)
		Me.panel2.Controls.Add(Me.textBox5)
		Me.panel2.Controls.Add(Me.label4)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.label5)
		Me.panel2.Controls.Add(Me.label2)
		Me.panel2.Controls.Add(Me.label1)
		Me.panel2.Controls.Add(Me.textBox4)
		Me.panel2.Controls.Add(Me.textBox3)
		Me.panel2.Controls.Add(Me.textBox2)
		Me.panel2.Controls.Add(Me.dataGridView1)
		Me.panel2.Controls.Add(Me.textBox1)
		Me.panel2.Controls.Add(Me.button1)
		Me.panel2.Location = New System.Drawing.Point(12, 12)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(762, 494)
		Me.panel2.TabIndex = 1
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(16, 45)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(162, 29)
		Me.label6.TabIndex = 14
		Me.label6.Text = "Buscar por RUC"
		'
		'textBox5
		'
		Me.textBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox5.Location = New System.Drawing.Point(184, 42)
		Me.textBox5.Name = "textBox5"
		Me.textBox5.Size = New System.Drawing.Size(197, 24)
		Me.textBox5.TabIndex = 13
		Me.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me.textBox5.TextChanged, AddressOf Me.TextBox5TextChanged
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(482, 450)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(60, 29)
		Me.label4.TabIndex = 12
		Me.label4.Text = "TEL:"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(190, 449)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(80, 29)
		Me.label3.TabIndex = 11
		Me.label3.Text = "RUC:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(149, 417)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(121, 29)
		Me.label5.TabIndex = 10
		Me.label5.Text = "CLIENTE:"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(12, 418)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(130, 29)
		Me.label2.TabIndex = 9
		Me.label2.Text = "Seleccionado: "
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(16, 15)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(162, 29)
		Me.label1.TabIndex = 8
		Me.label1.Text = "Buscar por Nombre"
		'
		'textBox4
		'
		Me.textBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox4.Location = New System.Drawing.Point(184, 12)
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(197, 24)
		Me.textBox4.TabIndex = 7
		Me.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me.textBox4.TextChanged, AddressOf Me.TextBox4TextChanged
		'
		'textBox3
		'
		Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox3.Location = New System.Drawing.Point(548, 455)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(200, 24)
		Me.textBox3.TabIndex = 6
		'
		'textBox2
		'
		Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox2.Location = New System.Drawing.Point(276, 454)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(200, 24)
		Me.textBox2.TabIndex = 5
		'
		'dataGridView1
		'
		Me.dataGridView1.AllowUserToAddRows = false
		Me.dataGridView1.AllowUserToDeleteRows = false
		Me.dataGridView1.AllowUserToOrderColumns = true
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(12, 75)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.ReadOnly = true
		Me.dataGridView1.Size = New System.Drawing.Size(736, 337)
		Me.dataGridView1.TabIndex = 4
		AddHandler Me.dataGridView1.CellContentClick, AddressOf Me.DataGridView1CellContentClick
		'
		'textBox1
		'
		Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.Location = New System.Drawing.Point(276, 418)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(200, 24)
		Me.textBox1.TabIndex = 1
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(583, 9)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(165, 60)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Agregar Cliente"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'textBox6
		'
		Me.textBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox6.Location = New System.Drawing.Point(548, 422)
		Me.textBox6.Name = "textBox6"
		Me.textBox6.Size = New System.Drawing.Size(200, 24)
		Me.textBox6.TabIndex = 15
		'
		'cliente_form
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(786, 624)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "cliente_form"
		Me.Text = "cliente_form"
		AddHandler Load, AddressOf Me.Cliente_formLoad
		Me.panel1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Public textBox6 As System.Windows.Forms.TextBox
	Private textBox5 As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private button3 As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private textBox4 As System.Windows.Forms.TextBox
	Public textBox2 As System.Windows.Forms.TextBox
	Public textBox3 As System.Windows.Forms.TextBox
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private button2 As System.Windows.Forms.Button
	Public textBox1 As System.Windows.Forms.TextBox
	Private button1 As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
End Class
