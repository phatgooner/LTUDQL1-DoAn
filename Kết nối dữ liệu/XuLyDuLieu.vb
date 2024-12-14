Imports System.Data.OleDb

Module XuLyDuLieu
    Dim ChuoiKetNoi As String = "Provider=SQLOLEDB;Data Source=MSI;Persist Security Info=True;User ID=ntp;Password=123456;Initial Catalog=dbDoAn"

    Public Function DocDuLieu(ByVal sql As String) As DataTable
        Dim KetNoi As OleDbConnection = New OleDbConnection(ChuoiKetNoi)
        Dim TruyVan As OleDbCommand = New OleDbCommand(sql, KetNoi)
        Dim Adapter As OleDbDataAdapter = New OleDbDataAdapter(TruyVan)
        Dim KetQua As DataTable = New DataTable()
        Adapter.Fill(KetQua)
        Return KetQua
    End Function

    Public Sub GhiDuLieu(ByVal TenBang As String, ByVal DuLieu As DataTable)
        Dim KetNoi As OleDbConnection = New OleDbConnection(ChuoiKetNoi)
        Dim TruyVan As OleDbCommand = New OleDbCommand(String.Format("Select * from {0}", TenBang), KetNoi)
        Dim Adapter As OleDbDataAdapter = New OleDbDataAdapter(TruyVan)
        Dim Builder As OleDbCommandBuilder = New OleDbCommandBuilder(Adapter)

        AddHandler Adapter.RowUpdated, AddressOf OnRowUpdated
        Adapter.Update(DuLieu)
    End Sub

    Public Sub OnRowUpdated(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
        If e.StatementType = StatementType.Insert Then
            Dim TruyVan As OleDbCommand = New OleDbCommand("SELECT @@IDENTITY", e.Command.Connection)
            Dim t = TruyVan.ExecuteScalar()
            e.Row(0) = t
        End If
    End Sub
End Module
