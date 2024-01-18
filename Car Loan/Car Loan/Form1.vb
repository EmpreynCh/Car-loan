Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Sub findTP()
        Dim AVAN As Integer = 613000
        Dim CAM As Integer = 1696000
        Dim ALT As Integer = 955000
        Dim CITY As Integer = 955000
        Dim JAZZ As Integer = 857000
        Dim SEN As Integer = 1050000
        Dim PAT As Integer = 1270500
        Dim RIO As Integer = 745000
        Dim SOR As Integer = 1690000
        Dim YTP As Integer
        Dim T1 As Decimal = 0.1
        Dim H1 As Decimal = 0.11
        Dim N1 As Decimal = 0.9
        Dim K1 As Decimal = 0.8
        YTP = TextBox2.Text
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedItem = "Avanza" Then
            TextBox4.Text = Format(AVAN * ((1 + T1) ^ YTP), "##,###.00")
            TextBox5.Text = Format((TextBox4.Text) / (YTP * 12), "##,###.00")
        ElseIf ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedItem = "Camry" Then
            TextBox4.Text = Format(CAM * ((1 + T1) ^ YTP), "##,###.00")
            TextBox5.Text = Format((TextBox4.Text) / (YTP * 12), "##,###.00")
        ElseIf ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedItem = "Altis" Then
            TextBox4.Text = Format(ALT * ((1 + T1) ^ YTP), "##,###.00")
            TextBox5.Text = Format((TextBox4.Text) / (YTP * 12), "##,###.00")
        ElseIf ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedItem = "City" Then
            TextBox4.Text = Format(CITY * ((1 + H1) ^ YTP), "##,###.00")
            TextBox5.Text = Format((TextBox4.Text) / (YTP * 12), "##,###.00")
        ElseIf ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedItem = "Jazz" Then
            TextBox4.Text = Format(JAZZ * ((1 + H1) ^ YTP), "##,###.00")
            TextBox5.Text = Format((TextBox4.Text) / (YTP * 12), "##,###.00")
        ElseIf ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedItem = "Sentra" Then
            TextBox4.Text = Format(SEN * ((1 + N1) ^ YTP), "##,###.00")
            TextBox5.Text = Format((TextBox4.Text) / (YTP * 12), "##,###.00")
        ElseIf ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedItem = "Patrol" Then
            TextBox4.Text = Format(PAT * ((1 + N1) ^ YTP), "##,###.00")
            TextBox5.Text = Format((TextBox4.Text) / (YTP * 12), "##,###.00")
        ElseIf ComboBox1.SelectedIndex = 3 And ComboBox2.SelectedItem = "Rio" Then
            TextBox4.Text = Format(RIO * ((1 + K1) ^ YTP), "##,###.00")
            TextBox5.Text = Format((TextBox4.Text) / (YTP * 12), "##,###.00")
        ElseIf ComboBox1.SelectedIndex = 3 And ComboBox2.SelectedItem = "Sorento" Then
            TextBox4.Text = Format(SOR * ((1 + K1) ^ YTP), "##,###.00")
            TextBox5.Text = Format((TextBox4.Text) / (YTP * 12), "##,###.00")
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        PictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Brand\C" & ComboBox1.SelectedIndex & ".png")
        ComboBox2.Items.Clear()
        PictureBox2.Image = Nothing
        ComboBox2.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        If ComboBox1.SelectedIndex = 0 Then
            ComboBox2.Items.Add("Avanza")
            ComboBox2.Items.Add("Camry")
            ComboBox2.Items.Add("Altis")
            TextBox3.Text = 10
        ElseIf ComboBox1.SelectedIndex = 1 Then
            ComboBox2.Items.Add("City")
            ComboBox2.Items.Add("Jazz")
            TextBox3.Text = 11
        ElseIf ComboBox1.SelectedIndex = 2 Then
            ComboBox2.Items.Add("Patrol")
            ComboBox2.Items.Add("Sentra")
            TextBox3.Text = 9
        ElseIf ComboBox1.SelectedIndex = 3 Then
            ComboBox2.Items.Add("Rio")
            ComboBox2.Items.Add("Sorento")
            TextBox3.Text = 8
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            PictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Cars\Toyota\Car" & ComboBox2.SelectedIndex & ".png")
        ElseIf ComboBox1.SelectedIndex = 1 Then
            PictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Cars\Honda\Car" & ComboBox2.SelectedIndex & ".png")
        ElseIf ComboBox1.SelectedIndex = 2 Then
            PictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Cars\Nissan\Car" & ComboBox2.SelectedIndex & ".png")
        ElseIf ComboBox1.SelectedIndex = 3 Then
            PictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Cars\Kia\Car" & ComboBox2.SelectedIndex & ".png")
        End If
        If ComboBox2.SelectedItem = "Avanza" Then
            TextBox1.Text = "613,000.00"
        ElseIf ComboBox2.SelectedItem = "Camry" Then
            TextBox1.Text = "1,696,000.00"
        ElseIf ComboBox2.SelectedItem = "Altis" Then
            TextBox1.Text = "955,000.00"
        ElseIf ComboBox2.SelectedItem = "City" Then
            TextBox1.Text = "771,000.00"
        ElseIf ComboBox2.SelectedItem = "Jazz" Then
            TextBox1.Text = "857,000.00"
        ElseIf ComboBox2.SelectedItem = "Sentra" Then
            TextBox1.Text = "1,050,000.00"
        ElseIf ComboBox2.SelectedItem = "Patrol" Then
            TextBox1.Text = "1,270,500.00"
        ElseIf ComboBox2.SelectedItem = "Rio" Then
            TextBox1.Text = "745,000.00"
        ElseIf ComboBox2.SelectedItem = "Sorento" Then
            TextBox1.Text = "1,690,000.00"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        findTP()
        MsgBox("Thank you for purchasing " + ComboBox1.SelectedItem + "!")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub
End Class
