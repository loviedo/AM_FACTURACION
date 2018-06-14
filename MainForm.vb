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

Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		
		Dim cmd As System.Data.SqlServerCe.SqlCeCommand
		Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = C:\Users\user\Desktop\SambaData2.sdf")
		
		Dim consulta As String = "Select Id, TicketId, MenuItemId, MenuItemName, PortionName, CurrencyCode, Quantity, PortionCount, OrderNumber, CreatingUserId, " & _
			"CreatedDateTime, ModifiedDateTime, Price from TicketItems where TicketId = " & tx_ticket.Text.Trim
		
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
		    
		    
		    
		    
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
		    conn.Close()
		End Try
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		'cerramos el programa
		Application.exit
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
        	
    	Else
        	'tx_nom_cliente.Text = "Cancelado"
    	End If
    	cliente.Dispose()
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		
		'imprimos el PDF, mandamos a la impresora
		   PrintDialog1.Document = PrintDocument1
		   PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
		   PrintDialog1.AllowSomePages = True
		   
		   If PrintDialog1.ShowDialog = DialogResult.OK Then
		      PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
		      PrintDocument1.Print()
		   End If
		   
	End Sub
	
	Sub PrintDocument1PrintPage(sender As Object, e As PrintPageEventArgs)
		Static currentChar As Integer
       Static currentLine As Integer
       Dim textfont As Font = tx_nom_cliente.Font
       Dim h, w As Integer
       Dim left, top As Integer
       With PrintDocument1.DefaultPageSettings
           h = .PaperSize.Height - .Margins.Top - .Margins.Bottom
           w = .PaperSize.Width - .Margins.Left - .Margins.Right
           left = PrintDocument1.DefaultPageSettings.Margins.Left
           top = PrintDocument1.DefaultPageSettings.Margins.Top
       End With
       e.Graphics.DrawRectangle(Pens.Blue, New Rectangle(left, top, w, h))
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
		
		
	End Sub
End Class
