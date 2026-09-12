Imports System.IO
Public Class Form7
    Private Sub TextBoxCIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCIN.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
        If Char.IsDigit(e.KeyChar) AndAlso TextBoxCIN.Text.Length >= 8 Then
            e.Handled = True
        End If
    End Sub

    Function CINExiste(cinRecherche As String) As Boolean
        Dim cheminFichier As String = "abonnes.txt"
        Dim existe As Boolean = False
        If File.Exists(cheminFichier) Then
            Dim lignes() As String = File.ReadAllLines(cheminFichier)
            For Each ligne As String In lignes
                Dim champs() As String = ligne.Split("#"c)
                If champs.Length >= 5 Then
                    If champs(4).Trim = cinRecherche Then
                        existe = True
                    End If
                End If
            Next
        End If
        Return existe
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) _
    Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = -1 Then Exit Sub
        Select Case ComboBox1.Text
            Case "Mensuel"
                DateTimePicker2.Value = DateTimePicker1.Value.AddMonths(1)
            Case "Trimestriel"
                DateTimePicker2.Value = DateTimePicker1.Value.AddMonths(3)
            Case "Semestriel"
                DateTimePicker2.Value = DateTimePicker1.Value.AddMonths(6)
            Case "Annuel"
                DateTimePicker2.Value = DateTimePicker1.Value.AddMonths(12)
        End Select
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) _
    Handles DateTimePicker1.ValueChanged
        If ComboBox1.SelectedIndex <> -1 Then
            ComboBox1_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub




    Private Sub ButtonMiseAJour_Click(sender As Object, e As EventArgs) Handles ButtonMISEAJOUR.Click
        Dim fs As New FileStream("Abonnements et paiements.txt", FileMode.Create, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                sw.WriteLine(row.Cells(0).Value & "#" & row.Cells(1).Value & "#" & row.Cells(2).Value & "#" & row.Cells(3).Value & "#" & row.Cells(4).Value & "#" & row.Cells(5).Value & "#" & row.Cells(6).Value & "#" & row.Cells(7).Value)
            End If
        Next
        sw.Close()
        fs.Close()
        MsgBox("Mise à jour avec succès", vbInformation, "Succès d'opération")
    End Sub
    Private Sub ButtonAjouter_Click(sender As Object, e As EventArgs) Handles ButtonAJOUTER.Click
        If TextBoxCIN.Text.Trim = "" Then
            MsgBox("Veuillez saisir le CIN.")
            Exit Sub
        End If
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Veuillez choisir le type d'abonnement.")
            Exit Sub
        End If

        If ComboBox2.SelectedIndex = -1 Then
            MsgBox("Veuillez choisir le statut de paiement.")
            Exit Sub
        End If
        DataGridView1.Rows.Add(TextBoxCIN.Text.Trim, ComboBox1.Text, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString, ComboBox2.Text)
        TextBoxCIN.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub
    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles ButtonMODIFIER.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Veuillez sélectionner une ligne à modifier.")
            Exit Sub
        End If
        Dim ligne As DataGridViewRow = DataGridView1.SelectedRows(0)
        If TextBoxCIN.Text.Trim = "" Then
            MsgBox("Veuillez saisir le CIN.")
            Exit Sub
        End If
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Veuillez choisir le type d'abonnement.")
            Exit Sub
        End If
        If ComboBox2.SelectedIndex = -1 Then
            MsgBox("Veuillez choisir le statut de paiement.")
            Exit Sub
        End If
        ligne.Cells("CIN").Value = TextBoxCIN.Text.Trim
        ligne.Cells("type").Value = ComboBox1.Text
        ligne.Cells("debut").Value = DateTimePicker1.Value.ToShortDateString
        ligne.Cells("fin").Value = DateTimePicker2.Value.ToShortDateString
        ligne.Cells("statut").Value = ComboBox2.Text
        MsgBox("Modification effectuée avec succès.")
    End Sub
    Private Sub ButtonSupprimer_Click(sender As Object, e As EventArgs) Handles ButtonSUPPRIMER.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Veuillez sélectionner une ligne à supprimer.")
            Exit Sub
        End If
        Dim ligne As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim confirmation As DialogResult
        confirmation = MsgBox("Voulez-vous vraiment supprimer cet abonnement ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If confirmation = DialogResult.Yes Then
            DataGridView1.Rows.Remove(ligne)
            MsgBox("Abonnement supprimé avec succès.")
        End If
    End Sub
    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonANNULER.Click
        TextBoxCIN.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim rep As MsgBoxResult
        rep = MsgBox("Voulez-vous mettre à jour les informations?", vbYesNo, "Attention")
        If rep = vbYes Then
            Dim fs As New FileStream("Abonnements et paiements.txt", FileMode.Create, FileAccess.Write)
            Dim sw As New StreamWriter(fs)
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    sw.WriteLine(row.Cells(0).Value & "#" & row.Cells(1).Value & "#" & row.Cells(2).Value & "#" & row.Cells(3).Value & "#" & row.Cells(4).Value)
                End If
            Next
            sw.Close()
            fs.Close()
            MsgBox("Mise à jour avec succès", vbInformation, "Succès d'opération")
        End If
        Me.Hide()
        Form1.Show()
    End Sub

End Class