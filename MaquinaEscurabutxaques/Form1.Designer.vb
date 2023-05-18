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
        Me.components = New System.ComponentModel.Container()
        Me.BtnDepositar = New System.Windows.Forms.Button()
        Me.TextBoxA = New System.Windows.Forms.TextBox()
        Me.TextBoxC = New System.Windows.Forms.TextBox()
        Me.TextBoxB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DepositTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.BtnRetirar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnDepositar
        '
        Me.BtnDepositar.Location = New System.Drawing.Point(61, 60)
        Me.BtnDepositar.Name = "BtnDepositar"
        Me.BtnDepositar.Size = New System.Drawing.Size(75, 23)
        Me.BtnDepositar.TabIndex = 0
        Me.BtnDepositar.Text = "Depositar"
        Me.BtnDepositar.UseVisualStyleBackColor = True
        '
        'TextBoxA
        '
        Me.TextBoxA.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxA.Location = New System.Drawing.Point(59, 67)
        Me.TextBoxA.Name = "TextBoxA"
        Me.TextBoxA.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxA.TabIndex = 1
        '
        'TextBoxC
        '
        Me.TextBoxC.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxC.Location = New System.Drawing.Point(410, 67)
        Me.TextBoxC.Name = "TextBoxC"
        Me.TextBoxC.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxC.TabIndex = 2
        '
        'TextBoxB
        '
        Me.TextBoxB.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxB.Location = New System.Drawing.Point(232, 67)
        Me.TextBoxB.Name = "TextBoxB"
        Me.TextBoxB.Size = New System.Drawing.Size(100, 35)
        Me.TextBoxB.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(105, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(276, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(451, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "C"
        '
        'DepositTextBox
        '
        Me.DepositTextBox.Location = New System.Drawing.Point(48, 24)
        Me.DepositTextBox.Name = "DepositTextBox"
        Me.DepositTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DepositTextBox.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DepositTextBox)
        Me.Panel1.Controls.Add(Me.BtnDepositar)
        Me.Panel1.Location = New System.Drawing.Point(30, 294)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 8
        Me.Panel1.Visible = False
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.Location = New System.Drawing.Point(332, 302)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(136, 79)
        Me.BtnStart.TabIndex = 9
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(79, 13)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(43, 20)
        Me.LabelTotal.TabIndex = 11
        Me.LabelTotal.Text = "Total"
        '
        'BtnRetirar
        '
        Me.BtnRetirar.Location = New System.Drawing.Point(64, 64)
        Me.BtnRetirar.Name = "BtnRetirar"
        Me.BtnRetirar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRetirar.TabIndex = 12
        Me.BtnRetirar.Text = "Retirar"
        Me.BtnRetirar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TotalTextBox)
        Me.Panel2.Controls.Add(Me.LabelTotal)
        Me.Panel2.Controls.Add(Me.BtnRetirar)
        Me.Panel2.Location = New System.Drawing.Point(578, 294)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 13
        Me.Panel2.Visible = False
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(50, 38)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 7
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.BackColor = System.Drawing.Color.Fuchsia
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(112, 33)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(604, 31)
        Me.Titulo.TabIndex = 14
        Me.Titulo.Text = "Traga Perras Master Plus Maxima Hiper Maquina"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBoxA)
        Me.Panel3.Controls.Add(Me.TextBoxB)
        Me.Panel3.Controls.Add(Me.TextBoxC)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(116, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 141)
        Me.Panel3.TabIndex = 15
        Me.Panel3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Crimson
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 73)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(800, 415)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDepositar As Button
    Friend WithEvents TextBoxA As TextBox
    Friend WithEvents TextBoxC As TextBox
    Friend WithEvents TextBoxB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DepositTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnStart As Button
    Friend WithEvents LabelTotal As Label
    Friend WithEvents BtnRetirar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Titulo As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
End Class
