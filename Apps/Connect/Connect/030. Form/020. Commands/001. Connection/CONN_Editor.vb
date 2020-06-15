Public Class CONN_Editor

    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip

    Private Sub CONN_Editor_Load(sender As Object, e As EventArgs) Handles Me.Load
        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuFILE(CMCv.UI.View.MenuStrip.ShowItem.Yes)
    End Sub
End Class
