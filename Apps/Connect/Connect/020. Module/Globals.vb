Imports CMCv
Imports System.Reflection

Module Globals
    Public _DBE_MSSQL2008 As New Database.Engine.MSSQL2008
    Public _DBE_LocalDB As New Database.Engine.LocalDB
    Public _DB_Properties(1) As Database.Properties.Fields

    Public _DBR_LOCALDB(1) As Database.Adapter.LocalDB.Display.Request
    Public _DBP_LOCALDB As New Database.Adapter.LocalDB.Execute

    Public _SECEncrypt As New Security.Encrypt
    Public _APPVer As String = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build

    Public WithEvents MSG As New frmDialogBox
    Public WithEvents ERC As New frmErrorReporting
    Public ErrorCatcher As New Catcher.Error.Fields

#Region "Custom Message Box"
    ''' <summary>
    ''' CMCv Message Box
    ''' </summary>
    ''' <param name="Message">Masukkan pesan anda di sini</param>
    ''' <param name="Title">Judul form</param>
    ''' <param name="MessageIcon">Jenis Icon</param>
    ''' <param name="ButtonType">Jenis Tombol</param>
    ''' <returns>DialogResult</returns>
    ''' <remarks></remarks>
    Public Function Decision(ByVal Message As String, ByVal Title As String, ByVal MessageIcon As CMCv.frmDialogBox.MessageIcon, ByVal ButtonType As CMCv.frmDialogBox.MessageTypes) As System.Windows.Forms.DialogResult
        MSG = New CMCv.frmDialogBox(Message, Title, MessageIcon, ButtonType)
        Return MSG.ShowDialog()
        MSG.Dispose()
    End Function
#End Region

    Public Sub DblBuffer(ByVal GridView As DataGridView)
        Try
            Dim systemType As Type = GridView.GetType()
            Dim propertyInfo As PropertyInfo = systemType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
            propertyInfo.SetValue(GridView, True, Nothing)
        Catch ex As Exception
            PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub

#Region "Get App Version"

    ''' <summary>
    ''' Fungsi untuk mendapatkan versi app
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function GETAPPVERSION() As String
        Try
            _APPVer = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build
            Return _APPVer
        Catch ex As Exception
            PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult, ex.StackTrace, "0.0.0", False, True, True)
            PUSHERRORDATASHOW()
            _APPVer = "0.0.0"
            Return _APPVer
        End Try
    End Function
#End Region


#Region "Error Log"

    ''' <summary>
    ''' Metode untuk menyimpan log error
    ''' </summary>
    ''' <param name="ErrorType">Tipe Error</param>
    ''' <param name="ErrorMessage">Pesan Error</param>
    ''' <param name="ErrorNumber">Nomor Error</param>
    ''' <param name="InternalStackTrace">Internal Stack Trace</param>
    ''' <param name="AppVersion">Versi Aplikasi</param>
    ''' <param name="EnableErrorReporting">True/False</param>
    ''' <param name="SaveError">True/False</param>
    ''' <param name="ResumeNext">Lanjutkan saat terjadi kesalahan</param>
    ''' <remarks></remarks>
    Public Sub PUSHERRORDATA(ByVal ErrorType As Catcher.Error.Fields.TypeOfFaulties, ByVal ErrorMessage As String, ByVal ErrorNumber As Integer, ByVal InternalStackTrace As String, ByVal AppVersion As String, Optional ByVal EnableErrorReporting As Boolean = True, Optional ByVal SaveError As Boolean = True, Optional ByVal ResumeNext As Boolean = True)
        With ErrorCatcher
            .Type = ErrorType
            .Message = ErrorMessage
            .Number = ErrorNumber
            .InternalStackTrace = InternalStackTrace
            .AppVersion = AppVersion
            .EnableErrorReporting = EnableErrorReporting
            .SaveError = SaveError
            .ResumeNext = ResumeNext
        End With
    End Sub

    ''' <summary>
    ''' Metode untuk menampilkan log error
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PUSHERRORDATASHOW()
        ERC = New CMCv.frmErrorReporting(ErrorCatcher, _DBE_LocalDB)
        ERC.ShowDialog()
        If ERC.ResumeNext = False Then
            End
        End If
    End Sub
#End Region
End Module
