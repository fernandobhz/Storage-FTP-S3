
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Storage.Cloud.Upload(URL:=Me.TextBox2.Text, LocalFile:=Me.TextBox1.Text)
            MsgBox("Upload OK")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Storage.Cloud.Download(URL:=Me.TextBox2.Text, LocalFile:=Me.TextBox1.Text)
            MsgBox("Download OK")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Storage.Cloud.Delete(Me.TextBox2.Text)
            MsgBox("OK")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        IO.File.WriteAllText("c:\ss.txt", String.Join(vbCrLf, Storage.Cloud.List(Me.TextBox3.Text)))
        MsgBox("OK")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        IO.File.WriteAllText("c:\ss.txt", String.Join(vbCrLf, Storage.Cloud.List(Me.TextBox4.Text)))
        MsgBox("OK")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        IO.File.WriteAllText("c:\ss.txt", String.Join(vbCrLf, Storage.Cloud.List(Me.TextBox5.Text)))
        MsgBox("OK")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Storage.Cloud.MakeDir(Me.TextBox6.Text)
        MsgBox("OK")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Storage.Cloud.MakeDir(Me.TextBox7.Text)
        MsgBox("OK")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Storage.Cloud.ForceDir(New Storage.URL(Me.TextBox7.Text))
        MsgBox("OK")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Sync.SimpleSync.UpSync(Me.sync_url.Text, Me.sync_localfolder.Text)
        MsgBox("OK")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Sync.SimpleSync.DownSync(Me.sync_url.Text, Me.sync_localfolder.Text)
        MsgBox("OK")
    End Sub
End Class
