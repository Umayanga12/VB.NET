Public Class Form2
    Public Sub New(value1 As String, value2 As String)
        InitializeComponent()
        TextBox1.Text = value1
        TextBox2.Text = value2
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        Label13.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rate_per As Integer = Integer.Parse(TextBox3.Text)
        Dim hour As Integer = Integer.Parse(TextBox4.Text)
        TextBox5.Text = rate_per * hour
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rate_per As Integer = Integer.Parse(TextBox6.Text)
        Dim hour As Integer = Integer.Parse(TextBox7.Text)
        TextBox8.Text = rate_per * hour
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim base_sal As Integer = Integer.Parse(TextBox2.Text)
        Dim addtion As Integer = Integer.Parse(TextBox5.Text)
        Dim disadd As Integer = Integer.Parse(TextBox8.Text)
        TextBox9.Text = addtion - disadd
        Label13.Text = base_sal + addtion - disadd
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()

        Else
            ' User canceled
            ' Add your code here for the action to be taken when the user cancels.
        End If

    End Sub
End Class