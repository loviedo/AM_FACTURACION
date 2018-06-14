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
		Me.tx_nom_c = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tx_ruc_c = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.tx_tel_c = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'tx_nom_c
		'
		Me.tx_nom_c.Location = New System.Drawing.Point(169, 40)
		Me.tx_nom_c.Name = "tx_nom_c"
		Me.tx_nom_c.Size = New System.Drawing.Size(100, 20)
		Me.tx_nom_c.TabIndex = 0
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(38, 40)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Nombre Cliente"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(38, 72)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 3
		Me.label2.Text = "RUC"
		'
		'tx_ruc_c
		'
		Me.tx_ruc_c.Location = New System.Drawing.Point(169, 72)
		Me.tx_ruc_c.Name = "tx_ruc_c"
		Me.tx_ruc_c.Size = New System.Drawing.Size(100, 20)
		Me.tx_ruc_c.TabIndex = 2
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(38, 106)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Telefono"
		'
		'tx_tel_c
		'
		Me.tx_tel_c.Location = New System.Drawing.Point(169, 106)
		Me.tx_tel_c.Name = "tx_tel_c"
		Me.tx_tel_c.Size = New System.Drawing.Size(100, 20)
		Me.tx_tel_c.TabIndex = 4
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(63, 195)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 6
		Me.button1.Text = "INSERTAR"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(277, 195)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(75, 23)
		Me.button2.TabIndex = 7
		Me.button2.Text = "CERRAR"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'ins_cliente_form
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(420, 269)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.tx_tel_c)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.tx_ruc_c)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.tx_nom_c)
		Me.Name = "ins_cliente_form"
		Me.Text = "ins_cliente_form"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private tx_tel_c As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private tx_ruc_c As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private tx_nom_c As System.Windows.Forms.TextBox
End Class
