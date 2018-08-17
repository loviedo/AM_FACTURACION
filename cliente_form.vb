'
' Created by SharpDevelop.
' User: loviedo
' Date: 27/5/2018
' Time: 12:31
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System.Data
Imports System.Data.SqlClient

Public Partial Class cliente_form
	
	'Private conn As New System.Data.SqlServerCe.SqlCeConnection("Data Source = D:\PROYECTOS\SharpDevelop Projects\SambaData2.sdf")'debug
	Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = C:\Users\Paco Requena\Documents\SambaPOS2\SambaData2.sdf")'release
		
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		'traemos la info de los clientes.
	
		
	End Sub
	
	Sub Cliente_formLoad(sender As Object, e As EventArgs)
		'aqui rellenamos en una tabla los clientes de entrada y luego filtramos segun escribamos.
		Dim cmd As System.Data.SqlServerCe.SqlCeCommand
		'Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = C:\Users\user\Desktop\SambaData2.sdf")
		
		Dim consulta As String = "Select Id, Nombre,RUC, Telefono from Clientes"
		'Dim datos As System.Data.SqlServerCe.SqlCeDataReader
		
		Try
			conn.Open()
			cmd = conn.CreateCommand()
		    cmd.CommandText = consulta
		    'cmd.ExecuteNonQuery()
		    'datos = cmd.ExecuteReader()
		    Dim dt = new DataTable()
		    dt.Load(cmd.ExecuteReader())
			
			'Dim row As DataRow
			'Dim count As Integer = dt.Columns.Count()
			'Dim count1 As Integer = dt.Rows.Count()
	        'MessageBox.show(count1.ToString)
	       
			DataGridView1.AutoGenerateColumns = True
			DataGridView1.DataSource = dt
			DataGridView1.Refresh
		    
		    
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
		    conn.Close()
		End Try
		
		For Each dgvr As DataGridViewRow In DataGridView1.Rows
			dgvr.Cells("Nombre").ToolTipText = "Doble click para selecccionar"
			dgvr.Cells("RUC").ToolTipText = "Doble click para selecccionar"
			dgvr.Cells("Telefono").ToolTipText = "Doble click para selecccionar"
		Next
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'insertamos cliente
		'pantalla de insercion del cliente
		Dim ins_cliente As New ins_cliente_form()
		'cliente.ShowDialog(Me)'instanciamos el cliente. DEBUG
		
		If ins_cliente.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
        	' traemos el contenido
        	'tx_cliente.Text = cliente.TextBox1.Text
    	Else
        	'ins_cliente.Text = "Cancelado"
    	End If
    	ins_cliente.Dispose()
		
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
        ' Set the result to pass back to the form that called this dialog
        Me.DialogResult = System.Windows.Forms.DialogResult.OK	
        
	End Sub
	
	Sub DataGridView1CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		'mostramos los datos de la fila seleccionada
		Dim i As Integer
		i = DataGridView1.CurrentRow.Index
		
		TextBox1.Text = DataGridView1.Item(1, i).Value.ToString
		TextBox2.Text = DataGridView1.Item(2, i).Value.ToString
		TextBox3.Text = DataGridView1.Item(3, i).Value.ToString
		TextBox6.Text = DataGridView1.Item(0, i).Value.ToString
		
	End Sub
	
	Sub TextBox4TextChanged(sender As Object, e As EventArgs)
		'Messagebox.Show("Enter key pressed")
		'filtramos el gridview segun el texto ingresado.
		
		'Dim dv As DataView = DirectCast(DataGridView1.DataSource, DataTable).DefaultView
		'dv.RowFilter = "Nombre like '%" + textBox4.Text + "%'"
		'DataGridView1.DataSource = dv
			
		'If textBox4.Text.Length >=1 Then
		'	dv.RowFilter = "Nombre like '%" + textBox4.Text + "%'"
		'	DataGridView1.DataSource = dv
		'	DataGridView1.Refresh
		'End If
		
		'MOSTRAMOS EL GRIDVIEW SEGUN LOS DATOS UQE BUSCAMOS.
		Dim cmd As System.Data.SqlServerCe.SqlCeCommand
		
		
		Dim consulta As String = "Select Id, Nombre,RUC, Telefono from Clientes"
		'Dim datos As System.Data.SqlServerCe.SqlCeDataReader
		
		If textBox4.Text.Length >= 1 Then
			consulta = consulta + " where Nombre like '%" + textBox4.Text + "%'"
		End If
		
		Try
			conn.Open()
			cmd = conn.CreateCommand()
		    cmd.CommandText = consulta
		    'cmd.ExecuteNonQuery()
		    'datos = cmd.ExecuteReader()
		    Dim dt = new DataTable()
		    dt.Load(cmd.ExecuteReader())
	       
			DataGridView1.AutoGenerateColumns = True
			DataGridView1.DataSource = dt
			DataGridView1.Refresh
		    
		    
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
		    conn.Close()
		End Try


	End Sub
	
	
	Sub Button3Click(sender As Object, e As EventArgs)
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()		
	End Sub
	
	Sub TextBox5TextChanged(sender As Object, e As EventArgs)
		'Messagebox.Show("Enter key pressed")
		'filtramos el gridview segun el texto ingresado.
		
		'Dim dv As DataView = DirectCast(DataGridView1.DataSource, DataTable).DefaultView
		'dv.RowFilter = "Nombre like '%" + textBox4.Text + "%'"
		'DataGridView1.DataSource = dv
			
		'If textBox4.Text.Length >=1 Then
		'	dv.RowFilter = "Nombre like '%" + textBox4.Text + "%'"
		'	DataGridView1.DataSource = dv
		'	DataGridView1.Refresh
		'End If
		
		'MOSTRAMOS EL GRIDVIEW SEGUN LOS DATOS UQE BUSCAMOS.
		Dim cmd As System.Data.SqlServerCe.SqlCeCommand
		
		
		Dim consulta As String = "Select Id, Nombre,RUC, Telefono from Clientes"
		'Dim datos As System.Data.SqlServerCe.SqlCeDataReader
		
		If textBox5.Text.Length >= 1 Then
			consulta = consulta + " where RUC like '%" + textBox5.Text + "%'"
		End If
		
		Try
			conn.Open()
			cmd = conn.CreateCommand()
		    cmd.CommandText = consulta
		    'cmd.ExecuteNonQuery()
		    'datos = cmd.ExecuteReader()
		    Dim dt = new DataTable()
		    dt.Load(cmd.ExecuteReader())
	       
			DataGridView1.AutoGenerateColumns = True
			DataGridView1.DataSource = dt
			DataGridView1.Refresh
		    
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
		    conn.Close()
		End Try
		
	End Sub
End Class
