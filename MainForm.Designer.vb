'
' Created by SharpDevelop.
' User: loviedo
' Date: 26/5/2018
' Time: 23:09
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.button2 = New System.Windows.Forms.Button()
		Me.tx_ticket = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.button1 = New System.Windows.Forms.Button()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tx_tel_cliente = New System.Windows.Forms.TextBox()
		Me.tx_ruc_cliente = New System.Windows.Forms.TextBox()
		Me.button4 = New System.Windows.Forms.Button()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.checito = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.button3 = New System.Windows.Forms.Button()
		Me.tx_nom_cliente = New System.Windows.Forms.TextBox()
		Me.button5 = New System.Windows.Forms.Button()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.tx_id_c = New System.Windows.Forms.TextBox()
		Me.button6 = New System.Windows.Forms.Button()
		Me.printDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.printDialog1 = New System.Windows.Forms.PrintDialog()
		Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.panel4.SuspendLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel3.SuspendLayout
		Me.SuspendLayout
		'
		'button2
		'
		Me.button2.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(13, 3)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(125, 44)
		Me.button2.TabIndex = 2
		Me.button2.Text = "Cerrar"
		Me.button2.UseVisualStyleBackColor = false
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'tx_ticket
		'
		Me.tx_ticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_ticket.Location = New System.Drawing.Point(156, 21)
		Me.tx_ticket.Name = "tx_ticket"
		Me.tx_ticket.Size = New System.Drawing.Size(114, 26)
		Me.tx_ticket.TabIndex = 0
		Me.tx_ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(17, 12)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(121, 40)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Ticket N°:"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(276, 21)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(112, 26)
		Me.button1.TabIndex = 1
		Me.button1.Text = "Buscar"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.button2)
		Me.panel1.Location = New System.Drawing.Point(12, 571)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(987, 53)
		Me.panel1.TabIndex = 4
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.panel4)
		Me.panel2.Controls.Add(Me.label4)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.label2)
		Me.panel2.Controls.Add(Me.tx_tel_cliente)
		Me.panel2.Controls.Add(Me.tx_ruc_cliente)
		Me.panel2.Controls.Add(Me.button4)
		Me.panel2.Controls.Add(Me.dataGridView1)
		Me.panel2.Controls.Add(Me.button3)
		Me.panel2.Controls.Add(Me.tx_nom_cliente)
		Me.panel2.Location = New System.Drawing.Point(12, 84)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(987, 481)
		Me.panel2.TabIndex = 5
		'
		'panel4
		'
		Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel4.Controls.Add(Me.label8)
		Me.panel4.Controls.Add(Me.label7)
		Me.panel4.Controls.Add(Me.label6)
		Me.panel4.Controls.Add(Me.textBox1)
		Me.panel4.Controls.Add(Me.label5)
		Me.panel4.Location = New System.Drawing.Point(616, 14)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(366, 100)
		Me.panel4.TabIndex = 9
		'
		'label8
		'
		Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label8.Location = New System.Drawing.Point(209, 54)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(145, 29)
		Me.label8.TabIndex = 11
		Me.label8.Text = "label8"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label7
		'
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.Location = New System.Drawing.Point(74, 54)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(129, 29)
		Me.label7.TabIndex = 10
		Me.label7.Text = "label7"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(3, 54)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(75, 29)
		Me.label6.TabIndex = 9
		Me.label6.Text = "NRO:"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'textBox1
		'
		Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.Location = New System.Drawing.Point(209, 12)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.ShortcutsEnabled = false
		Me.textBox1.Size = New System.Drawing.Size(145, 26)
		Me.textBox1.TabIndex = 8
		Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me.textBox1.TextChanged, AddressOf Me.TextBox1TextChanged
		AddHandler Me.textBox1.KeyPress, AddressOf Me.TextBox1KeyPress
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(3, 10)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(177, 29)
		Me.label5.TabIndex = 7
		Me.label5.Text = "FACTURA NRO:"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(65, 83)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(73, 29)
		Me.label4.TabIndex = 8
		Me.label4.Text = "TEL:"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(58, 48)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(80, 29)
		Me.label3.TabIndex = 7
		Me.label3.Text = "RUC:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(17, 13)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(121, 29)
		Me.label2.TabIndex = 6
		Me.label2.Text = "CLIENTE:"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_tel_cliente
		'
		Me.tx_tel_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_tel_cliente.Location = New System.Drawing.Point(156, 83)
		Me.tx_tel_cliente.Multiline = true
		Me.tx_tel_cliente.Name = "tx_tel_cliente"
		Me.tx_tel_cliente.Size = New System.Drawing.Size(321, 29)
		Me.tx_tel_cliente.TabIndex = 5
		Me.tx_tel_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tx_ruc_cliente
		'
		Me.tx_ruc_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_ruc_cliente.Location = New System.Drawing.Point(156, 48)
		Me.tx_ruc_cliente.Multiline = true
		Me.tx_ruc_cliente.Name = "tx_ruc_cliente"
		Me.tx_ruc_cliente.Size = New System.Drawing.Size(321, 29)
		Me.tx_ruc_cliente.TabIndex = 4
		Me.tx_ruc_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'button4
		'
		Me.button4.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button4.Location = New System.Drawing.Point(777, 438)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(194, 38)
		Me.button4.TabIndex = 3
		Me.button4.Text = "IMPRIMIR"
		Me.button4.UseVisualStyleBackColor = false
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'dataGridView1
		'
		Me.dataGridView1.AllowUserToAddRows = false
		Me.dataGridView1.AllowUserToDeleteRows = false
		Me.dataGridView1.AllowUserToOrderColumns = true
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.checito})
		Me.dataGridView1.Location = New System.Drawing.Point(3, 120)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(979, 312)
		Me.dataGridView1.TabIndex = 3
		AddHandler Me.dataGridView1.CellContentClick, AddressOf Me.DataGridView1CellContentClick
		'
		'checito
		'
		Me.checito.HeaderText = "Seleccionar"
		Me.checito.Name = "checito"
		Me.checito.ToolTipText = "Chequear para seleccionar item"
		'
		'button3
		'
		Me.button3.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button3.Location = New System.Drawing.Point(483, 14)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(127, 101)
		Me.button3.TabIndex = 2
		Me.button3.Text = "Buscar Cliente"
		Me.button3.UseVisualStyleBackColor = false
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'tx_nom_cliente
		'
		Me.tx_nom_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_nom_cliente.Location = New System.Drawing.Point(156, 13)
		Me.tx_nom_cliente.Multiline = true
		Me.tx_nom_cliente.Name = "tx_nom_cliente"
		Me.tx_nom_cliente.Size = New System.Drawing.Size(321, 29)
		Me.tx_nom_cliente.TabIndex = 1
		Me.tx_nom_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'button5
		'
		Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button5.Location = New System.Drawing.Point(826, 15)
		Me.button5.Name = "button5"
		Me.button5.Size = New System.Drawing.Size(145, 37)
		Me.button5.TabIndex = 6
		Me.button5.Text = "Exportar Excel"
		Me.button5.UseVisualStyleBackColor = true
		AddHandler Me.button5.Click, AddressOf Me.Button5Click
		'
		'panel3
		'
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel3.Controls.Add(Me.tx_id_c)
		Me.panel3.Controls.Add(Me.button6)
		Me.panel3.Controls.Add(Me.button5)
		Me.panel3.Controls.Add(Me.button1)
		Me.panel3.Controls.Add(Me.label1)
		Me.panel3.Controls.Add(Me.tx_ticket)
		Me.panel3.Location = New System.Drawing.Point(12, 12)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(987, 66)
		Me.panel3.TabIndex = 6
		'
		'tx_id_c
		'
		Me.tx_id_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_id_c.Location = New System.Drawing.Point(428, 18)
		Me.tx_id_c.Multiline = true
		Me.tx_id_c.Name = "tx_id_c"
		Me.tx_id_c.Size = New System.Drawing.Size(170, 29)
		Me.tx_id_c.TabIndex = 10
		Me.tx_id_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.tx_id_c.Visible = false
		'
		'button6
		'
		Me.button6.Location = New System.Drawing.Point(616, 15)
		Me.button6.Name = "button6"
		Me.button6.Size = New System.Drawing.Size(176, 23)
		Me.button6.TabIndex = 7
		Me.button6.Text = "test funcion nro a palabra"
		Me.button6.UseVisualStyleBackColor = true
		Me.button6.Visible = false
		AddHandler Me.button6.Click, AddressOf Me.Button6Click
		'
		'printDocument1
		'
		AddHandler Me.printDocument1.PrintPage, AddressOf Me.PrintDocument1PrintPage
		'
		'printDialog1
		'
		Me.printDialog1.UseEXDialog = true
		'
		'printPreviewDialog1
		'
		Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
		Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
		Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
		Me.printPreviewDialog1.Enabled = true
		Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"),System.Drawing.Icon)
		Me.printPreviewDialog1.Name = "printPreviewDialog1"
		Me.printPreviewDialog1.Visible = false
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1008, 630)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "MainForm"
		Me.Text = "AM_FACTURACION"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.panel1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.panel4.ResumeLayout(false)
		Me.panel4.PerformLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private tx_id_c As System.Windows.Forms.TextBox
	Private checito As System.Windows.Forms.DataGridViewCheckBoxColumn
	Private button6 As System.Windows.Forms.Button
	Private label6 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
	Private label5 As System.Windows.Forms.Label
	Private WithEvents textBox1 As System.Windows.Forms.TextBox'modificado withevens luis oviedo
	Private panel4 As System.Windows.Forms.Panel
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private button5 As System.Windows.Forms.Button
	Private printDialog1 As System.Windows.Forms.PrintDialog
	Private printDocument1 As System.Drawing.Printing.PrintDocument
	Private tx_ruc_cliente As System.Windows.Forms.TextBox
	Private tx_tel_cliente As System.Windows.Forms.TextBox
	Private button4 As System.Windows.Forms.Button
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private panel3 As System.Windows.Forms.Panel
	Private tx_nom_cliente As System.Windows.Forms.TextBox
	Private button3 As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	Private tx_ticket As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
End Class
