Public Class Form1

    ' تأكد أن هذه المتغيرات معرفة كـ Button
    Dim FirstClicked As Button = Nothing
    Dim SecondClicked As Button = Nothing

    Private Sub AnyButton_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click

        Dim btn As Button = CType(sender, Button)

        ' منع الضغط على نفس الزر مرتين أو الضغط أثناء عمل المؤقت
        If Timer1.Enabled OrElse btn Is FirstClicked Then Return

        ' إظهار الصورة وإخفاء الرقم
        btn.Image = ImageList1.Images(CInt(btn.Tag))
        btn.Text = ""

        If FirstClicked Is Nothing Then
            FirstClicked = btn
            Return
        End If

        SecondClicked = btn

        ' مقارنة الـ Tag لمعرفة هل الصور متطابقة
        If FirstClicked.Tag.ToString() = SecondClicked.Tag.ToString() Then
            ' في حال التطابق: نترك الصور ظاهرة ونفرغ المتغيرات للاستمرار
            FirstClicked = Nothing
            SecondClicked = Nothing
        Else
            ' في حال عدم التطابق: نشغل المؤقت لإخفائهم بعد ثانية
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        ' إعادة الأرقام وإخفاء الصور
        FirstClicked.Text = (CInt(FirstClicked.Tag) + 1).ToString()
        SecondClicked.Text = (CInt(SecondClicked.Tag) + 1).ToString()

        FirstClicked.Image = Nothing
        SecondClicked.Image = Nothing

        ' تفريغ المتغيرات لجولة جديدة
        FirstClicked = Nothing
        SecondClicked = Nothing
    End Sub

End Class