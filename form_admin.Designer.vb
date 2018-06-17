'
' Created by SharpDevelop.
' User: loviedo
' Date: 17/6/2018
' Time: 19:06
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form_admin
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
		Me.label2 = New System.Windows.Forms.Label()
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button1 = New System.Windows.Forms.Button()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.panel3.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.label2)
		Me.panel1.Controls.Add(Me.comboBox1)
		Me.panel1.Location = New System.Drawing.Point(12, 81)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(640, 281)
		Me.panel1.TabIndex = 0
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(47, 33)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(180, 23)
		Me.label2.TabIndex = 1
		Me.label2.Text = "CENTRO DE COSTO:"
		'
		'comboBox1
		'
		Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox1.FormattingEnabled = true
		Me.comboBox1.Items.AddRange(New Object() {"AQUI MADRID", "LA ESPAÑOLITA"})
		Me.comboBox1.Location = New System.Drawing.Point(233, 30)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(347, 26)
		Me.comboBox1.TabIndex = 0
		AddHandler Me.comboBox1.SelectedIndexChanged, AddressOf Me.ComboBox1SelectedIndexChanged
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.label1)
		Me.panel2.Location = New System.Drawing.Point(12, 12)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(640, 63)
		Me.panel2.TabIndex = 1
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(3, 0)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(632, 61)
		Me.label1.TabIndex = 0
		Me.label1.Text = "PANEL ADMINISTRADOR"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel3.Controls.Add(Me.button2)
		Me.panel3.Controls.Add(Me.button1)
		Me.panel3.Location = New System.Drawing.Point(12, 368)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(640, 50)
		Me.panel3.TabIndex = 2
		'
		'button2
		'
		Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(465, 3)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(115, 40)
		Me.button2.TabIndex = 1
		Me.button2.Text = "Guardar"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(47, 3)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(115, 40)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Salir"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'form_admin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(664, 426)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "form_admin"
		Me.Text = "form_admin"
		Me.panel1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel3.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private panel3 As System.Windows.Forms.Panel
	Public comboBox1 As System.Windows.Forms.ComboBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
End Class
