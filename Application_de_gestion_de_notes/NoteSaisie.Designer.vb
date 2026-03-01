<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoteSaisie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoteSaisie))
        dgvNotes = New DataGridView()
        Panel1 = New Panel()
        lblMoyenne = New Label()
        Panel2 = New Panel()
        cmbEtablissement = New ComboBox()
        cmbCours = New ComboBox()
        cmbEtudiant = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        numNote = New NumericUpDown()
        Lablel1 = New Label()
        Cours = New Label()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        CType(dgvNotes, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(numNote, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvNotes
        ' 
        dgvNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNotes.Location = New Point(33, 83)
        dgvNotes.Name = "dgvNotes"
        dgvNotes.RowHeadersWidth = 51
        dgvNotes.Size = New Size(521, 244)
        dgvNotes.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(lblMoyenne)
        Panel1.Location = New Point(616, 309)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(368, 61)
        Panel1.TabIndex = 1
        ' 
        ' lblMoyenne
        ' 
        lblMoyenne.AutoSize = True
        lblMoyenne.BackColor = Color.Transparent
        lblMoyenne.Font = New Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMoyenne.Location = New Point(29, 20)
        lblMoyenne.Name = "lblMoyenne"
        lblMoyenne.Size = New Size(0, 21)
        lblMoyenne.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel2.Controls.Add(cmbEtablissement)
        Panel2.Controls.Add(cmbCours)
        Panel2.Controls.Add(cmbEtudiant)
        Panel2.Location = New Point(33, 400)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(521, 59)
        Panel2.TabIndex = 2
        ' 
        ' cmbEtablissement
        ' 
        cmbEtablissement.FormattingEnabled = True
        cmbEtablissement.Location = New Point(183, 18)
        cmbEtablissement.Name = "cmbEtablissement"
        cmbEtablissement.Size = New Size(151, 28)
        cmbEtablissement.TabIndex = 9
        ' 
        ' cmbCours
        ' 
        cmbCours.FormattingEnabled = True
        cmbCours.Location = New Point(356, 18)
        cmbCours.Name = "cmbCours"
        cmbCours.Size = New Size(151, 28)
        cmbCours.TabIndex = 1
        ' 
        ' cmbEtudiant
        ' 
        cmbEtudiant.FormattingEnabled = True
        cmbEtudiant.Location = New Point(13, 18)
        cmbEtudiant.Name = "cmbEtudiant"
        cmbEtudiant.Size = New Size(151, 28)
        cmbEtudiant.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(820, 513)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 33)
        Button1.TabIndex = 3
        Button1.Text = "Retour"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(316, 513)
        Button2.Name = "Button2"
        Button2.Size = New Size(122, 33)
        Button2.TabIndex = 4
        Button2.Text = "Enregistrer"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' numNote
        ' 
        numNote.DecimalPlaces = 2
        numNote.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        numNote.Location = New Point(771, 83)
        numNote.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        numNote.Name = "numNote"
        numNote.Size = New Size(184, 27)
        numNote.TabIndex = 5
        ' 
        ' Lablel1
        ' 
        Lablel1.AutoSize = True
        Lablel1.Font = New Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lablel1.Location = New Point(67, 363)
        Lablel1.Name = "Lablel1"
        Lablel1.Size = New Size(90, 21)
        Lablel1.TabIndex = 6
        Lablel1.Text = "Etudiants"
        ' 
        ' Cours
        ' 
        Cours.AutoSize = True
        Cours.Font = New Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Cours.Location = New Point(460, 363)
        Cours.Name = "Cours"
        Cours.Size = New Size(57, 21)
        Cours.TabIndex = 7
        Cours.Text = "Cours"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(33, 513)
        Button3.Name = "Button3"
        Button3.Size = New Size(122, 33)
        Button3.TabIndex = 8
        Button3.Text = "Rafraîchir"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(229, 363)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 21)
        Label1.TabIndex = 9
        Label1.Text = "Etablissement"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(203, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(546, 35)
        Label2.TabIndex = 10
        Label2.Text = "Gestion de la saisie des différentes notes"
        ' 
        ' NoteSaisie
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(1029, 601)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Cours)
        Controls.Add(Lablel1)
        Controls.Add(numNote)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(dgvNotes)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "NoteSaisie"
        Text = "NoteSaisie"
        CType(dgvNotes, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(numNote, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvNotes As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents numNote As NumericUpDown
    Friend WithEvents Lablel1 As Label
    Friend WithEvents Cours As Label
    Friend WithEvents lblMoyenne As Label
    Friend WithEvents cmbCours As ComboBox
    Friend WithEvents cmbEtudiant As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents cmbEtablissement As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
