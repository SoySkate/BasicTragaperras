<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2KedyDown
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BtnCargarLista = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.LabelMedia = New System.Windows.Forms.Label()
        Me.LabelMediana = New System.Windows.Forms.Label()
        Me.LabelModa = New System.Windows.Forms.Label()
        Me.LabelDesviacionTipica = New System.Windows.Forms.Label()
        Me.TextBoxMedia = New System.Windows.Forms.TextBox()
        Me.TextBoxModa = New System.Windows.Forms.TextBox()
        Me.TextBoxMediana = New System.Windows.Forms.TextBox()
        Me.TextBoxDesviacionTipica = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(88, 23)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(147, 342)
        Me.ListBox1.TabIndex = 0
        '
        'BtnCargarLista
        '
        Me.BtnCargarLista.Location = New System.Drawing.Point(330, 26)
        Me.BtnCargarLista.Name = "BtnCargarLista"
        Me.BtnCargarLista.Size = New System.Drawing.Size(148, 23)
        Me.BtnCargarLista.TabIndex = 1
        Me.BtnCargarLista.Text = "Cargar List"
        Me.BtnCargarLista.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(88, 394)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "Borrar Datos"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(681, 394)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(525, 62)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 4
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'LabelMedia
        '
        Me.LabelMedia.AutoSize = True
        Me.LabelMedia.Location = New System.Drawing.Point(447, 117)
        Me.LabelMedia.Name = "LabelMedia"
        Me.LabelMedia.Size = New System.Drawing.Size(36, 13)
        Me.LabelMedia.TabIndex = 5
        Me.LabelMedia.Text = "Media"
        '
        'LabelMediana
        '
        Me.LabelMediana.AutoSize = True
        Me.LabelMediana.Location = New System.Drawing.Point(447, 171)
        Me.LabelMediana.Name = "LabelMediana"
        Me.LabelMediana.Size = New System.Drawing.Size(48, 13)
        Me.LabelMediana.TabIndex = 6
        Me.LabelMediana.Text = "Mediana"
        '
        'LabelModa
        '
        Me.LabelModa.AutoSize = True
        Me.LabelModa.Location = New System.Drawing.Point(447, 225)
        Me.LabelModa.Name = "LabelModa"
        Me.LabelModa.Size = New System.Drawing.Size(34, 13)
        Me.LabelModa.TabIndex = 7
        Me.LabelModa.Text = "Moda"
        '
        'LabelDesviacionTipica
        '
        Me.LabelDesviacionTipica.AutoSize = True
        Me.LabelDesviacionTipica.Location = New System.Drawing.Point(447, 287)
        Me.LabelDesviacionTipica.Name = "LabelDesviacionTipica"
        Me.LabelDesviacionTipica.Size = New System.Drawing.Size(90, 13)
        Me.LabelDesviacionTipica.TabIndex = 8
        Me.LabelDesviacionTipica.Text = "Desviación típica"
        '
        'TextBoxMedia
        '
        Me.TextBoxMedia.Location = New System.Drawing.Point(606, 114)
        Me.TextBoxMedia.Name = "TextBoxMedia"
        Me.TextBoxMedia.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMedia.TabIndex = 9
        '
        'TextBoxModa
        '
        Me.TextBoxModa.Location = New System.Drawing.Point(606, 222)
        Me.TextBoxModa.Name = "TextBoxModa"
        Me.TextBoxModa.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxModa.TabIndex = 10
        '
        'TextBoxMediana
        '
        Me.TextBoxMediana.Location = New System.Drawing.Point(606, 164)
        Me.TextBoxMediana.Name = "TextBoxMediana"
        Me.TextBoxMediana.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMediana.TabIndex = 11
        '
        'TextBoxDesviacionTipica
        '
        Me.TextBoxDesviacionTipica.Location = New System.Drawing.Point(606, 280)
        Me.TextBoxDesviacionTipica.Name = "TextBoxDesviacionTipica"
        Me.TextBoxDesviacionTipica.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDesviacionTipica.TabIndex = 12
        '
        'Form2KedyDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxDesviacionTipica)
        Me.Controls.Add(Me.TextBoxMediana)
        Me.Controls.Add(Me.TextBoxModa)
        Me.Controls.Add(Me.TextBoxMedia)
        Me.Controls.Add(Me.LabelDesviacionTipica)
        Me.Controls.Add(Me.LabelModa)
        Me.Controls.Add(Me.LabelMediana)
        Me.Controls.Add(Me.LabelMedia)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnCargarLista)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form2KedyDown"
        Me.Text = "Form2KedyDown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BtnCargarLista As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents LabelMedia As Label
    Friend WithEvents LabelMediana As Label
    Friend WithEvents LabelModa As Label
    Friend WithEvents LabelDesviacionTipica As Label
    Friend WithEvents TextBoxMedia As TextBox
    Friend WithEvents TextBoxModa As TextBox
    Friend WithEvents TextBoxMediana As TextBox
    Friend WithEvents TextBoxDesviacionTipica As TextBox
End Class
