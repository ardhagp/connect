<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONN
    Inherits CMCv.Std_Fi_Fo

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CONN))
        Me.DgnConnection = New CMCv.dgn(Me.components)
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.connectionname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serveraddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serverport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defaultconnection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.spring = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 2
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        '
        'SLFLogo
        '
        Me.SLFLogo.BackColor = System.Drawing.Color.Transparent
        Me.SLFLogo.Image = Global.Connect.My.Resources.Resources.CONN_
        '
        'SLFSubNamaForm
        '
        Me.SLFSubNamaForm.Size = New System.Drawing.Size(207, 15)
        Me.SLFSubNamaForm.Text = "Configure Ingrid database connection"
        '
        'SLFNamaForm
        '
        Me.SLFNamaForm.Size = New System.Drawing.Size(245, 32)
        Me.SLFNamaForm.Text = "Connection Settings"
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.DgnConnection)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnConnection, 0)
        '
        'DgnConnection
        '
        Me.DgnConnection.AllowUserToAddRows = False
        Me.DgnConnection.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.DgnConnection.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnConnection.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnConnection.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnConnection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnConnection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnConnection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnConnection.ColumnHeadersHeight = 43
        Me.DgnConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnConnection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.connectionname, Me.serveraddress, Me.serverport, Me.defaultconnection, Me.spring})
        Me.DgnConnection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnConnection.EnableHeadersVisualStyles = False
        Me.DgnConnection.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnConnection.Location = New System.Drawing.Point(0, 46)
        Me.DgnConnection.Name = "DgnConnection"
        Me.DgnConnection.ReadOnly = True
        Me.DgnConnection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnConnection.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnConnection.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnConnection.Size = New System.Drawing.Size(784, 389)
        Me.DgnConnection.SLFGroupFirstRows = False
        Me.DgnConnection.SLFGunakanNomorBaris = True
        Me.DgnConnection.StandardTab = True
        Me.DgnConnection.TabIndex = 997
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.id.DataPropertyName = "ID"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 44
        '
        'connectionname
        '
        Me.connectionname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.connectionname.DataPropertyName = "CONNECTIONNAME"
        Me.connectionname.HeaderText = "CONNECTION NAME"
        Me.connectionname.Name = "connectionname"
        Me.connectionname.ReadOnly = True
        Me.connectionname.Width = 132
        '
        'serveraddress
        '
        Me.serveraddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.serveraddress.DataPropertyName = "SERVERADDRESS"
        Me.serveraddress.HeaderText = "SERVER ADDRESS"
        Me.serveraddress.Name = "serveraddress"
        Me.serveraddress.ReadOnly = True
        Me.serveraddress.Width = 125
        '
        'serverport
        '
        Me.serverport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.serverport.DataPropertyName = "SERVERPORT"
        Me.serverport.HeaderText = "PORT"
        Me.serverport.Name = "serverport"
        Me.serverport.ReadOnly = True
        Me.serverport.Width = 61
        '
        'defaultconnection
        '
        Me.defaultconnection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.defaultconnection.DataPropertyName = "DEFAULTCONNECTION"
        Me.defaultconnection.HeaderText = "DEFAULT"
        Me.defaultconnection.Name = "defaultconnection"
        Me.defaultconnection.ReadOnly = True
        Me.defaultconnection.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.defaultconnection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.defaultconnection.Width = 79
        '
        'spring
        '
        Me.spring.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.spring.HeaderText = ""
        Me.spring.Name = "spring"
        Me.spring.ReadOnly = True
        '
        'CONN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "CONN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnConnection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgnConnection As CMCv.dgn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents connectionname As DataGridViewTextBoxColumn
    Friend WithEvents serveraddress As DataGridViewTextBoxColumn
    Friend WithEvents serverport As DataGridViewTextBoxColumn
    Friend WithEvents defaultconnection As DataGridViewCheckBoxColumn
    Friend WithEvents spring As DataGridViewTextBoxColumn
End Class
