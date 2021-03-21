Imports System.Data.Odbc
Public Class Form1
    Dim conn As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim Mydb As String

    Sub koneksi()
        Mydb = "Driver={Mysql ODBC 3.51 Driver};Database=cloudpos;server=localhost;uid=root"
        conn = New OdbcConnection(Mydb)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call koneksi()
        da = New OdbcDataAdapter("select * from tbl_provinsi", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_provinsi")
        DataGridView1.DataSource = (ds.Tables("tbl_provinsi"))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call koneksi()
        da = New OdbcDataAdapter("select * from tbl_kab_kot", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_kab_kot")
        DataGridView1.DataSource = (ds.Tables("tbl_kab_kot"))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call koneksi()
        da = New OdbcDataAdapter("select * from tbl_kelurahan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_kelurahan")
        DataGridView1.DataSource = (ds.Tables("tbl_kelurahan"))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call koneksi()
        da = New OdbcDataAdapter("select * from tbl_kecamatan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_kecamatan")
        DataGridView1.DataSource = (ds.Tables("tbl_kecamatan"))
    End Sub
End Class
