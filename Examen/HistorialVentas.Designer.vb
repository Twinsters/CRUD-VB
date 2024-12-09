<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvVentasRealizadas = New System.Windows.Forms.DataGridView()
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox()
        Me.Facturas = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscarFiltro = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dgvVentasRealizadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Facturas.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvVentasRealizadas
        '
        Me.dgvVentasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentasRealizadas.Location = New System.Drawing.Point(34, 115)
        Me.dgvVentasRealizadas.Name = "dgvVentasRealizadas"
        Me.dgvVentasRealizadas.ReadOnly = True
        Me.dgvVentasRealizadas.RowHeadersVisible = False
        Me.dgvVentasRealizadas.RowTemplate.Height = 25
        Me.dgvVentasRealizadas.Size = New System.Drawing.Size(717, 367)
        Me.dgvVentasRealizadas.TabIndex = 0
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.Location = New System.Drawing.Point(34, 50)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(241, 23)
        Me.txtNombreBuscar.TabIndex = 1
        '
        'Facturas
        '
        Me.Facturas.Controls.Add(Me.Label3)
        Me.Facturas.Controls.Add(Me.Label2)
        Me.Facturas.Controls.Add(Me.Label1)
        Me.Facturas.Controls.Add(Me.dtpDesde)
        Me.Facturas.Controls.Add(Me.DtpHasta)
        Me.Facturas.Controls.Add(Me.btnBuscarFiltro)
        Me.Facturas.Controls.Add(Me.dgvVentasRealizadas)
        Me.Facturas.Controls.Add(Me.txtNombreBuscar)
        Me.Facturas.Location = New System.Drawing.Point(46, 32)
        Me.Facturas.Name = "Facturas"
        Me.Facturas.Size = New System.Drawing.Size(806, 498)
        Me.Facturas.TabIndex = 2
        Me.Facturas.TabStop = False
        Me.Facturas.Text = "Factuas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(342, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desde:"
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(390, 22)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(220, 23)
        Me.dtpDesde.TabIndex = 5
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(390, 65)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(220, 23)
        Me.DtpHasta.TabIndex = 4
        '
        'btnBuscarFiltro
        '
        Me.btnBuscarFiltro.Location = New System.Drawing.Point(635, 41)
        Me.btnBuscarFiltro.Name = "btnBuscarFiltro"
        Me.btnBuscarFiltro.Size = New System.Drawing.Size(103, 39)
        Me.btnBuscarFiltro.TabIndex = 2
        Me.btnBuscarFiltro.Text = "Buscar"
        Me.btnBuscarFiltro.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(732, 536)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'HistorialVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 588)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Facturas)
        Me.Name = "HistorialVentas"
        Me.Text = "Historial de Ventas"
        CType(Me.dgvVentasRealizadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Facturas.ResumeLayout(False)
        Me.Facturas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvVentasRealizadas As DataGridView
    Friend WithEvents txtNombreBuscar As TextBox
    Friend WithEvents Facturas As GroupBox
    Friend WithEvents btnBuscarFiltro As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents btnSalir As Button
End Class
