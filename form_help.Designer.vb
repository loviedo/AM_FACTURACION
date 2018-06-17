'
' Created by SharpDevelop.
' User: loviedo
' Date: 16/6/2018
' Time: 12:12
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form_help
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
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Location = New System.Drawing.Point(12, 12)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(566, 251)
		Me.panel1.TabIndex = 0
		'
		'panel2
		'
		Me.panel2.Controls.Add(Me.button1)
		Me.panel2.Location = New System.Drawing.Point(12, 269)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(566, 52)
		Me.panel2.TabIndex = 1
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(171, 3)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(265, 46)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Aceptar"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(11, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(425, 89)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Desarrollado por Luis Oviedo"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"le.oviedo@gmail.com"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"+595 981 890161"
		'
		'form_help
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(590, 333)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Name = "form_help"
		Me.Text = "form_help"
		Me.panel1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private button1 As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel
End Class
