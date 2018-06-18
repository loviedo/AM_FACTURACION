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
		   
		   'http://www.visual-basic-tutorials.com/Tutorials/Controls/PrintPreviewDialog.html
		   'https://msdn.microsoft.com/en-us/library/system.windows.forms.printpreviewdialog.printpreviewdialog(v=vs.110).aspx
		   PrintPreviewDialog1.Document = PrintDocument1
		   PrintPreviewDialog1.ShowDialog()'mostramos el preview de impresion y luego el dialogo de impresion
		   
		   If PrintDialog1.ShowDialog = DialogResult.OK Then
		      PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
		      PrintDocument1.Print()
		   End If
		   
		   'AQUI GUARDAMOS LOS DATOS DE LA FACTURA IMPRESA
		   
		   
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
		MessageBox.show("1451671  /  " & letras(1451671))
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
	
End Class
