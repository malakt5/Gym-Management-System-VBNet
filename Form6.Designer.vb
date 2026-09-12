<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        coach = New DataGridViewTextBoxColumn()
        ID = New DataGridViewTextBoxColumn()
        jour = New DataGridViewTextBoxColumn()
        datee = New DataGridViewTextBoxColumn()
        debut = New DataGridViewTextBoxColumn()
        salle = New DataGridViewTextBoxColumn()
        DateTimePicker = New DateTimePicker()
        ComboBoxCOACH = New ComboBox()
        ComboBoxID = New ComboBox()
        ButtonAJOUTER = New Button()
        ButtonMODIFIER = New Button()
        ButtonSUPPRIMER = New Button()
        ButtonANNULER = New Button()
        ButtonMENU = New Button()
        Label6 = New Label()
        ComboBoxSALLE = New ComboBox()
        Label7 = New Label()
        ComboBoxJOUR = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        ButtonMISEAJOUR = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(459, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(418, 50)
        Label1.TabIndex = 1
        Label1.Text = "NOS PLANNINGS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label2.Location = New Point(61, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 25)
        Label2.TabIndex = 2
        Label2.Text = "Coach :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label3.Location = New Point(61, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 25)
        Label3.TabIndex = 3
        Label3.Text = "ID de l'activité:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label4.Location = New Point(61, 310)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 25)
        Label4.TabIndex = 4
        Label4.Text = "Date:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label5.Location = New Point(61, 379)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 25)
        Label5.TabIndex = 5
        Label5.Text = "Heure début:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {coach, ID, jour, datee, debut, salle})
        DataGridView1.Location = New Point(594, 150)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(962, 327)
        DataGridView1.TabIndex = 6
        ' 
        ' coach
        ' 
        coach.HeaderText = "Coach"
        coach.MinimumWidth = 8
        coach.Name = "coach"
        coach.Width = 150
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID de l'activité"
        ID.MinimumWidth = 8
        ID.Name = "ID"
        ID.Width = 150
        ' 
        ' jour
        ' 
        jour.HeaderText = "Jour"
        jour.MinimumWidth = 8
        jour.Name = "jour"
        jour.Width = 150
        ' 
        ' datee
        ' 
        datee.HeaderText = "Date"
        datee.MinimumWidth = 8
        datee.Name = "datee"
        datee.Width = 150
        ' 
        ' debut
        ' 
        debut.HeaderText = "Heure début"
        debut.MinimumWidth = 8
        debut.Name = "debut"
        debut.Width = 150
        ' 
        ' salle
        ' 
        salle.HeaderText = "Salle"
        salle.MinimumWidth = 8
        salle.Name = "salle"
        salle.Width = 150
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.Location = New Point(217, 310)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(300, 31)
        DateTimePicker.TabIndex = 7
        ' 
        ' ComboBoxCOACH
        ' 
        ComboBoxCOACH.FormattingEnabled = True
        ComboBoxCOACH.Location = New Point(217, 150)
        ComboBoxCOACH.Name = "ComboBoxCOACH"
        ComboBoxCOACH.Size = New Size(300, 33)
        ComboBoxCOACH.TabIndex = 8
        ' 
        ' ComboBoxID
        ' 
        ComboBoxID.FormattingEnabled = True
        ComboBoxID.Location = New Point(217, 207)
        ComboBoxID.Name = "ComboBoxID"
        ComboBoxID.Size = New Size(300, 33)
        ComboBoxID.TabIndex = 9
        ' 
        ' ButtonAJOUTER
        ' 
        ButtonAJOUTER.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ButtonAJOUTER.Location = New Point(67, 489)
        ButtonAJOUTER.Name = "ButtonAJOUTER"
        ButtonAJOUTER.Size = New Size(112, 34)
        ButtonAJOUTER.TabIndex = 11
        ButtonAJOUTER.Text = "Ajouter"
        ButtonAJOUTER.UseVisualStyleBackColor = True
        ' 
        ' ButtonMODIFIER
        ' 
        ButtonMODIFIER.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ButtonMODIFIER.Location = New Point(337, 489)
        ButtonMODIFIER.Name = "ButtonMODIFIER"
        ButtonMODIFIER.Size = New Size(112, 34)
        ButtonMODIFIER.TabIndex = 12
        ButtonMODIFIER.Text = "Modifier"
        ButtonMODIFIER.UseVisualStyleBackColor = True
        ' 
        ' ButtonSUPPRIMER
        ' 
        ButtonSUPPRIMER.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ButtonSUPPRIMER.Location = New Point(594, 489)
        ButtonSUPPRIMER.Name = "ButtonSUPPRIMER"
        ButtonSUPPRIMER.Size = New Size(112, 34)
        ButtonSUPPRIMER.TabIndex = 13
        ButtonSUPPRIMER.Text = "Supprimer"
        ButtonSUPPRIMER.UseVisualStyleBackColor = True
        ' 
        ' ButtonANNULER
        ' 
        ButtonANNULER.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ButtonANNULER.Location = New Point(884, 489)
        ButtonANNULER.Name = "ButtonANNULER"
        ButtonANNULER.Size = New Size(112, 34)
        ButtonANNULER.TabIndex = 14
        ButtonANNULER.Text = "Annuler"
        ButtonANNULER.UseVisualStyleBackColor = True
        ' 
        ' ButtonMENU
        ' 
        ButtonMENU.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ButtonMENU.Location = New Point(1152, 489)
        ButtonMENU.Name = "ButtonMENU"
        ButtonMENU.Size = New Size(112, 34)
        ButtonMENU.TabIndex = 15
        ButtonMENU.Text = "Menu"
        ButtonMENU.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label6.Location = New Point(61, 447)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 25)
        Label6.TabIndex = 17
        Label6.Text = "Salle:"
        ' 
        ' ComboBoxSALLE
        ' 
        ComboBoxSALLE.FormattingEnabled = True
        ComboBoxSALLE.Items.AddRange(New Object() {"Salle 1", "Salle 2", "Salle 3", "Salle 4", "Salle 5"})
        ComboBoxSALLE.Location = New Point(217, 444)
        ComboBoxSALLE.Name = "ComboBoxSALLE"
        ComboBoxSALLE.Size = New Size(300, 33)
        ComboBoxSALLE.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(61, 262)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 25)
        Label7.TabIndex = 19
        Label7.Text = "Jour:"
        ' 
        ' ComboBoxJOUR
        ' 
        ComboBoxJOUR.FormattingEnabled = True
        ComboBoxJOUR.Items.AddRange(New Object() {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"})
        ComboBoxJOUR.Location = New Point(217, 259)
        ComboBoxJOUR.Name = "ComboBoxJOUR"
        ComboBoxJOUR.Size = New Size(300, 33)
        ComboBoxJOUR.TabIndex = 20
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Time
        DateTimePicker1.Location = New Point(217, 379)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 21
        ' 
        ' ButtonMISEAJOUR
        ' 
        ButtonMISEAJOUR.BackColor = Color.Navy
        ButtonMISEAJOUR.Font = New Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonMISEAJOUR.ForeColor = SystemColors.ButtonHighlight
        ButtonMISEAJOUR.Location = New Point(26, 37)
        ButtonMISEAJOUR.Margin = New Padding(4)
        ButtonMISEAJOUR.Name = "ButtonMISEAJOUR"
        ButtonMISEAJOUR.Size = New Size(185, 52)
        ButtonMISEAJOUR.TabIndex = 22
        ButtonMISEAJOUR.Text = "Mise à jour"
        ButtonMISEAJOUR.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(1607, 560)
        Controls.Add(ButtonMISEAJOUR)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBoxJOUR)
        Controls.Add(Label7)
        Controls.Add(ComboBoxSALLE)
        Controls.Add(Label6)
        Controls.Add(ButtonMENU)
        Controls.Add(ButtonANNULER)
        Controls.Add(ButtonSUPPRIMER)
        Controls.Add(ButtonMODIFIER)
        Controls.Add(ButtonAJOUTER)
        Controls.Add(ComboBoxID)
        Controls.Add(ComboBoxCOACH)
        Controls.Add(DateTimePicker)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form6"
        Text = "Form6"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents ComboBoxCOACH As ComboBox
    Friend WithEvents ComboBoxID As ComboBox
    Friend WithEvents ButtonAJOUTER As Button
    Friend WithEvents ButtonMODIFIER As Button
    Friend WithEvents ButtonSUPPRIMER As Button
    Friend WithEvents ButtonANNULER As Button
    Friend WithEvents ButtonMENU As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxSALLE As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxJOUR As ComboBox
    Friend WithEvents coach As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents jour As DataGridViewTextBoxColumn
    Friend WithEvents datee As DataGridViewTextBoxColumn
    Friend WithEvents debut As DataGridViewTextBoxColumn
    Friend WithEvents salle As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ButtonMISEAJOUR As Button
End Class
