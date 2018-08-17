'
' Created by SharpDevelop.
' User: loviedo
' Date: 26/5/2018
' Time: 23:09
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Imports Excel = Microsoft.Office.Interop.Excel

Public Partial Class MainForm
	
	Dim centro As String = "AQUI MADRID"'set inicial de centro de costo
	
	Public Sub New(centro1 As String)
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		Me.centro = centro1
		Me.button5.Visible = False'ocultamos porque no usamos
		Me.label8.Text = ""
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)		
		Dim cmd As System.Data.SqlServerCe.SqlCeCommand
		'Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = D:\PROYECTOS\SharpDevelop Projects\SambaData2.sdf")'debug
		Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = C:\Users\Paco Requena\Documents\SambaPOS2\SambaData2.sdf")'release
		
		Dim ticket As Integer 
		ticket = CInt(tx_ticket.text)-1
		
		Dim consulta As String = "Select Id, TicketId, MenuItemId, MenuItemName, PortionName, CurrencyCode, Quantity, PortionCount, OrderNumber, CreatingUserId, " & _
			"CreatedDateTime, ModifiedDateTime, Price from TicketItems where TicketId = " & ticket.ToString & " and Voided = 0"

		
		'Dim consulta As String = "Select Id, TicketId, MenuItemId, MenuItemName, PortionName, CurrencyCode, Quantity, PortionCount, OrderNumber, CreatingUserId, CreatedDateTime, ModifiedDateTime" & _
		'"from TicketItems where TicketId = 100"
		'Dim datos As System.Data.SqlServerCe.SqlCeDataReader
		
		Try
			conn.Open()
			cmd = conn.CreateCommand()
		    cmd.CommandText = consulta
		    'cmd.ExecuteNonQuery()
		    'datos = cmd.ExecuteReader()
		   	Dim dt = new System.Data.DataTable()
		    
		    'debug
		    'While datos.Read()
		    '	Messagebox.Show("ID>" & datos.GetInt32(0).ToString & " TicketID>" & datos.GetInt32(1).ToString & " MenuItemId>" & datos.GetInt32(2).ToString & " PortionName>" & datos.GetString(3).ToString & " CurrencyCode>" & datos.GetString(4).ToString & " Quantity>" & _
		    '	datos.GetString(5).ToString & " Quantity>" & datos.GetDecimal(6).ToString & " PortionCount>" & datos.GetInt32(7).ToString & " OrderNumber>" & datos.GetInt32(8).ToString & " CreatingUserId>" & _
		    '	datos.GetInt32(9).ToString & " CreatedDateTime>" & datos.GetDateTime(10).ToString & " ModifiedDateTime>" & datos.GetDateTime(11).ToString & " Price>" & datos.GetDecimal(12).ToString)
		    'End While
		    
		    'datos.Read()
		    dt.Load(cmd.ExecuteReader())
			DataGridView1.AutoGenerateColumns = True
			DataGridView1.DataSource = dt
			DataGridView1.Refresh
		    
		    Dim cell As DataGridViewCheckBoxCell
			For Each row As DataGridViewRow In DataGridView1.Rows
				row.Cells(0).Value= true
			Next
		    
		    
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
			conn.Close()
		End Try
		
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		'cerramos el programa
		'Application.Exit
		Me.Close()
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		
		'pantalla de busqueda del cliente
		Dim cliente As New cliente_form()
		'cliente.ShowDialog(Me)'instanciamos el cliente. DEBUG
		
		If cliente.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
        	' traemos el contenido
        	tx_nom_cliente.Text = cliente.TextBox1.Text
        	tx_ruc_cliente.Text = cliente.TextBox2.Text
        	tx_tel_cliente.Text = cliente.TextBox3.Text
        	tx_id_c.Text = cliente.TextBox6.Text
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	cliente.Dispose()
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		Dim cell As DataGridViewCheckBoxCell
		
		'aqui juntamos las filas chequeadas y los datos a imprimirse.
		For Each row As DataGridViewRow In DataGridView1.Rows
			cell = row.Cells(0)
			If cell.Value = True Then
				'MessageBox.Show(cell.Value.ToString & " : " & row.Index.ToString)'debug
				
			End If
        Next

		'imprimos el PDF, mandamos a la impresora
		PrintDialog1.Document = PrintDocument1
		PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
		PrintDialog1.AllowSomePages = True
		
		'http://www.visual-basic-tutorials.com/Tutorials/Controls/PrintPreviewDialog.html
		'https://msdn.microsoft.com/en-us/library/system.windows.forms.printpreviewdialog.printpreviewdialog(v=vs.110).aspx
		PrintPreviewDialog1.Document = PrintDocument1
		PrintPreviewDialog1.ShowDialog()'mostramos el preview de impresion y luego el dialogo de impresion
		
		If PrintDialog1.ShowDialog = DialogResult.OK Then
		  PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
		  PrintDocument1.Print()
		End If
		
		
		'AQUI GUARDAMOS LOS DATOS DE LA FACTURA IMPRESA!
		Dim cmd As System.Data.SqlServerCe.SqlCeCommand
		'Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = D:\PROYECTOS\SharpDevelop Projects\SambaData2.sdf")'debug
		Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = C:\Users\Paco Requena\Documents\SambaPOS2\SambaData2.sdf")'release
		
		
		'Dim consulta As String = "Insert Into Clientes (Nombre,RUC,Telefono) values('" & tx_nom_c.Text & "','" & tx_ruc_c.Text & "','" & tx_tel_c.Text & "')"
		Dim consulta As String = "Insert Into Facturas (NRO_FACTURA,TICKET,ID_CLIENTE,FEC_INSERCION) values(" & textBox1.Text & "," & tx_ticket.Text & "," & tx_id_c.Text & ", CONVERT(DATETIME, '" & System.DateTime.Now & "', 103))"
		
		
		
		If tx_tel_cliente.TextLength > 0 And tx_ruc_cliente.TextLength > 0 And tx_nom_cliente.TextLength >0 And tx_ticket.TextLength > 0 And textBox1.TextLength > 0 Then
			Try
				conn.Open()
				cmd = conn.CreateCommand()
			    cmd.CommandText = consulta
			    
			    If cmd.ExecuteNonQuery() Then
			    	Messagebox.Show("Impreso Exitosamente")
			    	'tx_nom_cliente.Text = ""
			    	'tx_ruc_cliente.Text  = ""
			    	'tx_tel_cliente.Text = ""
			    Else
			    	Messagebox.Show("Error al insertar.")
			    End If
			    
			Catch ex As Exception
				MessageBox.Show(ex.Message.ToString)
			Finally
			    conn.Close()
			End Try
		Else
			MessageBox.Show("DEBE COMPLETAR LOS CAMPOS!")
		End If
		
		   
		   
	End Sub
	
	Sub PrintDocument1PrintPage(sender As Object, e As PrintPageEventArgs)
		Static currentChar As Integer
		Static currentLine As Integer
		Dim textfont As Font = tx_nom_cliente.Font'debug
		Dim h, w As Integer
		Dim left, top As Integer
		Dim cell As DataGridViewCheckBoxCell
		
		
		'SETEAMOS a A4
		Dim ps As New PaperSize("A4", 850, 1100)
		ps.PaperName = PaperKind.A4
		PrintDocument1.DefaultPageSettings.PaperSize = ps
		
		With PrintDocument1.DefaultPageSettings
		   'h = .PaperSize.Height - .Margins.Top - .Margins.Bottom
		   'w = .PaperSize.Width - .Margins.Left - .Margins.Right
		   'left = PrintDocument1.DefaultPageSettings.Margins.Left
		   'top = PrintDocument1.DefaultPageSettings.Margins.Top
		   
		   h = .PaperSize.Height-60
		   w = .PaperSize.Width-60
		   left = 30'.Margins.Left
		   top = 30'.Margins.Top
		End With
       
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, top, w, h/2-30))'cuadro grande arriba
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, h/2+30, w, h/2))'cuadro grande abajo
       
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, top, w-300, h/18))'cuadro titulo espanolita
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, h/2+30, w-300, h/18))'abajo
       
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left+(w-300), top, 300, h/18))'cuadro titulo factura
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left+(w-300), h/2+30, 300, h/18))'abajo
		
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, top+h/18, w, h/13))'cuadro datos cliente
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, h/2+30+h/18, w, h/13))'abajo
		
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, top+h/18, w, h/13+20))'cuadro ENTRETITULO cliente
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, h/2+30+h/18, w, h/13+20))'abajo
		
       	'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, top+h/18+h/13, w, 300))'cuadro DATOS FACTURA cliente
       	'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, h/2+30+h/18+h/13, w, 330))'abajo
       	
       	'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, top+h/18+h/13, left+40, 300))'cuadro CANT cliente
       	'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, h/2+30+h/18+h/13, left+40, 330))'abajo
       	
       	'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, top+h/18+h/13, w-300, 300))'cuadro DESCRIPCION cliente
       	'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, h/2+30+h/18+h/13, w-300, 330))'abajo
       	
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, top+h/18+h/13, w-300+75, 300))'cuadro PRECIO UNITARIO cliente
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, h/2+30+h/18+h/13, w-300+75, 300))'abajo
		
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left+w-300+75, top+h/18+h/13+10, 75, 290))'cuadro EXENTAS cliente
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left+w-300+75, h/2+30+h/18+h/13+10, 75, 320))'abajo
		
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left+w-300+150, top+h/18+h/13+10, 75, 290))'cuadro 5% cliente
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left+w-300+150, h/2+30+h/18+h/13+10, 75, 320))'abajo
		
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left+w-300+225, top+h/18+h/13+10, 75, 290))'cuadro 10% cliente
		'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left+w-300+225, h/2+30+h/18+h/13+10, 75, 320))'abajo
		
		'e.Graphics.DrawString("CANTIDAD", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, top+h/18+h/13+4)'CANTIDAD
		'e.Graphics.DrawString("CANTIDAD", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, h/2+30+h/18+h/13+4)'CANTIDAD
		
		'e.Graphics.DrawString("DESCRIPCION", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+40+210, top+h/18+h/13+4)'DESCRIPCION
		'e.Graphics.DrawString("DESCRIPCION", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+40+210,h/2+30+h/18+h/13+4)'DESCRIPCION
		
		'e.Graphics.DrawString("P UNITARIO", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+480+15, top+h/18+h/13+4)'PRECIO UNITARIO
		'e.Graphics.DrawString("P UNITARIO", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+480+15, h/2+30+h/18+h/13+4)'PRECIO UNITARIO
		
		'e.Graphics.DrawString("VALOR DE VENTAS", New Font(FontFamily.GenericSansSerif, 6.0F, FontStyle.Regular), Brushes.Black, left+480+158, top+h/18+h/13+1)'VALOR DE VENTAS
		'e.Graphics.DrawString("VALOR DE VENTAS", New Font(FontFamily.GenericSansSerif, 6.0F, FontStyle.Regular), Brushes.Black, left+480+158, h/2+30+h/18+h/13+1)'VALOR DE VENTAS
		
		'e.Graphics.DrawString("EXENTAS", New Font(FontFamily.GenericSansSerif, 6.0F, FontStyle.Regular), Brushes.Black, left+30+440+113, top+h/18+h/13+10)'EXENTAS
		'e.Graphics.DrawString("EXENTAS", New Font(FontFamily.GenericSansSerif, 6.0F, FontStyle.Regular), Brushes.Black, left+30+440+113, h/2+30+h/18+h/13+10)'EXENTAS
		
		'e.Graphics.DrawString("5%", New Font(FontFamily.GenericSansSerif, 6.0F, FontStyle.Regular), Brushes.Black, left+30+480+163, top+h/18+h/13+10)'5%
		'e.Graphics.DrawString("5%", New Font(FontFamily.GenericSansSerif, 6.0F, FontStyle.Regular), Brushes.Black, left+30+480+163, h/2+30+h/18+h/13+10)'5%
		
		'e.Graphics.DrawString("10%", New Font(FontFamily.GenericSansSerif, 6.0F, FontStyle.Regular), Brushes.Black, left+30+480+237, top+h/18+h/13+10)'10%
		'e.Graphics.DrawString("10%", New Font(FontFamily.GenericSansSerif, 6.0F, FontStyle.Regular), Brushes.Black, left+30+480+237, h/2+30+h/18+h/13+10)'10%
		
		'e.Graphics.DrawString("Fecha de Emisión:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, top+h/18+5)'FECHA EMISION
		'e.Graphics.DrawString("Fecha de Emisión:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, h/2+30+h/18+5)'FECHA EMISION
		
		'e.Graphics.DrawString("Nombre o Razón Social:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, top+h/18+5+20)'NOMBRE
		'e.Graphics.DrawString("Nombre o Razón Social:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, h/2+30+h/18+5+20)'NOMBRE
		
		'e.Graphics.DrawString("RUC o CI:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, top+h/18+5+40)'RUC
		'e.Graphics.DrawString("RUC o CI:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, h/2+30+h/18+5+40)'RUC
		
		'e.Graphics.DrawString("Dirección:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, top+h/18+5+58)'Direccion
		'e.Graphics.DrawString("Dirección:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, h/2+30+h/18+5+58)'Direccion
		
		'e.Graphics.DrawString("Cond de Venta:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+480, top+h/18+5)'cond venta
		'e.Graphics.DrawString("Cond de Venta:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+480, h/2+30+h/18+5)'cond venta
		e.Graphics.DrawString(textBox1.Text, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+500, top+h/18-50)'IMPRE FACT NRO
		e.Graphics.DrawString(textBox1.Text, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+500, h/2+30+h/18-50)'IMPRE FACT NRO
		
		e.Graphics.DrawString("                  X", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+480+100, top+h/18-17)' X de contado
		e.Graphics.DrawString("                  X", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+480+100, h/2+30+h/18-17)'X de contado
		
		'e.Graphics.DrawString("CRÉDITO (    )", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+480+200, top+h/18+5)'credito
		'e.Graphics.DrawString("CRÉDITO (    )", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+480+200, h/2+30+h/18+5)'credito		

		'e.Graphics.DrawString("Nota de Remisión:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+480, top+h/18+5+40)'Nota de Remisión
		'e.Graphics.DrawString("Nota de Remisión:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+480, h/2+30+h/18+5+40)'Nota de Remisión
		
		'e.Graphics.DrawString("Teléfono:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+480, top+h/18+5+58)'telefono
		'e.Graphics.DrawString("Teléfono:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+480, h/2+30+h/18+5+58)'telefono
		
		'e.Graphics.DrawString("SUB TOTAL:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, top+h/18+h/13+283+20)'SUB TOTAL
		'e.Graphics.DrawString("SUB TOTAL:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, h/2+30+h/18+h/13+333)'SUB TOTAL
		
		'e.Graphics.DrawString("TOTAL A PAGAR:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, top+h/18+h/13+283+20+15)'TOTAL PAGAR
		'e.Graphics.DrawString("TOTAL A PAGAR:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, h/2+30+h/18+h/13+333+15)'TOTAL PAGAR
		
		'e.Graphics.DrawString("LIQUIDACIÓN DEL IVA:  (5%)", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, top+h/18+h/13+283+20+31)'LIQUIDACIÓN DEL IVA
		'e.Graphics.DrawString("LIQUIDACIÓN DEL IVA:  (5%)", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+5, h/2+30+h/18+h/13+333+31)'LIQUIDACIÓN DEL IVA
		
		'e.Graphics.DrawString("(10%)", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+270, top+h/18+h/13+283+20+31)'10%
		'e.Graphics.DrawString("(10%)", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+270, h/2+30+h/18+h/13+333+31)'10%
		
		'e.Graphics.DrawString("TOTAL IVA:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+450, top+h/18+h/13+283+20+31)'TOTAL IVA
		'e.Graphics.DrawString("TOTAL IVA:", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+450, h/2+30+h/18+h/13+333+31)'TOTAL IVA
		
		
		'AQUI IMPRIMIMOS LA INFO SOBRE EL CLIENTE
		'fecha emision
		e.Graphics.DrawString(System.DateTime.Now.ToShortDateString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+110, top+h/18-15)'fecha emision
		e.Graphics.DrawString(System.DateTime.Now.ToShortDateString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+110, h/2+30+h/18-15)'fecha emision
		
		'nombre cliente
		e.Graphics.DrawString(tx_nom_cliente.Text, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+140, top+h/18+5)'NOMBRE CLIENTE
		e.Graphics.DrawString(tx_nom_cliente.Text, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+140, h/2+30+h/18+5)'NOMBRE CLIENTE
		
		'RUC
		e.Graphics.DrawString(tx_ruc_cliente.Text, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+70, top+h/18+25)'ruc
		e.Graphics.DrawString(tx_ruc_cliente.Text, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+70, h/2+30+h/18+25)'ruc
		
		'Direccion
		e.Graphics.DrawString(" - ", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+70, top+h/18+5+38)'dir
		e.Graphics.DrawString(" - ", New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+70, h/2+30+h/18+5+38)'dir
		
		'Telefono
		e.Graphics.DrawString(tx_tel_cliente.text, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+530, top+h/18+5+38)'Telefono
		e.Graphics.DrawString(tx_tel_cliente.text, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+530, h/2+30+h/18+5+38)'Telefono

		Dim i As Int16 = 0
		Dim total As Integer = 0
		Dim total_iva_5 As Integer = 0
		Dim total_iva_10 As Integer = 0
		For Each row As DataGridViewRow In DataGridView1.Rows
			cell = row.Cells(0)
			If cell.Value = True Then
				'MessageBox.Show(cell.Value.ToStrsing & " : " & row.Index.ToString)'debug
				
				e.Graphics.DrawString(row.cells(7).Value.ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+12, top+h/18+h/13+4+i)'cant
				e.Graphics.DrawString(row.cells(7).Value.ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+12, h/2+30+h/18+h/13+4+i)'cant
				
				'Las lineas comentadas imprimen el nro de item + la desc
				'e.Graphics.DrawString(row.cells(3).Value.ToString + "  "+row.cells(4).Value.ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+72, top+h/18+h/13+22+i)'descripcion
				'e.Graphics.DrawString(row.cells(3).Value.ToString + "  "+row.cells(4).Value.ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+72, h/2+30+h/18+h/13+22+i)'descripcion
				e.Graphics.DrawString(row.cells(4).Value.ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+72, top+h/18+h/13+4+i)'descripcion
				e.Graphics.DrawString(row.cells(4).Value.ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+72, h/2+30+h/18+h/13+4+i)'descripcion

				
				e.Graphics.DrawString(Math.Truncate(row.cells(13).Value).ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+508, top+h/18+h/13+4+i)'precio unitario
				e.Graphics.DrawString(Math.Truncate(row.cells(13).Value).ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+508, h/2+30+h/18+h/13+4+i)'precio unitario
				
				e.Graphics.DrawString((Math.Truncate(row.cells(7).Value)*Math.Truncate(row.cells(13).Value)).ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+735, top+h/18+h/13+4+i)'total
				e.Graphics.DrawString((Math.Truncate(row.cells(7).Value)*Math.Truncate(row.cells(13).Value)).ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+735, h/2+30+h/18+h/13+4+i)'total
				
				
				i= i+12'espacio entre lineas
				total = total + (Math.Truncate(row.cells(7).Value)*Math.Truncate(row.cells(13).Value))
			End If
		Next
		total_iva_5 = 0'total - total/1.05
		total_iva_10 = total - total/1.1
		
		
		
		'TOTAL IVA 5% MONTO
		e.Graphics.DrawString(total_iva_5, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+175, top+h/18+h/13+283+20+13)'TOTAL IVA
		e.Graphics.DrawString(total_iva_5, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+175, h/2+30+h/18+h/13+333+13)'TOTAL IVA
		
		'TOTAL IVA 10% MONTO
		e.Graphics.DrawString(total_iva_10, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+310, top+h/18+h/13+283+20+13)'TOTAL IVA
		e.Graphics.DrawString(total_iva_10, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+310, h/2+30+h/18+h/13+333+13)'TOTAL IVA
		
		'TOTAL IVA MONTO
		e.Graphics.DrawString(total_iva_10 + total_iva_5, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+520, top+h/18+h/13+283+20+13)'TOTAL IVA
		e.Graphics.DrawString(total_iva_10 + total_iva_5, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+520, h/2+30+h/18+h/13+333+13)'TOTAL IVA
		
        'SUBTOTAL
       	e.Graphics.DrawString(total.ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+725, top+h/18+h/13+283+2)'SUBTOTAL
       	e.Graphics.DrawString(total.ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular), Brushes.Black, left+725, h/2+30+h/18+h/13+315)'SUBTOTAL
       	
        'TOTAL EN NROS
       	e.Graphics.DrawString(total.ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+725, top+h/18+h/13+283+17)'TOTAL EN NROS
       	e.Graphics.DrawString(total.ToString, New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+725, h/2+30+h/18+h/13+330)'TOTAL EN NROS
       	
       	'TOTAL EN LETRAS
		e.Graphics.DrawString(letras(total), New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+110, top+h/18+h/13+283+17)'TOTAL en LETRAS
		e.Graphics.DrawString(letras(total), New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold), Brushes.Black, left+110, h/2+30+h/18+h/13+330)'TOTAL en LETRAS
		
		Dim blackPen As New Pen(Color.DarkGray, 1)
		'e.Graphics.DrawLine(blackPen,left,486,left+w-150,486)
		'e.Graphics.DrawLine(blackPen,left,502,left+w,502)
		'e.Graphics.DrawLine(Pens.Black,w-300+105,468,w-300+105,485)
		'e.Graphics.DrawLine(Pens.Black,left+w-300+150,468,left+w-300+150,502)
		'abajo
		'e.Graphics.DrawLine(blackPen,left,1036,left+w-150,1036)
		'e.Graphics.DrawLine(blackPen,left,1052,left+w,1052)
		'e.Graphics.DrawLine(Pens.Black,w-300+105,1018,w-300+105,1036)
		'e.Graphics.DrawLine(Pens.Black,left+w-300+150,1018,left+w-300+150,1052)
		
		
	End Sub
	
	'debug -- no usamos
	Sub PrintDocument1PrintPage_(sender As Object, e As PrintPageEventArgs)
		Static currentChar As Integer
		Static currentLine As Integer
		Dim textfont As Font = tx_nom_cliente.Font
		Dim h, w As Integer
		Dim left, top As Integer
		
		
		'SETEAMOS a A4
		Dim ps As New PaperSize("A4", 850, 1100)
		ps.PaperName = PaperKind.A4
		PrintDocument1.DefaultPageSettings.PaperSize = ps
		
       With PrintDocument1.DefaultPageSettings
           'h = .PaperSize.Height - .Margins.Top - .Margins.Bottom
           'w = .PaperSize.Width - .Margins.Left - .Margins.Right
           'left = PrintDocument1.DefaultPageSettings.Margins.Left
           'top = PrintDocument1.DefaultPageSettings.Margins.Top
           
           h = .PaperSize.Height-100
           w = .PaperSize.Width-100
           left = .Margins.Left
           top = .Margins.Top
       End With
       
       
       'e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, top, w, h))
       e.Graphics.DrawRectangle(Pens.black, New Rectangle(left, top, w, h))
       
       'lo de landscape no importa
       If PrintDocument1.DefaultPageSettings.Landscape Then
           Dim a As Integer
           a = h
           h = w
           w = a
       End If
       
       Dim lines As Integer = CInt(Math.Round(h / textfont.Height))
       Dim b As New Rectangle(left, top, w, h)
       Dim format As StringFormat
       
       If Not tx_nom_cliente.WordWrap Then
           format = New StringFormat(StringFormatFlags.NoWrap)
           format.Trimming = StringTrimming.EllipsisWord
           Dim i As Integer
           For i = currentLine To Math.Min(currentLine + lines, tx_nom_cliente.Lines.Length - 1)
               e.Graphics.DrawString(tx_nom_cliente.Lines(i), textfont, Brushes.Black, New RectangleF(left, top + textfont.Height * (i - currentLine), w, textfont.Height), format)
           Next
           currentLine += lines
           If currentLine >= tx_nom_cliente.Lines.Length Then
               e.HasMorePages = False
               currentLine = 0
           Else
               e.HasMorePages = True
           End If
           Exit Sub
       End If
       
       format = New StringFormat(StringFormatFlags.LineLimit)
       Dim line, chars As Integer
       e.Graphics.MeasureString(Mid(tx_nom_cliente.Text, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
       If currentChar + chars < tx_nom_cliente.Text.Length Then
           If tx_nom_cliente.Text.Substring(currentChar + chars, 1) <> " " And tx_nom_cliente.Text.Substring(currentChar + chars, 1) <> vbLf Then
               While chars > 0
                   tx_nom_cliente.Text.Substring(currentChar + chars, 1)
                   tx_nom_cliente.Text.Substring(currentChar + chars, 1)
                   chars -= 1
               End While
               chars += 1
           End If
       End If
       
       e.Graphics.DrawString(tx_nom_cliente.Text.Substring(currentChar, chars), textfont, Brushes.Black, b, format)
       currentChar = currentChar + chars
       If currentChar < tx_nom_cliente.Text.Length Then
           e.HasMorePages = True
       Else
           e.HasMorePages = False
           currentChar = 0
       End If
	End Sub
	
	Sub Button5Click(sender As Object, e As EventArgs)
		'Exportar a Excel todos los tickets
		'Traemos todos los valores para crear un excel
		
		Dim cmd As System.Data.SqlServerCe.SqlCeCommand
		'Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = C:\Users\user\Desktop\SambaData2.sdf")'debug
		Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = C:\Users\Paco Requena\Documents\SambaPOS2\SambaData2.sdf")'release
		
		
		Dim consulta As String = "Select * from TicketItems"
		
		'Dim consulta As String = "Select Id, TicketId, MenuItemId, MenuItemName, PortionName, CurrencyCode, Quantity, PortionCount, OrderNumber, CreatingUserId, CreatedDateTime, ModifiedDateTime" & _
		'"from TicketItems where TicketId = 100"
		'Dim datos As System.Data.SqlServerCe.SqlCeDataReader
		
		Try
			conn.Open()
			cmd = conn.CreateCommand()
		    cmd.CommandText = consulta
		    'cmd.ExecuteNonQuery()
		    'datos = cmd.ExecuteReader()
		   	Dim dt = new DataTable()
		    
		    'datos.Read()
		    dt.Load(cmd.ExecuteReader())
		    'AHORA GENERAR EXCEL CON LA INFO
		    
			Dim xlApp As Excel.Application = New Microsoft.Office.Interop.Excel.Application()
	
	        If xlApp Is Nothing Then
	            MessageBox.Show("Excel no esta instalado!!")
	            Return
	        End If
	
	        Dim xlWorkBook As Excel.Workbook
	        Dim xlWorkSheet As Excel.Worksheet
	        Dim misValue As Object = System.Reflection.Missing.Value
	
	        xlApp = New Excel.ApplicationClass
	        xlWorkBook = xlApp.Workbooks.Add(misValue)
	        xlWorkSheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)
	        
	        Dim dc As System.Data.DataColumn
	        Dim dr As System.Data.DataRow
	        Dim colIndex As Integer = 0
	        Dim rowIndex As Integer = 0
	        
	        

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                xlApp.Cells(1, colIndex) = dc.ColumnName
            Next
            
            'FORMA LENTA DE PONER FILAS
            'For Each dr In dt.Rows
            '    rowIndex = rowIndex + 1
            '    colIndex = 0
            '    For Each dc In dt.Columns
            '        colIndex = colIndex + 1
            '        xlApp.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            '    Next
            'Next
            
            'FORMA RAPIDA
            Dim arr As Object(,) = New Object(dt.Rows.Count - 1, dt.Columns.Count - 1) {}
		    For r As Integer = 0 To dt.Rows.Count - 1
		        dr = dt.Rows(r)
		        For c As Integer = 0 To dt.Columns.Count - 1
		            arr(r, c) = dr(c)
		        Next
		    Next
		    
		    'copiando info
		    Dim c1 As Excel.Range = CType(xlWorkSheet.Cells(2, 1), Excel.Range)
		    Dim c2 As Excel.Range = CType(xlWorkSheet.Cells(2 + dt.Rows.Count - 1, dt.Columns.Count), Excel.Range)
		    Dim range As Excel.Range = xlWorkSheet.Range(c1, c2)
		    range.Value = arr
		    
		    
            xlWorkSheet.Columns.AutoFit()
            
            
	        xlWorkSheet.SaveAs("C:\Users\user\AM_FACTURACION.xlsx")
	        xlWorkBook.Close()
	        xlApp.Quit()
	
	        clean_obj(xlApp)
	        clean_obj(xlWorkBook)
	        clean_obj(xlWorkSheet)
	
			MsgBox("Base de datos exportada en C:\Users\user\AM_FACTURACION.xlsx")
	
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
		    conn.Close()
		End Try
		
		
	End Sub
	
	
    Private Sub clean_obj(ByVal obj As Object)
	    Try
	        System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
	        obj = Nothing
	    Catch ex As Exception
	        obj = Nothing
	    Finally
	        GC.Collect()
	    End Try
    End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		'MessageBox.Show(centro)'debug de paso de centro de costo
		If centro = "AQUI MADRID" then
			Me.label7.Text = "001-001"
		Else
			Me.label7.Text = "002-001"
		End If
		
		'VEMOS cual es la ultima factura cargada y sugerimos el nro.
'... completar
		
	End Sub
	
	Private Sub TextBox1KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

    '97 - 122 = Ascii codes for simple letters
    '65 - 90  = Ascii codes for capital letters
    '48 - 57  = Ascii codes for numbers

    If Asc(e.KeyChar) <> 8 Then
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End If

End Sub
	
	Sub TextBox1TextChanged(sender As Object, e As EventArgs)
		'a medida que tipeamos mostramos la factura.
		Me.label8.Text = textBox1.text
	End Sub
	
	Sub Button6Click(sender As Object, e As EventArgs)
		'prueba de nro a texto
		'MessageBox.show("1451671  /  " & letras(1451671))
		
		Dim pkInstalledPrinters As String
	    ' Find all printers installed
	    For Each pkInstalledPrinters In _
	        PrinterSettings.InstalledPrinters
	        Messagebox.Show(pkInstalledPrinters)
	    Next pkInstalledPrinters
	
	End Sub
	
	
	'sacado de https://www.lawebdelprogramador.com/foros/Visual-Basic.NET/839884-Numeros-a-letras-una-forma-facil.html
    Public Function letras(ByVal nCifra As Object) As String
        ' Defino variables
        Dim cifra, bloque, decimales, cadena As String
        Dim longituid, posision, unidadmil As Byte
 
        ' En caso de que unidadmil sea:
        ' 0 = cientos
        ' 1 = miles
        ' 2 = millones
        ' 3 = miles de millones
        ' 4 = billones
        ' 5 = miles de billones
 
        ' Reemplazo el símbolo decimal por un punto (.) y luego guardo la parte entera y la decimal por separado
        ' Es necesario poner el cero a la izquierda del punto así si el valor es de sólo decimales, se lo fuerza
        ' a colocar el cero para que no genere error
        cifra = Format(CType(nCifra, Decimal), "###############0.#0")
        decimales = Microsoft.VisualBasic.Mid(cifra, Len(cifra) - 1, 2)
        cifra = Microsoft.VisualBasic.Left(cifra, Len(cifra) - 3)
 
        ' Verifico que el valor no sea cero
        If cifra = "0" Then
            Return IIf(decimales = "00", "cero", "cero con " & decimales & "/100")
        End If
 
        ' Evaluo su longitud (como mínimo una cadena debe tener 3 dígitos)
        If Len(cifra) < 3 Then
            cifra = Rellenar(cifra, 3)
        End If
 
        ' Invierto la cadena
        cifra = Invertir(cifra)
 
        ' Inicializo variables
        posision = 1
        unidadmil = 0
        cadena = ""
 
        ' Selecciono bloques de a tres cifras empezando desde el final (de la cadena invertida)
        Do While posision <= Len(cifra)
            ' Selecciono una porción del numero
            bloque = Mid(cifra, posision, 3)
 
            ' Transformo el número a cadena
            cadena = Convertir(bloque, unidadmil) & " " & cadena.Trim
 
            ' Incremento la cantidad desde donde seleccionar la subcadena
            posision = posision + 3
 
            ' Incremento la posisión de la unidad de mil
            unidadmil = unidadmil + 1
        Loop
 
        ' Cargo la función
        Return IIf(decimales = "00", cadena.Trim.ToLower, cadena.Trim.ToLower & " con " & decimales & "/100")
    End Function
 
    ' Esta función es complemento de la función de conversión.
    ' En los arrays se agrega una posisión inicial vacía ya que VB.NET empieza de la posisión cero
    Private Function Convertir(ByVal cadena As String, ByVal unidadmil As Byte) As String
        ' Defino variables
        Dim centena, decena, unidad As Byte
 
        ' Invierto la subcadena (la original habia sido invertida en el procedimiento NumeroATexto)
        cadena = Invertir(cadena)
 
        ' Determino la longitud de la cadena
        If Len(cadena) < 3 Then
            cadena = Rellenar(cadena, 3)
        End If
 
        ' Verifico que la cadena no esté vacía (000)
        If cadena = "000" Then
            Return ""
        End If
 
        ' Desarmo el numero (empiezo del dígito cero por el manejo de cadenas de VB.NET)
        centena = CType(cadena.Substring(0, 1), Byte)
        decena = CType(cadena.Substring(1, 1), Byte)
        unidad = CType(cadena.Substring(2, 1), Byte)
        cadena = ""
 
        ' Calculo las centenas
        If centena <> 0 Then
            Dim centenas() As String = {"", IIf(decena = 0 And unidad = 0, "cien", "ciento"), "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"}
            cadena = centenas(centena)
        End If
 
        ' Calculo las decenas
        If decena <> 0 Then
            Dim decenas() As String = {"", IIf(unidad = 0, "diez", IIf(unidad >= 6, "dieci", IIf(unidad = 1, "once", IIf(unidad = 2, "doce", IIf(unidad = 3, "trece", IIf(unidad = 4, "catorce", "quince")))))), IIf(unidad = 0, "veinte", "venti"), "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"}
            cadena = cadena & " " & decenas(decena)
        End If
 
        ' Calculo las unidades (no pregunten por que este IF es necesario ... simplemente funciona)
        If decena = 1 And unidad < 6 Then
        Else
            Dim unidades() As String = {"", IIf(decena <> 1, IIf(unidadmil = 1, "un", "uno"), ""), "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"}
            If decena >= 3 And unidad <> 0 Then
                cadena = cadena.Trim & " y "
            End If
 
            If decena = 0 Then
                cadena = cadena.Trim & " "
            End If
            cadena = cadena & unidades(unidad)
        End If
 
        ' Evaluo la posision de miles, millones, etc
        If unidadmil <> 0 Then
            Dim agregado() As String = {"", "mil", IIf((centena = 0) And (decena = 0) And (unidad = 1), "millón", "millones"), "mil millones", "billones", "mil billones"}
            If (centena = 0) And (decena = 0) And (unidad = 1) And unidadmil = 2 Then
                cadena = "un"
            End If
            cadena = cadena & " " & agregado(unidadmil) 
        End If
 
        ' Cargo la función
        Return cadena.Trim '& " Guaraníes"
    End Function
 
    ' Esta función recibe una cadena de caracteres y la devuelve "invertida".
    Public Function Invertir(ByVal cadena As String) As String
        ' Defino variables
        Dim retornar As String
 
        ' Inviero la cadena
        For posision As Short = cadena.Length To 1 Step -1
            retornar = retornar & cadena.Substring(posision - 1, 1)
        Next
 
        ' Retorno la cadena invertida
        Return retornar
    End Function
 
    ' Esta función rellena con ceros a la izquierda un número pasado como parámetro. Con el parámetro "cifras" se especifica la cantidad de dígitos a la izquierda.
    Public Function Rellenar(ByVal valor As Object, ByVal cifras As Byte) As String
        ' Defino variables
        Dim cadena As String
 
        ' Verifico el valor pasado
        If Not IsNumeric(valor) Then
            valor = 0
        Else
            valor = CType(valor, Integer)
        End If
 
        ' Cargo la cadena
        cadena = valor.ToString.Trim
 
        ' Relleno con los ceros que sean necesarios para llenar los dígitos pedidos
        For puntero As Byte = (Len(cadena) + 1) To cifras
            cadena = "0" & cadena
        Next puntero
 
        ' Cargo la función
        Return cadena
    End Function
	
	Sub DataGridView1CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		'MessageBox.Show(DataGridView1.Columns(e.ColumnIndex).Name.ToString)'debug
		'el nombre del item columna
		if DataGridView1.Columns(e.ColumnIndex).Name = "checito" Then
			' Your code
			'MessageBox.Show("clickeado")'debug
		End If		
	End Sub
End Class
