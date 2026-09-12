<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        ComboBoxCATEGORIE = New ComboBox()
        ComboBoxNIVEAU = New ComboBox()
        ComboBoxINTENSITE = New ComboBox()
        TextBoxTYPE = New TextBox()
        TextBoxDUREE = New TextBox()
        DataGridView1 = New DataGridView()
        Label7 = New Label()
        TextBoxID = New TextBox()
        categorie = New DataGridViewTextBoxColumn()
        type = New DataGridViewTextBoxColumn()
        niveau = New DataGridViewTextBoxColumn()
        intensite = New DataGridViewTextBoxColumn()
        duree = New DataGridViewTextBoxColumn()
        ID = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(292, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(670, 50)
        Label1.TabIndex = 1
        Label1.Text = "NOS ACTIVITES SPORTIVES"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBoxDUREE)
        GroupBox1.Controls.Add(ComboBoxNIVEAU)
        GroupBox1.Controls.Add(ComboBoxINTENSITE)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(59, 230)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(550, 298)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Détails de l'activité:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label2.Location = New Point(59, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 25)
        Label2.TabIndex = 3
        Label2.Text = "Catégorie:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label3.Location = New Point(59, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 25)
        Label3.TabIndex = 4
        Label3.Text = "Type:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label4.Location = New Point(20, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 25)
        Label4.TabIndex = 5
        Label4.Text = "Niveau:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label5.Location = New Point(20, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 25)
        Label5.TabIndex = 6
        Label5.Text = "Intensité:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label6.Location = New Point(20, 236)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 25)
        Label6.TabIndex = 7
        Label6.Text = "Durée:"
        ' 
        ' ComboBoxCATEGORIE
        ' 
        ComboBoxCATEGORIE.FormattingEnabled = True
        ComboBoxCATEGORIE.Location = New Point(218, 121)
        ComboBoxCATEGORIE.Name = "ComboBoxCATEGORIE"
        ComboBoxCATEGORIE.Size = New Size(391, 33)
        ComboBoxCATEGORIE.TabIndex = 5
        ' 
        ' ComboBoxNIVEAU
        ' 
        ComboBoxNIVEAU.FormattingEnabled = True
        ComboBoxNIVEAU.Location = New Point(123, 58)
        ComboBoxNIVEAU.Name = "ComboBoxNIVEAU"
        ComboBoxNIVEAU.Size = New Size(343, 33)
        ComboBoxNIVEAU.TabIndex = 6
        ' 
        ' ComboBoxINTENSITE
        ' 
        ComboBoxINTENSITE.FormattingEnabled = True
        ComboBoxINTENSITE.Location = New Point(123, 152)
        ComboBoxINTENSITE.Name = "ComboBoxINTENSITE"
        ComboBoxINTENSITE.Size = New Size(343, 33)
        ComboBoxINTENSITE.TabIndex = 7
        ' 
        ' TextBoxTYPE
        ' 
        TextBoxTYPE.Location = New Point(218, 178)
        TextBoxTYPE.Name = "TextBoxTYPE"
        TextBoxTYPE.Size = New Size(391, 31)
        TextBoxTYPE.TabIndex = 6
        ' 
        ' TextBoxDUREE
        ' 
        TextBoxDUREE.Location = New Point(123, 230)
        TextBoxDUREE.Name = "TextBoxDUREE"
        TextBoxDUREE.Size = New Size(343, 31)
        TextBoxDUREE.TabIndex = 7
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {categorie, type, niveau, intensite, duree, ID})
        DataGridView1.Location = New Point(652, 121)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(965, 456)
        DataGridView1.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label7.Location = New Point(59, 552)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 25)
        Label7.TabIndex = 8
        Label7.Text = "ID de l'activité:"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(218, 552)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(391, 31)
        TextBoxID.TabIndex = 9
        ' 
        ' categorie
        ' 
        categorie.HeaderText = "Catégorie"
        categorie.MinimumWidth = 8
        categorie.Name = "categorie"
        categorie.Width = 150
        ' 
        ' type
        ' 
        type.HeaderText = "Type"
        type.MinimumWidth = 8
        type.Name = "type"
        type.Width = 150
        ' 
        ' niveau
        ' 
        niveau.HeaderText = "Niveau"
        niveau.MinimumWidth = 8
        niveau.Name = "niveau"
        niveau.Width = 150
        ' 
        ' intensite
        ' 
        intensite.HeaderText = "Intensité"
        intensite.MinimumWidth = 8
        intensite.Name = "intensite"
        intensite.Width = 150
        ' 
        ' duree
        ' 
        duree.HeaderText = "Durée"
        duree.MinimumWidth = 8
        duree.Name = "duree"
        duree.Width = 150
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID de l'activité"
        ID.MinimumWidth = 8
        ID.Name = "ID"
        ID.Width = 150
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(1686, 788)
        Controls.Add(TextBoxID)
        Controls.Add(Label7)
        Controls.Add(DataGridView1)
        Controls.Add(TextBoxTYPE)
        Controls.Add(ComboBoxCATEGORIE)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxNIVEAU As ComboBox
    Friend WithEvents ComboBoxINTENSITE As ComboBox
    Friend WithEvents ComboBoxCATEGORIE As ComboBox
    Friend WithEvents TextBoxTYPE As TextBox
    Friend WithEvents TextBoxDUREE As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents categorie As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents niveau As DataGridViewTextBoxColumn
    Friend WithEvents intensite As DataGridViewTextBoxColumn
    Friend WithEvents duree As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
End Class
