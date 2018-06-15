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
		'Traemos todos los valores para crear un excel
		
		Dim cmd As System.Data.SqlServerCe.SqlCeCommand
		Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = C:\Users\user\Desktop\SambaData2.sdf")
		
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
		    
		    Dim c1 As Excel.Range = CType(xlWorkSheet.Cells(2, 1), Excel.Range)
		    Dim c2 As Excel.Range = CType(xlWorkSheet.Cells(2 + dt.Rows.Count - 1, dt.Columns.Count), Excel.Range)
		    Dim range As Excel.Range = xlWorkSheet.Range(c1, c2)
		    range.Value = arr
            
            xlWorkSheet.Columns.AutoFit()
            
            
	        xlWorkSheet.SaveAs("C:\Users\user\AM_FACTURACION.xlsx")
	
	        xlWorkBook.Close()
	        xlApp.Quit()
	
	        releaseObject(xlApp)
	        releaseObject(xlWorkBook)
	        releaseObject(xlWorkSheet)
	
			MsgBox("Base de datos exportada en C:\Users\user\AM_FACTURACION.xlsx")
	
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
		    conn.Close()
		End Try
		
		
	End Sub
	
	
    Private Sub releaseObject(ByVal obj As Object)
	    Try
	        System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
	        obj = Nothing
	    Catch ex As Exception
	        obj = Nothing
	    Finally
	        GC.Collect()
	    End Try
    End Sub
End Class
