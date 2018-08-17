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
		'Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = D:\PROYECTOS\SharpDevelop Projects\SambaData2.sdf")'debug
		Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = C:\Users\Paco Requena\Documents\SambaPOS2\SambaData2.sdf")'release
		
		
		Dim consulta As String = "Insert Into Clientes (Nombre,RUC,Telefono, Email, Fec_nac, Direccion) values('" & tx_nom_c.Text & "','" & tx_ruc_c.Text & "','" & tx_tel_c.Text & "','" & tx_email_c.Text & "','" & dt_fecnac_c.Text & "','" & tx_dir_c.Text & "')"
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
			    	tx_email_c.Text = ""
			    	dt_fecnac_c.Text = ""
			    	tx_dir_c.Text = ""
			    Else
			    	Messagebox.Show("Error al insertar.")
			    End If
			    
			Catch ex As Exception
				MessageBox.Show(ex.Message.ToString)
			Finally
			    conn.Close()
			End Try
		Else
			MessageBox.Show("DEBE COMPLETAR LOS CAMPOS OBLIGATORIOS!")
		End If
		

	End Sub
	
	Sub Ins_cliente_formLoad(sender As Object, e As EventArgs)
		'establecemos el formato de la fecha.
		dt_fecnac_c.Format = DateTimePickerFormat.Custom
    	dt_fecnac_c.CustomFormat = "MM/dd/yy"

		
	End Sub
End Class
