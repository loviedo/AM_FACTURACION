'
' Created by SharpDevelop.
' User: loviedo
' Date: 16/6/2018
' Time: 10:19
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form_principal
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.aRchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.adminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.salirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.facturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.facturarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.exportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.listadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.acercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.programaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.label1 = New System.Windows.Forms.Label()
		Me.menuStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aRchivoToolStripMenuItem, Me.facturaciónToolStripMenuItem, Me.exportarToolStripMenuItem, Me.acercaDeToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(1177, 24)
		Me.menuStrip1.TabIndex = 0
		Me.menuStrip1.Text = "menuStrip1"
		'
		'aRchivoToolStripMenuItem
		'
		Me.aRchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.adminToolStripMenuItem, Me.salirToolStripMenuItem})
		Me.aRchivoToolStripMenuItem.Name = "aRchivoToolStripMenuItem"
		Me.aRchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
		Me.aRchivoToolStripMenuItem.Text = "Archivo"
		'
		'adminToolStripMenuItem
		'
		Me.adminToolStripMenuItem.Name = "adminToolStripMenuItem"
		Me.adminToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
		Me.adminToolStripMenuItem.Text = "Admin"
		AddHandler Me.adminToolStripMenuItem.Click, AddressOf Me.AdminToolStripMenuItemClick
		'
		'salirToolStripMenuItem
		'
		Me.salirToolStripMenuItem.Name = "salirToolStripMenuItem"
		Me.salirToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
		Me.salirToolStripMenuItem.Text = "Salir"
		AddHandler Me.salirToolStripMenuItem.Click, AddressOf Me.SalirToolStripMenuItemClick
		'
		'facturaciónToolStripMenuItem
		'
		Me.facturaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.facturarToolStripMenuItem})
		Me.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem"
		Me.facturaciónToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
		Me.facturaciónToolStripMenuItem.Text = "Facturación"
		'
		'facturarToolStripMenuItem
		'
		Me.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem"
		Me.facturarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
		Me.facturarToolStripMenuItem.Text = "Facturar"
		AddHandler Me.facturarToolStripMenuItem.Click, AddressOf Me.FacturarToolStripMenuItemClick
		'
		'exportarToolStripMenuItem
		'
		Me.exportarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.listadosToolStripMenuItem})
		Me.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem"
		Me.exportarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
		Me.exportarToolStripMenuItem.Text = "Exportar"
		'
		'listadosToolStripMenuItem
		'
		Me.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem"
		Me.listadosToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
		Me.listadosToolStripMenuItem.Text = "Listados"
		AddHandler Me.listadosToolStripMenuItem.Click, AddressOf Me.ListadosToolStripMenuItemClick
		'
		'acercaDeToolStripMenuItem
		'
		Me.acercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.programaToolStripMenuItem})
		Me.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem"
		Me.acercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
		Me.acercaDeToolStripMenuItem.Text = "Acerca de"
		'
		'programaToolStripMenuItem
		'
		Me.programaToolStripMenuItem.Name = "programaToolStripMenuItem"
		Me.programaToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.programaToolStripMenuItem.Text = "Programa"
		AddHandler Me.programaToolStripMenuItem.Click, AddressOf Me.ProgramaToolStripMenuItemClick
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(12, 51)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(328, 35)
		Me.label1.TabIndex = 1
		Me.label1.Text = "label1"
		'
		'form_principal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1177, 595)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "form_principal"
		Me.Text = "form_principal"
		AddHandler Load, AddressOf Me.Form_principalLoad
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label1 As System.Windows.Forms.Label
	Private adminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private programaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private acercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private listadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private exportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private facturarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private facturaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private salirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private aRchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
End Class
