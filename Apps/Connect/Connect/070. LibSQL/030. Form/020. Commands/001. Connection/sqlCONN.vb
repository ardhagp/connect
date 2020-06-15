Namespace Commands.CONN
    Public Class View
        Public Sub DisplayData(ByVal Datagrid As CMCv.dgn, ByVal StatusBar As CMCv.stt, ByVal Find As CMCv.txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.SLFSQLText = String.Empty) Or (ForceRefresh = True) Then
                _DBR_LOCALDB(0).Query = "select lt.ID, lt.CONNECTIONNAME, lt.SERVERADDRESS, lt.SERVERPORT, lt.DEFAULTCONNECTION from list lt;"
            Else
                _DBR_LOCALDB(0).Query = String.Format("select lt.ID, lt.CONNECTIONNAME, lt.SERVERADDRESS, lt.SERVERPORT, lt.DEFAULTCONNECTION from list lt where lt.CONNECTIONNAME like '%{0}%';", Find.SLFSQLText)
            End If
            _DBR_LOCALDB(0).DataGrid = Datagrid
            _DBR_LOCALDB(0).StatusBar = StatusBar
            _DBE_LocalDB.GETDATATABLE(_DBR_LOCALDB(0), "TDBList")
        End Sub
    End Class

    Public Class Editor

    End Class
End Namespace


