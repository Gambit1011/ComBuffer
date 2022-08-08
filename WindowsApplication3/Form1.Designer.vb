<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bit_text = New System.Windows.Forms.TextBox()
        Me.Dbit_text = New System.Windows.Forms.TextBox()
        Me.Par_text = New System.Windows.Forms.TextBox()
        Me.Stobit_text = New System.Windows.Forms.TextBox()
        Me.Flcon_text = New System.Windows.Forms.TextBox()
        Me.Psetsave_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bits Per second:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data Bits:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Parity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stop Bit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Flow Control"
        '
        'Bit_text
        '
        Me.Bit_text.Location = New System.Drawing.Point(110, 52)
        Me.Bit_text.Name = "Bit_text"
        Me.Bit_text.Size = New System.Drawing.Size(100, 20)
        Me.Bit_text.TabIndex = 5
        '
        'Dbit_text
        '
        Me.Dbit_text.Location = New System.Drawing.Point(110, 83)
        Me.Dbit_text.Name = "Dbit_text"
        Me.Dbit_text.Size = New System.Drawing.Size(100, 20)
        Me.Dbit_text.TabIndex = 6
        '
        'Par_text
        '
        Me.Par_text.Location = New System.Drawing.Point(110, 113)
        Me.Par_text.Name = "Par_text"
        Me.Par_text.Size = New System.Drawing.Size(100, 20)
        Me.Par_text.TabIndex = 7
        '
        'Stobit_text
        '
        Me.Stobit_text.Location = New System.Drawing.Point(110, 143)
        Me.Stobit_text.Name = "Stobit_text"
        Me.Stobit_text.Size = New System.Drawing.Size(100, 20)
        Me.Stobit_text.TabIndex = 8
        '
        'Flcon_text
        '
        Me.Flcon_text.Location = New System.Drawing.Point(110, 173)
        Me.Flcon_text.Name = "Flcon_text"
        Me.Flcon_text.Size = New System.Drawing.Size(100, 20)
        Me.Flcon_text.TabIndex = 9
        '
        'Psetsave_btn
        '
        Me.Psetsave_btn.Location = New System.Drawing.Point(52, 211)
        Me.Psetsave_btn.Name = "Psetsave_btn"
        Me.Psetsave_btn.Size = New System.Drawing.Size(75, 23)
        Me.Psetsave_btn.TabIndex = 10
        Me.Psetsave_btn.Text = "Save"
        Me.Psetsave_btn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Com"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(110, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Psetsave_btn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Flcon_text)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Stobit_text)
        Me.GroupBox1.Controls.Add(Me.Bit_text)
        Me.GroupBox1.Controls.Add(Me.Par_text)
        Me.GroupBox1.Controls.Add(Me.Dbit_text)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 250)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 268)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Port Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Bit_text As System.Windows.Forms.TextBox
    Friend WithEvents Dbit_text As System.Windows.Forms.TextBox
    Friend WithEvents Par_text As System.Windows.Forms.TextBox
    Friend WithEvents Stobit_text As System.Windows.Forms.TextBox
    Friend WithEvents Flcon_text As System.Windows.Forms.TextBox
    Friend WithEvents Psetsave_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
