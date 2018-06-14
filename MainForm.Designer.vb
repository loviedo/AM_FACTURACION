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
		Me.button2 = New System.Windows.Forms.Button()
		Me.tx_ticket = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.button1 = New System.Windows.Forms.Button()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.tx_tel_cliente = New System.Windows.Forms.TextBox()
		Me.tx_ruc_cliente = New System.Windows.Forms.TextBox()
		Me.button4 = New System.Windows.Forms.Button()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.button3 = New System.Windows.Forms.Button()
		Me.tx_nom_cliente = New System.Windows.Forms.TextBox()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.printDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.printDialog1 = New System.Windows.Forms.PrintDialog()
		Me.button5 = New System.Windows.Forms.Button()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel3.SuspendLayout
		Me.SuspendLayout
		'
		'button2
		'
		Me.button2.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(846, 12)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(125, 44)
		Me.button2.TabIndex = 2
		Me.button2.Text = "SALIR"
		Me.button2.UseVisualStyleBackColor = false
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'tx_ticket
		'
		Me.tx_ticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_ticket.Location = New System.Drawing.Point(140, 21)
		Me.tx_ticket.Name = "tx_ticket"
		Me.tx_ticket.Size = New System.Drawing.Size(114, 26)
		Me.tx_ticket.TabIndex = 0
		Me.tx_ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(13, 12)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(121, 40)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Ticket N°:"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(260, 12)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(112, 40)
		Me.button1.TabIndex = 1
		Me.button1.Text = "Buscar"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'panel1
		'
		Me.panel1.Controls.Add(Me.button2)
		Me.panel1.Location = New System.Drawing.Point(12, 557)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(987, 67)
		Me.panel1.TabIndex = 4
		'
		'panel2
		'
		Me.panel2.Controls.Add(Me.button5)
		Me.panel2.Controls.Add(Me.tx_tel_cliente)
		Me.panel2.Controls.Add(Me.tx_ruc_cliente)
		Me.panel2.Controls.Add(Me.button4)
		Me.panel2.Controls.Add(Me.dataGridView1)
		Me.panel2.Controls.Add(Me.button3)
		Me.panel2.Controls.Add(Me.tx_nom_cliente)
		Me.panel2.Location = New System.Drawing.Point(12, 84)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(987, 467)
		Me.panel2.TabIndex = 5
		'
		'tx_tel_cliente
		'
		Me.tx_tel_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_tel_cliente.Location = New System.Drawing.Point(18, 85)
		Me.tx_tel_cliente.Multiline = true
		Me.tx_tel_cliente.Name = "tx_tel_cliente"
		Me.tx_tel_cliente.Size = New System.Drawing.Size(337, 29)
		Me.tx_tel_cliente.TabIndex = 5
		Me.tx_tel_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tx_ruc_cliente
		'
		Me.tx_ruc_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_ruc_cliente.Location = New System.Drawing.Point(18, 50)
		Me.tx_ruc_cliente.Multiline = true
		Me.tx_ruc_cliente.Name = "tx_ruc_cliente"
		Me.tx_ruc_cliente.Size = New System.Drawing.Size(337, 29)
		Me.tx_ruc_cliente.TabIndex = 4
		Me.tx_ruc_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'button4
		'
		Me.button4.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button4.Location = New System.Drawing.Point(777, 426)
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
		Me.dataGridView1.Location = New System.Drawing.Point(18, 136)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.ReadOnly = true
		Me.dataGridView1.Size = New System.Drawing.Size(953, 284)
		Me.dataGridView1.TabIndex = 3
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(432, 15)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(113, 29)
		Me.button3.TabIndex = 2
		Me.button3.Text = "Buscar Cliente"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'tx_nom_cliente
		'
		Me.tx_nom_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_nom_cliente.Location = New System.Drawing.Point(18, 15)
		Me.tx_nom_cliente.Multiline = true
		Me.tx_nom_cliente.Name = "tx_nom_cliente"
		Me.tx_nom_cliente.Size = New System.Drawing.Size(337, 29)
		Me.tx_nom_cliente.TabIndex = 1
		Me.tx_nom_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'panel3
		'
		Me.panel3.Controls.Add(Me.button1)
		Me.panel3.Controls.Add(Me.label1)
		Me.panel3.Controls.Add(Me.tx_ticket)
		Me.panel3.Location = New System.Drawing.Point(12, 12)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(987, 66)
		Me.panel3.TabIndex = 6
		'
		'printDocument1
		'
		AddHandler Me.printDocument1.PrintPage, AddressOf Me.PrintDocument1PrintPage
		'
		'printDialog1
		'
		Me.printDialog1.UseEXDialog = true
		'
		'button5
		'
		Me.button5.Location = New System.Drawing.Point(395, 441)
		Me.button5.Name = "button5"
		Me.button5.Size = New System.Drawing.Size(127, 23)
		Me.button5.TabIndex = 6
		Me.button5.Text = "button5"
		Me.button5.UseVisualStyleBackColor = true
		AddHandler Me.button5.Click, AddressOf Me.Button5Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1011, 627)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "MainForm"
		Me.Text = "AM_FACTURACION"
		Me.panel1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		Me.ResumeLayout(false)
	End Sub
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
