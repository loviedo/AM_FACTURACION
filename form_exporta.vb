'
' Created by SharpDevelop.
' User: loviedo
' Date: 16/6/2018
' Time: 18:56
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Imports Excel = Microsoft.Office.Interop.Excel

Public Partial Class form_exporta
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		'Exportar a Excel todos los tickets
		'Traemos todos los valores para crear un excel
		
		Dim cmd As System.Data.SqlServerCe.SqlCeCommand
		Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = D:\PROYECTOS\SharpDevelop Projects\SambaData2.sdf")
		
		Dim consulta As String = "Select TicketId, MenuItemId, MenuItemName, Price, Quantity, OrderNumber, CreatedDateTime, ModifiedDAteTime from TicketItems where CreatedDateTime >= cast('" & fec_desde.Text & " 00:00' as datetime) and CreatedDateTime <= cast('" & fec_hasta.Text & " 23:59' as datetime)"
		
		'MessageBox.Show(consulta)'debug
		
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
	
	Sub Form_exportaLoad(sender As Object, e As EventArgs)
		Me.tabPage1.Text = "Facturas"
		Me.tabPage2.Text = "Clientes"
		
		fec_desde.Format = DateTimePickerFormat.Custom
    	fec_desde.CustomFormat = "MM/dd/yy"
		fec_hasta.Format = DateTimePickerFormat.Custom
    	fec_hasta.CustomFormat = "MM/dd/yy"
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		'Traemos todo lo que hay en clientes.	
		'Traemos todos los valores para crear un excel
		
		Dim cmd As System.Data.SqlServerCe.SqlCeCommand
		Dim conn = New System.Data.SqlServerCe.SqlCeConnection("Data Source = D:\PROYECTOS\SharpDevelop Projects\SambaData2.sdf")
		
		Dim consulta As String = "Select * from Clientes"
	
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
            
            
	        xlWorkSheet.SaveAs("C:\Users\user\AM_CLIENTES.xlsx")
	        xlWorkBook.Close()
	        xlApp.Quit()
	
	        clean_obj(xlApp)
	        clean_obj(xlWorkBook)
	        clean_obj(xlWorkSheet)
	
			MsgBox("Base de datos exportada en C:\Users\user\AM_CLIENTES.xlsx")
	
		Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
		Finally
		    conn.Close()
		End Try
	End Sub
End Class
