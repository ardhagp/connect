<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CONN_Editor
    Inherits CMCv.Std_Fo

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CONN_Editor))
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.TbctlBasic = New CMCv.tbctl(Me.components)
        Me.tp1_ = New System.Windows.Forms.TabPage()
        Me.Txt1 = New CMCv.txt(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.TbctlBasic.SuspendLayout()
        Me.tp1_.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Controls.Add(Me.BtnSave)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 318)
        Me.PnlBottomButton.Size = New System.Drawing.Size(362, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(362, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.TbctlBasic)
        Me.SLFPanel.Size = New System.Drawing.Size(362, 368)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TbctlBasic, 0)
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 2
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(144, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Red
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderSize = 2
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(250, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'TbctlBasic
        '
        Me.TbctlBasic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbctlBasic.Controls.Add(Me.tp1_)
        Me.TbctlBasic.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TbctlBasic.Location = New System.Drawing.Point(12, 6)
        Me.TbctlBasic.Name = "TbctlBasic"
        Me.TbctlBasic.SelectedIndex = 0
        Me.TbctlBasic.Size = New System.Drawing.Size(338, 306)
        Me.TbctlBasic.TabIndex = 997
        '
        'tp1_
        '
        Me.tp1_.Controls.Add(Me.Txt1)
        Me.tp1_.Location = New System.Drawing.Point(4, 30)
        Me.tp1_.Name = "tp1_"
        Me.tp1_.Padding = New System.Windows.Forms.Padding(3)
        Me.tp1_.Size = New System.Drawing.Size(330, 272)
        Me.tp1_.TabIndex = 0
        Me.tp1_.Text = "CONFIG"
        Me.tp1_.UseVisualStyleBackColor = True
        '
        'Txt1
        '
        Me.Txt1.BackColor = System.Drawing.Color.White
        Me.Txt1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt1.Location = New System.Drawing.Point(118, 6)
        Me.Txt1.MaxLength = 255
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(206, 29)
        Me.Txt1.SLFAutoTrim = False
        Me.Txt1.SLFHarusDiisi = False
        Me.Txt1.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.Txt1.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.Txt1.SLFHightlightSaatFokus = False
        Me.Txt1.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.Txt1.SLFIsBlank = True
        Me.Txt1.SLFIsSearchBox = False
        Me.Txt1.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.Txt1.SLFPilihSemuaSaatFokus = False
        Me.Txt1.SLFPwdLengthMin = 8
        Me.Txt1.SLFPwdStrengthCalculate = False
        Me.Txt1.SLFPwdStrengthScore = 0
        Me.Txt1.SLFPwdStrengthText = Nothing
        Me.Txt1.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.Txt1.SLFSearchBoxText = "Type then press Enter"
        Me.Txt1.SLFSQLText = ""
        Me.Txt1.SLFTanpaSpasi = False
        Me.Txt1.SLFValidasiField = Nothing
        Me.Txt1.TabIndex = 997
        Me.Txt1.Tag = "txt"
        '
        'CONN_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(362, 444)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(378, 483)
        Me.Name = "CONN_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.TbctlBasic.ResumeLayout(False)
        Me.tp1_.ResumeLayout(False)
        Me.tp1_.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents TbctlBasic As CMCv.tbctl
    Friend WithEvents tp1_ As TabPage
    Friend WithEvents Txt1 As CMCv.txt
End Class
