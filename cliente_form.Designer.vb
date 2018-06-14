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
		Me.button2 = New System.Windows.Forms.Button()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.textBox4 = New System.Windows.Forms.TextBox()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.button3 = New System.Windows.Forms.Button()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.Controls.Add(Me.button3)
		Me.panel1.Controls.Add(Me.button2)
		Me.panel1.Location = New System.Drawing.Point(12, 512)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(762, 100)
		Me.panel1.TabIndex = 0
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(511, 32)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(204, 24)
		Me.button2.TabIndex = 0
		Me.button2.Text = "Cargar datos"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'panel2
		'
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
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(12, 10)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(114, 20)
		Me.label1.TabIndex = 8
		Me.label1.Text = "Buscar Nombre"
		'
		'textBox4
		'
		Me.textBox4.Location = New System.Drawing.Point(132, 10)
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(197, 20)
		Me.textBox4.TabIndex = 7
		AddHandler Me.textBox4.TextChanged, AddressOf Me.TextBox4TextChanged
		'
		'textBox3
		'
		Me.textBox3.Location = New System.Drawing.Point(131, 461)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(200, 20)
		Me.textBox3.TabIndex = 6
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(131, 435)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(200, 20)
		Me.textBox2.TabIndex = 5
		'
		'dataGridView1
		'
		Me.dataGridView1.AllowUserToAddRows = false
		Me.dataGridView1.AllowUserToDeleteRows = false
		Me.dataGridView1.AllowUserToOrderColumns = true
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(12, 52)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.ReadOnly = true
		Me.dataGridView1.Size = New System.Drawing.Size(603, 284)
		Me.dataGridView1.TabIndex = 4
		AddHandler Me.dataGridView1.CellContentClick, AddressOf Me.DataGridView1CellContentClick
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(131, 408)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(200, 20)
		Me.textBox1.TabIndex = 1
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(547, 432)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(125, 23)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Agregar Cliente"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(88, 32)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(204, 24)
		Me.button3.TabIndex = 1
		Me.button3.Text = "Cancelar"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
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
