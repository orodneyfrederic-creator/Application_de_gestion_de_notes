<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSaisie
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
        Panel2 = New Panel()
        cmbEtablissement = New ComboBox()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Label5 = New Label()
        txtPrenom = New TextBox()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        txtNom = New TextBox()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        dgvEtudiants = New DataGridView()
        Label4 = New Label()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEtudiants, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(cmbEtablissement)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(793, 481)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(411, 89)
        Panel2.TabIndex = 50
        ' 
        ' cmbEtablissement
        ' 
        cmbEtablissement.FormattingEnabled = True
        cmbEtablissement.Location = New Point(198, 28)
        cmbEtablissement.Name = "cmbEtablissement"
        cmbEtablissement.Size = New Size(205, 28)
        cmbEtablissement.TabIndex = 22
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(82, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 18)
        Label3.TabIndex = 11
        Label3.Text = "Etablissement"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.téléchargement_removebg_preview1
        PictureBox3.Location = New Point(6, 13)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(69, 56)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.téléchargement__1__removebg_preview1
        PictureBox1.Location = New Point(402, -23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(901, 869)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Constantia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(285, -116)
        Label1.Name = "Label1"
        Label1.Size = New Size(543, 41)
        Label1.TabIndex = 49
        Label1.Text = "Gestionnaire des différents cours"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtPrenom)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(txtNom)
        Panel1.Location = New Point(37, 474)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(482, 149)
        Panel1.TabIndex = 48
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(159, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 18)
        Label5.TabIndex = 13
        Label5.Text = "Prénom"
        ' 
        ' txtPrenom
        ' 
        txtPrenom.Font = New Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPrenom.Location = New Point(256, 93)
        txtPrenom.Name = "txtPrenom"
        txtPrenom.Size = New Size(204, 29)
        txtPrenom.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(181, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 18)
        Label2.TabIndex = 10
        Label2.Text = "Nom"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Notes_free_icons_designed_by_Freepik_removebg_preview
        PictureBox2.Location = New Point(18, 32)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(99, 90)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' txtNom
        ' 
        txtNom.Font = New Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNom.Location = New Point(256, 38)
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(204, 29)
        txtNom.TabIndex = 9
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(1100, 252)
        Button5.Name = "Button5"
        Button5.Size = New Size(117, 46)
        Button5.TabIndex = 47
        Button5.Text = "Rafraichir"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(1102, 135)
        Button4.Name = "Button4"
        Button4.Size = New Size(117, 46)
        Button4.TabIndex = 46
        Button4.Text = "Supprimer"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(37, 649)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 46)
        Button3.TabIndex = 45
        Button3.Text = "Modifier"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(402, 649)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 46)
        Button2.TabIndex = 44
        Button2.Text = "Ajouter"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1087, 621)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 46)
        Button1.TabIndex = 43
        Button1.Text = "Retour"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' dgvEtudiants
        ' 
        dgvEtudiants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEtudiants.Location = New Point(37, 94)
        dgvEtudiants.Name = "dgvEtudiants"
        dgvEtudiants.RowHeadersWidth = 51
        dgvEtudiants.Size = New Size(697, 339)
        dgvEtudiants.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Constantia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(293, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(639, 41)
        Label4.TabIndex = 51
        Label4.Text = "Gestionnaire des différents apprenants"
        ' 
        ' FormSaisie
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1235, 724)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(dgvEtudiants)
        Controls.Add(PictureBox1)
        Name = "FormSaisie"
        Text = "FormSaisie"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEtudiants, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbEtablissement As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvEtudiants As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents Label5 As Label
End Class
