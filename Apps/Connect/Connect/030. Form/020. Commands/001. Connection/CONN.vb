Imports CMCv

Public Class CONN

    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private _SQL As New Commands.CONN.View
    Private _IsProduction As Boolean = True
    Private _IsExtension As Boolean = False
    Public Event Done()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IsProduction = True
    End Sub

    Public Sub New(Optional ByVal IsProduction As Boolean = False, Optional ByVal IsExtension As Boolean = True)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IsProduction = IsProduction
        _IsExtension = IsExtension
    End Sub

#Region "Sub Collections"
    ''' <summary>
    ''' Ambil data dari database untuk mengisi datagrid Catalog
    ''' </summary>
    ''' <param name="ForceRefresh">True/False</param>
    ''' <remarks>True untuk mengambil data tanpa filter</remarks>
    Private Sub GETDATA(Optional ForceRefresh As Boolean = False)
        DblBuffer(DgnConnection)
        _SQL.DisplayData(DgnConnection, SLFStatus, TxtFind, ForceRefresh)
    End Sub
#End Region

    Private Sub CONN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DBE_LocalDB.Open(_IsProduction)

        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)
        DgnConnection.SLF_GETNewColor()

        Call GETDATA(True)
    End Sub

    Private Sub CONN_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If _IsExtension = False Then
            _DBE_LocalDB.Close()
        End If
        RaiseEvent Done()
    End Sub
End Class
