<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gbx_agregar = New System.Windows.Forms.GroupBox()
        Me.btn_menor = New System.Windows.Forms.Button()
        Me.btn_mayor = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_provincia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_poblacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbx_provincias = New System.Windows.Forms.GroupBox()
        Me.lv_provincias = New System.Windows.Forms.ListView()
        Me.gbx_agregar.SuspendLayout()
        Me.gbx_provincias.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_agregar
        '
        Me.gbx_agregar.BackColor = System.Drawing.Color.Transparent
        Me.gbx_agregar.Controls.Add(Me.txt_poblacion)
        Me.gbx_agregar.Controls.Add(Me.Label3)
        Me.gbx_agregar.Controls.Add(Me.btn_menor)
        Me.gbx_agregar.Controls.Add(Me.btn_mayor)
        Me.gbx_agregar.Controls.Add(Me.btn_agregar)
        Me.gbx_agregar.Controls.Add(Me.txt_codigo)
        Me.gbx_agregar.Controls.Add(Me.txt_provincia)
        Me.gbx_agregar.Controls.Add(Me.Label1)
        Me.gbx_agregar.Controls.Add(Me.Label2)
        Me.gbx_agregar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_agregar.ForeColor = System.Drawing.Color.White
        Me.gbx_agregar.Location = New System.Drawing.Point(26, 12)
        Me.gbx_agregar.Name = "gbx_agregar"
        Me.gbx_agregar.Size = New System.Drawing.Size(501, 213)
        Me.gbx_agregar.TabIndex = 3
        Me.gbx_agregar.TabStop = False
        Me.gbx_agregar.Text = "Agregar Provincia"
        '
        'btn_menor
        '
        Me.btn_menor.BackColor = System.Drawing.Color.Maroon
        Me.btn_menor.Location = New System.Drawing.Point(228, 164)
        Me.btn_menor.Name = "btn_menor"
        Me.btn_menor.Size = New System.Drawing.Size(111, 38)
        Me.btn_menor.TabIndex = 6
        Me.btn_menor.Text = "Menor"
        Me.btn_menor.UseVisualStyleBackColor = False
        '
        'btn_mayor
        '
        Me.btn_mayor.BackColor = System.Drawing.Color.Maroon
        Me.btn_mayor.Location = New System.Drawing.Point(111, 164)
        Me.btn_mayor.Name = "btn_mayor"
        Me.btn_mayor.Size = New System.Drawing.Size(111, 38)
        Me.btn_mayor.TabIndex = 5
        Me.btn_mayor.Text = "Mayor"
        Me.btn_mayor.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Maroon
        Me.btn_agregar.Location = New System.Drawing.Point(354, 164)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(111, 38)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(151, 88)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(314, 31)
        Me.txt_codigo.TabIndex = 3
        '
        'txt_provincia
        '
        Me.txt_provincia.Location = New System.Drawing.Point(151, 50)
        Me.txt_provincia.Name = "txt_provincia"
        Me.txt_provincia.Size = New System.Drawing.Size(314, 31)
        Me.txt_provincia.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Provincia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(24, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código:"
        '
        'txt_poblacion
        '
        Me.txt_poblacion.Location = New System.Drawing.Point(151, 127)
        Me.txt_poblacion.Name = "txt_poblacion"
        Me.txt_poblacion.Size = New System.Drawing.Size(314, 31)
        Me.txt_poblacion.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(24, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Población:"
        '
        'gbx_provincias
        '
        Me.gbx_provincias.BackColor = System.Drawing.Color.Transparent
        Me.gbx_provincias.Controls.Add(Me.lv_provincias)
        Me.gbx_provincias.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_provincias.ForeColor = System.Drawing.Color.White
        Me.gbx_provincias.Location = New System.Drawing.Point(26, 245)
        Me.gbx_provincias.Name = "gbx_provincias"
        Me.gbx_provincias.Size = New System.Drawing.Size(501, 250)
        Me.gbx_provincias.TabIndex = 4
        Me.gbx_provincias.TabStop = False
        Me.gbx_provincias.Text = "Lista de provincias"
        '
        'lv_provincias
        '
        Me.lv_provincias.FullRowSelect = True
        Me.lv_provincias.GridLines = True
        Me.lv_provincias.HideSelection = False
        Me.lv_provincias.Location = New System.Drawing.Point(21, 42)
        Me.lv_provincias.Name = "lv_provincias"
        Me.lv_provincias.Size = New System.Drawing.Size(447, 185)
        Me.lv_provincias.TabIndex = 5
        Me.lv_provincias.UseCompatibleStateImageBehavior = False
        Me.lv_provincias.View = System.Windows.Forms.View.List
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Provincias.My.Resources.Resources.books_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(576, 514)
        Me.Controls.Add(Me.gbx_provincias)
        Me.Controls.Add(Me.gbx_agregar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbx_agregar.ResumeLayout(False)
        Me.gbx_agregar.PerformLayout()
        Me.gbx_provincias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_agregar As GroupBox
    Friend WithEvents txt_poblacion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_menor As Button
    Friend WithEvents btn_mayor As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_provincia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbx_provincias As GroupBox
    Friend WithEvents lv_provincias As ListView
End Class
