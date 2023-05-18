Public Class Form2KedyDown

    Private Sub BtnCargarLista_Click(sender As Object, e As EventArgs) Handles BtnCargarLista.Click
        Dim r, i, k As Integer
        Dim repe As Boolean

        Do
            repe = False

            r = CInt((100 * Rnd()) + 1)

            For i = 0 To ListBox1.Items.Count - 1

                k = CInt(ListBox1.Items(i))
                If k = r Then
                    repe = True
                    Exit For
                End If
            Next

            If repe = False Then
                ListBox1.Items.Add(r)
            End If

        Loop While (ListBox1.Items.Count <= 100)
    End Sub
End Class