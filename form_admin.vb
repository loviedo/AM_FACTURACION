'
' Created by SharpDevelop.
' User: loviedo
' Date: 17/6/2018
' Time: 19:06
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class form_admin
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Sub Button1Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub
	
	Sub ComboBox1SelectedIndexChanged(sender As Object, e As EventArgs)
		MessageBox.Show(Me.comboBox1.Text)
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Me.DialogResult = System.Windows.Forms.DialogResult.OK
		
	End Sub
End Class
