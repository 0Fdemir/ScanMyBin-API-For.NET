<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fileName = New System.Windows.Forms.TextBox()
        Me.resultLink = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRatio = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.txtMD5 = New System.Windows.Forms.TextBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.AvNames = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.result = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Brows"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fileName
        '
        Me.fileName.Location = New System.Drawing.Point(81, 15)
        Me.fileName.Name = "fileName"
        Me.fileName.ReadOnly = True
        Me.fileName.Size = New System.Drawing.Size(244, 22)
        Me.fileName.TabIndex = 2
        Me.fileName.Text = "c:\file.exe"
        '
        'resultLink
        '
        Me.resultLink.Location = New System.Drawing.Point(81, 41)
        Me.resultLink.Name = "resultLink"
        Me.resultLink.ReadOnly = True
        Me.resultLink.Size = New System.Drawing.Size(244, 22)
        Me.resultLink.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Result Link:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(331, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Copy"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "File Path:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "MD5: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Scan Ratio:"
        '
        'lblRatio
        '
        Me.lblRatio.AutoSize = True
        Me.lblRatio.Location = New System.Drawing.Point(77, 93)
        Me.lblRatio.Name = "lblRatio"
        Me.lblRatio.Size = New System.Drawing.Size(25, 13)
        Me.lblRatio.TabIndex = 9
        Me.lblRatio.Text = "n/n"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(331, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Scan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(1, 533)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(51, 13)
        Me.lblProgress.TabIndex = 13
        Me.lblProgress.Text = "Progress"
        '
        'txtMD5
        '
        Me.txtMD5.Location = New System.Drawing.Point(81, 67)
        Me.txtMD5.Name = "txtMD5"
        Me.txtMD5.ReadOnly = True
        Me.txtMD5.Size = New System.Drawing.Size(244, 22)
        Me.txtMD5.TabIndex = 14
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AvNames, Me.result})
        Me.grid.Location = New System.Drawing.Point(2, 121)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(392, 407)
        Me.grid.TabIndex = 15
        '
        'AvNames
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.AvNames.DefaultCellStyle = DataGridViewCellStyle2
        Me.AvNames.FillWeight = 101.5228!
        Me.AvNames.HeaderText = "Antiviruses"
        Me.AvNames.Name = "AvNames"
        Me.AvNames.ReadOnly = True
        '
        'result
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.result.DefaultCellStyle = DataGridViewCellStyle3
        Me.result.FillWeight = 98.47716!
        Me.result.HeaderText = "Results"
        Me.result.Name = "result"
        Me.result.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Date: "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(264, 93)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(67, 13)
        Me.lblDate.TabIndex = 17
        Me.lblDate.Text = "yyyy-mm-dd"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 556)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtMD5)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblRatio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.resultLink)
        Me.Controls.Add(Me.fileName)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScanMyBin for .NET"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents fileName As TextBox
    Friend WithEvents resultLink As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRatio As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents lblProgress As Label
    Friend WithEvents txtMD5 As TextBox
    Friend WithEvents grid As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents AvNames As DataGridViewTextBoxColumn
    Friend WithEvents result As DataGridViewTextBoxColumn
End Class
