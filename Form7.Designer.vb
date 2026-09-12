<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TextBoxCIN = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        CIN = New DataGridViewTextBoxColumn()
        type = New DataGridViewTextBoxColumn()
        debut = New DataGridViewTextBoxColumn()
        fin = New DataGridViewTextBoxColumn()
        statut = New DataGridViewTextBoxColumn()
        ButtonAJOUTER = New Button()
        ButtonANNULER = New Button()
        ButtonSUPPRIMER = New Button()
        ButtonMODIFIER = New Button()
        ButtonMISEAJOUR = New Button()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(383, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(863, 50)
        Label1.TabIndex = 1
        Label1.Text = "VOS ABONNEMENTS ET PAIEMENTS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label4.Location = New Point(82, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 25)
        Label4.TabIndex = 4
        Label4.Text = "N° de CIN:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label6.Location = New Point(82, 277)
        Label6.Name = "Label6"
        Label6.Size = New Size(195, 25)
        Label6.TabIndex = 6
        Label6.Text = "Type d'abonnement:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label7.Location = New Point(82, 384)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 25)
        Label7.TabIndex = 7
        Label7.Text = "Date début:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label8.Location = New Point(82, 484)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 25)
        Label8.TabIndex = 8
        Label8.Text = "Date fin:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label9.Location = New Point(82, 602)
        Label9.Name = "Label9"
        Label9.Size = New Size(189, 25)
        Label9.TabIndex = 9
        Label9.Text = "Statut de paiement:"
        ' 
        ' TextBoxCIN
        ' 
        TextBoxCIN.Location = New Point(279, 166)
        TextBoxCIN.Name = "TextBoxCIN"
        TextBoxCIN.Size = New Size(300, 31)
        TextBoxCIN.TabIndex = 12
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Mensuel", "Trimestriel", "Semestriel", "Annuel"})
        ComboBox1.Location = New Point(279, 277)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(300, 33)
        ComboBox1.TabIndex = 14
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Payé", "Non payé", "En retard de paiement"})
        ComboBox2.Location = New Point(279, 599)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(300, 33)
        ComboBox2.TabIndex = 15
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(279, 384)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 16
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(279, 478)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(300, 31)
        DateTimePicker2.TabIndex = 17
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CIN, type, debut, fin, statut})
        DataGridView1.Location = New Point(595, 107)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(813, 525)
        DataGridView1.TabIndex = 18
        ' 
        ' CIN
        ' 
        CIN.HeaderText = "N° de CIN"
        CIN.MinimumWidth = 8
        CIN.Name = "CIN"
        CIN.Width = 150
        ' 
        ' type
        ' 
        type.HeaderText = "Type d'abonnement"
        type.MinimumWidth = 8
        type.Name = "type"
        type.Width = 150
        ' 
        ' debut
        ' 
        debut.HeaderText = "Date début"
        debut.MinimumWidth = 8
        debut.Name = "debut"
        debut.Width = 150
        ' 
        ' fin
        ' 
        fin.HeaderText = "Date fin"
        fin.MinimumWidth = 8
        fin.Name = "fin"
        fin.Width = 150
        ' 
        ' statut
        ' 
        statut.HeaderText = "Statut de paiement"
        statut.MinimumWidth = 8
        statut.Name = "statut"
        statut.Width = 150
        ' 
        ' ButtonAJOUTER
        ' 
        ButtonAJOUTER.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ButtonAJOUTER.Location = New Point(159, 691)
        ButtonAJOUTER.Name = "ButtonAJOUTER"
        ButtonAJOUTER.Size = New Size(112, 34)
        ButtonAJOUTER.TabIndex = 19
        ButtonAJOUTER.Text = "Ajouter"
        ButtonAJOUTER.UseVisualStyleBackColor = True
        ' 
        ' ButtonANNULER
        ' 
        ButtonANNULER.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ButtonANNULER.Location = New Point(1248, 691)
        ButtonANNULER.Name = "ButtonANNULER"
        ButtonANNULER.Size = New Size(112, 34)
        ButtonANNULER.TabIndex = 22
        ButtonANNULER.Text = "Annuler"
        ButtonANNULER.UseVisualStyleBackColor = True
        ' 
        ' ButtonSUPPRIMER
        ' 
        ButtonSUPPRIMER.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ButtonSUPPRIMER.Location = New Point(879, 691)
        ButtonSUPPRIMER.Name = "ButtonSUPPRIMER"
        ButtonSUPPRIMER.Size = New Size(112, 34)
        ButtonSUPPRIMER.TabIndex = 21
        ButtonSUPPRIMER.Text = "Supprimer"
        ButtonSUPPRIMER.UseVisualStyleBackColor = True
        ' 
        ' ButtonMODIFIER
        ' 
        ButtonMODIFIER.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ButtonMODIFIER.Location = New Point(498, 691)
        ButtonMODIFIER.Name = "ButtonMODIFIER"
        ButtonMODIFIER.Size = New Size(112, 34)
        ButtonMODIFIER.TabIndex = 20
        ButtonMODIFIER.Text = "Modifier"
        ButtonMODIFIER.UseVisualStyleBackColor = True
        ' 
        ' ButtonMISEAJOUR
        ' 
        ButtonMISEAJOUR.BackColor = Color.Navy
        ButtonMISEAJOUR.Font = New Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonMISEAJOUR.ForeColor = SystemColors.ButtonHighlight
        ButtonMISEAJOUR.Location = New Point(139, 15)
        ButtonMISEAJOUR.Margin = New Padding(4)
        ButtonMISEAJOUR.Name = "ButtonMISEAJOUR"
        ButtonMISEAJOUR.Size = New Size(185, 52)
        ButtonMISEAJOUR.TabIndex = 24
        ButtonMISEAJOUR.Text = "Mise à jour"
        ButtonMISEAJOUR.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Navy
        Button4.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(13, 15)
        Button4.Margin = New Padding(4)
        Button4.Name = "Button4"
        Button4.Size = New Size(118, 52)
        Button4.TabIndex = 25
        Button4.Text = "<<"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(1447, 786)
        Controls.Add(Button4)
        Controls.Add(ButtonMISEAJOUR)
        Controls.Add(ButtonANNULER)
        Controls.Add(ButtonSUPPRIMER)
        Controls.Add(ButtonMODIFIER)
        Controls.Add(ButtonAJOUTER)
        Controls.Add(DataGridView1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBoxCIN)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Name = "Form7"
        Text = "Form7"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxCIN As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonAJOUTER As Button
    Friend WithEvents ButtonANNULER As Button
    Friend WithEvents ButtonSUPPRIMER As Button
    Friend WithEvents ButtonMODIFIER As Button
    Friend WithEvents ButtonMISEAJOUR As Button
    Friend WithEvents CIN As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents debut As DataGridViewTextBoxColumn
    Friend WithEvents fin As DataGridViewTextBoxColumn
    Friend WithEvents statut As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
End Class
