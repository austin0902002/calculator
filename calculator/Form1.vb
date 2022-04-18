Public Class Form1
    Dim num1, num2 As Double
    Dim count As String

    Private Sub BTN_num1_Click(sender As Object, e As EventArgs) Handles BTN_num1.Click
        TB_show.Text &= "1"
    End Sub

    Private Sub BTN_num2_Click(sender As Object, e As EventArgs) Handles BTN_num2.Click
        TB_show.Text &= "2"
    End Sub

    Private Sub BTN_num3_Click(sender As Object, e As EventArgs) Handles BTN_num3.Click
        TB_show.Text &= "3"
    End Sub

    Private Sub BTN_num4_Click(sender As Object, e As EventArgs) Handles BTN_num4.Click
        TB_show.Text &= "4"
    End Sub

    Private Sub BTN_num5_Click(sender As Object, e As EventArgs) Handles BTN_num5.Click
        TB_show.Text &= "5"
    End Sub

    Private Sub BTN_num6_Click(sender As Object, e As EventArgs) Handles BTN_num6.Click
        TB_show.Text &= "6"
    End Sub

    Private Sub BTN_num7_Click(sender As Object, e As EventArgs) Handles BTN_num7.Click
        TB_show.Text &= "7"
    End Sub

    Private Sub BTN_num8_Click(sender As Object, e As EventArgs) Handles BTN_num8.Click
        TB_show.Text &= "8"
    End Sub

    Private Sub BTN_num9_Click(sender As Object, e As EventArgs) Handles BTN_num9.Click
        TB_show.Text &= "9"
    End Sub

    Private Sub BTN_num0_Click(sender As Object, e As EventArgs) Handles BTN_num0.Click
        If TB_show.Text = "" Then
            TB_show.Text = "0."
        Else
            TB_show.Text &= "0"
        End If
    End Sub

    Private Sub BTN_dot_Click(sender As Object, e As EventArgs) Handles BTN_dot.Click
        If TB_show.Text.Contains(".") Then
            Return
        Else
            TB_show.Text &= "."
        End If
    End Sub

    '清除
    Private Sub BTN_clean_Click(sender As Object, e As EventArgs) Handles BTN_clean.Click
        TB_show.Text = ""
    End Sub

    '取消
    Private Sub BTN_cancel_Click(sender As Object, e As EventArgs) Handles BTN_cancel.Click
        num1 = 0
        num2 = 0
        count = ""
        TB_show.Text = ""
        LB_num1.Text = ""
    End Sub

    '加
    Private Sub BTN_plus_Click(sender As Object, e As EventArgs) Handles BTN_plus.Click
        If CHK_Textbox(Me.TB_show) Then
            If LB_num1.Text.Contains("+") Then '直接按+多次
                num2 = Convert.ToDouble(TB_show.Text) '輸入的第二數字
                GoMath(num1, num2, "+")

            ElseIf LB_num1.Text.Contains("=") Then '前一次按=
                num1 = LB_num1.Text.Split("=")(1) '前次結果為第一數字
                num2 = Convert.ToDouble(TB_show.Text) '輸入的第二數字
                GoMath(num1, num2, "+")

            Else  '第一次按+
                num1 = Convert.ToDouble(TB_show.Text)
                count = BTN_plus.Text
                LB_num1.Text = num1.ToString & count
                TB_show.Text = ""
            End If
        End If
    End Sub

    '減
    Private Sub BTN_minus_Click(sender As Object, e As EventArgs) Handles BTN_minus.Click
        If CHK_Textbox(Me.TB_show) Then
            If LB_num1.Text.Contains("-") Then '直接按-多次
                num2 = Convert.ToDouble(TB_show.Text) '輸入的第二數字
                GoMath(num1, num2, "-")

            ElseIf LB_num1.Text.Contains("=") Then '前一次按=
                num1 = LB_num1.Text.Split("=")(1) '前次結果為第一數字
                num2 = Convert.ToDouble(TB_show.Text) '輸入的第二數字
                GoMath(num1, num2, "-")

            Else  '第一次按-
                num1 = Convert.ToDouble(TB_show.Text)
                count = BTN_minus.Text
                LB_num1.Text = num1.ToString & count
                TB_show.Text = ""
            End If
        End If
    End Sub

    '乘
    Private Sub BTN_multiply_Click(sender As Object, e As EventArgs) Handles BTN_multiply.Click
        If CHK_Textbox(Me.TB_show) Then
            If LB_num1.Text.Contains("*") Then '直接按*多次
                num2 = Convert.ToDouble(TB_show.Text) '輸入的第二數字
                GoMath(num1, num2, "*")

            ElseIf LB_num1.Text.Contains("=") Then '前一次按=
                num1 = LB_num1.Text.Split("=")(1) '前次結果為第一數字
                num2 = Convert.ToDouble(TB_show.Text) '輸入的第二數字
                GoMath(num1, num2, "*")

            Else  '第一次按-
                num1 = Convert.ToDouble(TB_show.Text)
                count = BTN_multiply.Text
                LB_num1.Text = num1.ToString & count
                TB_show.Text = ""
            End If
        End If
    End Sub

    '除
    Private Sub BTN_divide_Click(sender As Object, e As EventArgs) Handles BTN_divide.Click
        'If TB_show.Text.Contains(".") AndAlso TB_show.Text.Split(".")(1).ToString = "" Then '檢查輸入小數點
        '    count = ""
        '    MsgBox("請輸入有效數字")
        '    Exit Sub
        'ElseIf TB_show.Text = "" Then
        '    MsgBox("請輸入有效數字")
        '    count = ""
        '    Exit Sub
        'End If

        If CHK_Textbox(Me.TB_show) Then
            If LB_num1.Text.Contains("/") Then '直接按*多次
                num2 = Convert.ToDouble(TB_show.Text) '輸入的第二數字
                GoMath(num1, num2, "/")

            ElseIf LB_num1.Text.Contains("=") Then '前一次按=
                num1 = LB_num1.Text.Split("=")(1) '前次結果為第一數字
                num2 = Convert.ToDouble(TB_show.Text) '輸入的第二數字
                GoMath(num1, num2, "/")

            Else  '第一次按-
                num1 = Convert.ToDouble(TB_show.Text)
                count = BTN_divide.Text
                LB_num1.Text = num1.ToString & count
                TB_show.Text = ""
            End If
        End If
    End Sub

    '等於
    Private Sub BTN_equal_Click(sender As Object, e As EventArgs) Handles BTN_equal.Click
        If LB_num1.Text <> "" AndAlso TB_show.Text <> "" Then
            If Not LB_num1.Text.Contains("=") Then  '尚未按過=
                num2 = Convert.ToDouble(TB_show.Text) '輸入放入第二數子
                GoMath(num1, num2, count) '計算結果顯示
            End If
        End If
    End Sub

    '檢查輸入值
    Private Function CHK_Textbox(TB As TextBox) As Boolean
        If TB.Text.Contains(".") AndAlso TB.Text.Split(".")(1).ToString = "" Then
            count = ""
            MsgBox("請輸入有效數字")
            Return False
        ElseIf TB.Text = "" Then
            MsgBox("請輸入有效數字")
            count = ""
            Return False
        End If

        Return True
    End Function

    '計算
    Private Sub GoMath(val1 As Double, val2 As Double, cnt As String)
        Select Case cnt
            Case "+"
                LB_num1.Text = val1 & "+" & val2 & "=" & val1 + val2
                TB_show.Text = ""
                num1 = val1 + val2
            Case "-"
                LB_num1.Text = val1 & "-" & val2 & "=" & val1 - val2
                TB_show.Text = ""
                num1 = val1 - val2
            Case "*"
                LB_num1.Text = val1 & "*" & val2 & "=" & val1 * val2
                TB_show.Text = ""
                num1 = val1 * val2
            Case "/"
                LB_num1.Text = val1 & "/" & val2 & "=" & val1 / val2
                TB_show.Text = ""
                num1 = val1 / val2
        End Select
    End Sub
End Class
