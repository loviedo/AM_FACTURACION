'
' Created by SharpDevelop.
' User: loviedo
' Date: 27/5/2018
' Time: 13:00
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class ins_cliente_form
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Me.close()	
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'insertar nuevo cliente en la base ce
		'aqui rellenamos en una tabla los clientes de entrada y luego filtramos segun escribamos.
		Dim cmd As System.Data.SqlServerCe.SqlCeCommand
		Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = C:\Users\user\Desktop\SambaData2.sdf")
		
		Dim consulta As String = "Insert Into Clientes (Nombre,RUC,Telefono) values('" & tx_nom_c.Text & "','" & tx_ruc_c.Text & "','" & tx_tel_c.Text & "')"
		'Dim datos As System.Data.SqlServerCe.SqlCeDataReader
		
		
		If tx_tel_c.TextLength > 0 And tx_ruc_c.TextLength > 0 And tx_nom_c.TextLength >0 Then
			Try
				conn.Open()
				cmd = conn.CreateCommand()
			    cmd.CommandText = consulta
			    
			    If cmd.ExecuteNonQuery() Then
			    	Messagebox.Show("Insertado Exitosamente.")
			    	tx_nom_c.Text = ""
			    	tx_ruc_c.Text  = ""
			    	tx_tel_c.Text = ""
			    Else
			    	Messagebox.Show("Error al insertar.")
			    End If
			    
			Catch ex As Exception
				MessageBox.Show(ex.Message.ToString)
			Finally
			    conn.Close()
			End Try
		Else
			MessageBox.Show("DEBE COMPLETAR TODOS LOS CAMPOS")
		End If
		

	End Sub
End Class
