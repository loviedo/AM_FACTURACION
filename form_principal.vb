'
' Created by SharpDevelop.
' User: loviedo
' Date: 16/6/2018
' Time: 10:19
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class form_principal
	
	Dim centro As String = "AQUI MADRID"
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		label1.Visible = false
	End Sub
	
	
	Sub Form_principalLoad(sender As Object, e As EventArgs)
		Me.WindowState = FormWindowState.Maximized			
	End Sub
	
	Sub ListadosToolStripMenuItemClick(sender As Object, e As EventArgs)
		'llamamos al form de listado
		Dim exporta As New form_exporta()		
		'main.ShowDialog(Me)'instanciamos el cliente. DEBUG
		
		If exporta.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
        	' traemos el contenido
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	exporta.Dispose()
	End Sub
	
	Sub SalirToolStripMenuItemClick(sender As Object, e As EventArgs)
		'Cerrar programa
		Application.Exit
	End Sub
	
	Sub FacturarToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim main As New MainForm(centro)		
		'main.ShowDialog(Me)'instanciamos el cliente. DEBUG
		
		If main.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
        	' traemos el contenido
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	main.Dispose()
	End Sub
	
	Sub ProgramaToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim acerca As New form_help()		
		
		If acerca.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
        	' traemos el contenido
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	acerca.Dispose()
	End Sub
	
	Sub AdminToolStripMenuItemClick(sender As Object, e As EventArgs)
		'mostramos el form de admin del sistema
		Dim admin As New form_admin()		
		
		If admin.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
			' traemos el contenido
			'centro =         	
			centro = admin.comboBox1.SelectedItem.ToString
			
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	admin.Dispose()
    	'label1.Visible = True'debug
    	'label1.Text = centro'debug
	End Sub
End Class
