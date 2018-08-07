'
' Created by SharpDevelop.
' User: loviedo
' Date: 27/5/2018
' Time: 13:00
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class ins_cliente_form
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
		Me.button1 = New System.Windows.Forms.Button()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.dt_fecnac_c = New System.Windows.Forms.DateTimePicker()
		Me.label7 = New System.Windows.Forms.Label()
		Me.tx_dir_c = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.tx_email_c = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.tx_tel_c = New System.Windows.Forms.TextBox()
		Me.tx_ruc_c = New System.Windows.Forms.TextBox()
		Me.tx_nom_c = New System.Windows.Forms.TextBox()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.button2)
		Me.panel1.Controls.Add(Me.button1)
		Me.panel1.Location = New System.Drawing.Point(12, 367)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(588, 66)
		Me.panel1.TabIndex = 8
		'
		'button2
		'
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(465, 22)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(105, 33)
		Me.button2.TabIndex = 8
		Me.button2.Text = "CANCELAR"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(12, 22)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(105, 33)
		Me.button1.TabIndex = 7
		Me.button1.Text = "INSERTAR"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.dt_fecnac_c)
		Me.panel2.Controls.Add(Me.label7)
		Me.panel2.Controls.Add(Me.tx_dir_c)
		Me.panel2.Controls.Add(Me.label2)
		Me.panel2.Controls.Add(Me.label6)
		Me.panel2.Controls.Add(Me.tx_email_c)
		Me.panel2.Controls.Add(Me.label1)
		Me.panel2.Controls.Add(Me.label4)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.label5)
		Me.panel2.Controls.Add(Me.tx_tel_c)
		Me.panel2.Controls.Add(Me.tx_ruc_c)
		Me.panel2.Controls.Add(Me.tx_nom_c)
		Me.panel2.Location = New System.Drawing.Point(12, 12)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(588, 349)
		Me.panel2.TabIndex = 9
		'
		'dt_fecnac_c
		'
		Me.dt_fecnac_c.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dt_fecnac_c.Location = New System.Drawing.Point(223, 202)
		Me.dt_fecnac_c.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
		Me.dt_fecnac_c.Name = "dt_fecnac_c"
		Me.dt_fecnac_c.Size = New System.Drawing.Size(360, 20)
		Me.dt_fecnac_c.TabIndex = 5
		'
		'label7
		'
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.Location = New System.Drawing.Point(68, 237)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(143, 29)
		Me.label7.TabIndex = 23
		Me.label7.Text = "DIRECCION:"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_dir_c
		'
		Me.tx_dir_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_dir_c.Location = New System.Drawing.Point(223, 237)
		Me.tx_dir_c.Multiline = true
		Me.tx_dir_c.Name = "tx_dir_c"
		Me.tx_dir_c.Size = New System.Drawing.Size(360, 49)
		Me.tx_dir_c.TabIndex = 6
		Me.tx_dir_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(3, 197)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(208, 29)
		Me.label2.TabIndex = 20
		Me.label2.Text = "FEC NACIMIENTO:"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(122, 164)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(89, 29)
		Me.label6.TabIndex = 19
		Me.label6.Text = "EMAIL:"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_email_c
		'
		Me.tx_email_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_email_c.Location = New System.Drawing.Point(223, 169)
		Me.tx_email_c.Name = "tx_email_c"
		Me.tx_email_c.Size = New System.Drawing.Size(360, 24)
		Me.tx_email_c.TabIndex = 4
		Me.tx_email_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(3, 8)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(580, 41)
		Me.label1.TabIndex = 16
		Me.label1.Text = "AGREGAR CLIENTE"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(133, 133)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(84, 29)
		Me.label4.TabIndex = 15
		Me.label4.Text = "*TEL:"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(133, 98)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(78, 29)
		Me.label3.TabIndex = 14
		Me.label3.Text = "*RUC:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(90, 63)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(121, 29)
		Me.label5.TabIndex = 13
		Me.label5.Text = "*CLIENTE:"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tx_tel_c
		'
		Me.tx_tel_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_tel_c.Location = New System.Drawing.Point(223, 137)
		Me.tx_tel_c.Name = "tx_tel_c"
		Me.tx_tel_c.Size = New System.Drawing.Size(360, 24)
		Me.tx_tel_c.TabIndex = 3
		Me.tx_tel_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tx_ruc_c
		'
		Me.tx_ruc_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_ruc_c.Location = New System.Drawing.Point(223, 103)
		Me.tx_ruc_c.Name = "tx_ruc_c"
		Me.tx_ruc_c.Size = New System.Drawing.Size(360, 24)
		Me.tx_ruc_c.TabIndex = 2
		Me.tx_ruc_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tx_nom_c
		'
		Me.tx_nom_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_nom_c.Location = New System.Drawing.Point(223, 63)
		Me.tx_nom_c.Name = "tx_nom_c"
		Me.tx_nom_c.Size = New System.Drawing.Size(360, 24)
		Me.tx_nom_c.TabIndex = 1
		Me.tx_nom_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ins_cliente_form
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(612, 445)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "ins_cliente_form"
		Me.Text = "ins_cliente_form"
		AddHandler Load, AddressOf Me.Ins_cliente_formLoad
		Me.panel1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private dt_fecnac_c As System.Windows.Forms.DateTimePicker
	Private tx_dir_c As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private tx_email_c As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private tx_tel_c As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private tx_ruc_c As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private tx_nom_c As System.Windows.Forms.TextBox
End Class
