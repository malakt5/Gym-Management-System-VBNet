Imports System.IO

Public Class Form6
    Sub RemplirComboBoxCoach()
        ComboBoxCOACH.Items.Clear()
        Dim cheminFichier As String = "membres.txt"
        If Not System.IO.File.Exists(cheminFichier) Then
            MsgBox("Le fichier membres.txt est introuvable !")
            Exit Sub
        End If
        Dim lignes() As String = System.IO.File.ReadAllLines(cheminFichier)
        For Each ligne As String In lignes
            Dim t() As String = ligne.Split("#"c)
            If t.Length >= 3 Then
                Dim nom As String = t(0).Trim()
                Dim poste As String = t(2).Trim()
                If poste = "coach" Then
                    ComboBoxCOACH.Items.Add(nom)
                End If
            End If
        Next
    End Sub
    Sub RemplirComboBoxActivites()
        ComboBoxID.Items.Clear()
        Dim chemin As String = "activites.txt"
        If Not System.IO.File.Exists(chemin) Then
            MsgBox("Le fichier activites.txt est introuvable !")
            Exit Sub
        End If
        Dim lignes() As String = System.IO.File.ReadAllLines(chemin)
        For Each ligne As String In lignes
            Dim t() As String = ligne.Split("#"c)
            If t.Length >= 6 Then
                Dim id As String = t(5).Trim()
                ComboBoxID.Items.Add(id)
            End If
        Next
    End Sub
    Private Sub BoutonAjouter_Click(sender As Object, e As EventArgs) Handles ButtonAJOUTER.Click
        If ComboBoxCOACH.SelectedIndex = -1 Then
            MsgBox("Veuillez choisir un coach.")
            Exit Sub
        End If
        If ComboBoxID.SelectedIndex = -1 Then
            MsgBox("Veuillez choisir un ID.")
            Exit Sub
        End If
        If ComboBoxJOUR.SelectedIndex = -1 Then
            MsgBox("Veuillez choisir un jour.")
            Exit Sub
        End If
        If ComboBoxSALLE.SelectedIndex = -1 Then
            MsgBox("Veuillez choisir une salle.")
            Exit Sub
        End If
        Dim coach As String = ComboBoxCOACH.SelectedItem.ToString()
        Dim ID As String = ComboBoxID.SelectedItem.ToString()
        Dim jour As String = ComboBoxJOUR.SelectedItem.ToString()
        Dim dateCours As String = DateTimePicker.Value.ToShortDateString()
        Dim heureDebut As String = DateTimePicker1.Value.ToString("HH:mm")
        Dim salle As String = ComboBoxSALLE.SelectedItem.ToString()
        DataGridView1.Rows.Add(ID, coach, jour, dateCours, heureDebut, salle)
    End Sub
    Private Sub BoutonModifier_Click(sender As Object, e As EventArgs) Handles ButtonMODIFIER.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MsgBox("Veuillez sélectionner la ligne à modifier.")
            Exit Sub
        End If
        If ComboBoxCOACH.SelectedIndex = -1 Or ComboBoxID.SelectedIndex = -1 Or ComboBoxJOUR.SelectedIndex = -1 Or ComboBoxSALLE.SelectedIndex = -1 Then
            MsgBox("Veuillez remplir tous les champs obligatoires.")
            Exit Sub
        End If
        Dim ID As String = ComboBoxID.SelectedItem.ToString()
        Dim coach As String = ComboBoxCOACH.SelectedItem.ToString()
        Dim jour As String = ComboBoxJOUR.SelectedItem.ToString()
        Dim datee As String = DateTimePicker.Value.ToShortDateString()
        Dim Debut As String = DateTimePicker1.Value.ToString("HH:mm")
        Dim S As String = ComboBoxSALLE.SelectedItem.ToString()
        Dim ligne As DataGridViewRow = DataGridView1.CurrentRow
        ligne.Cells(0).Value = ID
        ligne.Cells(1).Value = coach
        ligne.Cells(2).Value = jour
        ligne.Cells(3).Value = datee
        ligne.Cells(4).Value = Debut
        ligne.Cells(5).Value = S
        MsgBox("Ligne modifiée avec succès.")
    End Sub
    Private Sub BoutonSupprimer_Click(sender As Object, e As EventArgs) Handles ButtonSUPPRIMER.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MsgBox("Veuillez sélectionner la ligne à supprimer.")
            Exit Sub
        End If
        Dim D As DialogResult
        D = MsgBox("Voulez-vous vraiment supprimer cette ligne ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")

        If D = DialogResult.Yes Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            MsgBox("Ligne supprimée avec succès.")
        End If

    End Sub

    Private Sub ButtonANNULER_Click(sender As Object, e As EventArgs) Handles ButtonANNULER.Click
        ComboBoxCOACH.SelectedIndex = -1
        ComboBoxID.SelectedIndex = -1
        ComboBoxJOUR.SelectedIndex = -1
        ComboBoxSALLE.SelectedIndex = -1
        DateTimePicker.Value = DateTime.Now
        DateTimePicker1.Value = DateTime.Now
    End Sub
    Private Sub BoutonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMENU.Click
        Dim menu As New Form1()
        menu.Show()
        Me.Close()

    End Sub
    Private Sub ButtonMiseAJour_Click(sender As Object, e As EventArgs) Handles ButtonMISEAJOUR.Click
        Dim fs As New FileStream("C:\Users\Malek\OneDrive\Bureau\Projet Peven\Membres.txt", FileMode.Create, FileAccess.Write)
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

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class