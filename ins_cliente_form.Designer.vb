﻿'
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
		Me.tx_tel_c = New System.Windows.Forms.TextBox()
		Me.tx_ruc_c = New System.Windows.Forms.TextBox()
		Me.tx_nom_c = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.button2)
		Me.panel1.Controls.Add(Me.button1)
		Me.panel1.Location = New System.Drawing.Point(12, 202)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(396, 66)
		Me.panel1.TabIndex = 8
		'
		'button2
		'
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(252, 22)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(105, 33)
		Me.button2.TabIndex = 9
		Me.button2.Text = "CANCELAR"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(38, 22)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(105, 33)
		Me.button1.TabIndex = 8
		Me.button1.Text = "INSERTAR"
		Me.button1.UseVisualStyleBackColor = true
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.label1)
		Me.panel2.Controls.Add(Me.label4)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.label5)
		Me.panel2.Controls.Add(Me.tx_tel_c)
		Me.panel2.Controls.Add(Me.tx_ruc_c)
		Me.panel2.Controls.Add(Me.tx_nom_c)
		Me.panel2.Location = New System.Drawing.Point(12, 12)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(396, 184)
		Me.panel2.TabIndex = 9
		'
		'tx_tel_c
		'
		Me.tx_tel_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_tel_c.Location = New System.Drawing.Point(172, 137)
		Me.tx_tel_c.Name = "tx_tel_c"
		Me.tx_tel_c.Size = New System.Drawing.Size(147, 24)
		Me.tx_tel_c.TabIndex = 10
		'
		'tx_ruc_c
		'
		Me.tx_ruc_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_ruc_c.Location = New System.Drawing.Point(172, 103)
		Me.tx_ruc_c.Name = "tx_ruc_c"
		Me.tx_ruc_c.Size = New System.Drawing.Size(147, 24)
		Me.tx_ruc_c.TabIndex = 8
		'
		'tx_nom_c
		'
		Me.tx_nom_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tx_nom_c.Location = New System.Drawing.Point(172, 63)
		Me.tx_nom_c.Name = "tx_nom_c"
		Me.tx_nom_c.Size = New System.Drawing.Size(147, 24)
		Me.tx_nom_c.TabIndex = 6
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(93, 133)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(73, 29)
		Me.label4.TabIndex = 15
		Me.label4.Text = "TEL:"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(86, 98)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(80, 29)
		Me.label3.TabIndex = 14
		Me.label3.Text = "RUC:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(45, 63)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(121, 29)
		Me.label5.TabIndex = 13
		Me.label5.Text = "CLIENTE:"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(12, 8)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(363, 41)
		Me.label1.TabIndex = 16
		Me.label1.Text = "AGREGAR CLIENTE"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ins_cliente_form
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(420, 269)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "ins_cliente_form"
		Me.Text = "ins_cliente_form"
		Me.panel1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.ResumeLayout(false)
	End Sub
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
