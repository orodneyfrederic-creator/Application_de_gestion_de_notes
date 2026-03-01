<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acceuil
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
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        BtnDéconnexion = New Button()
        BtnSaisiedesnotes = New Button()
        BtnCours = New Button()
        BtnEteablissements = New Button()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Panel4 = New Panel()
        Label7 = New Label()
        Label5 = New Label()
        Panel3 = New Panel()
        Label6 = New Label()
        AffichageEtab = New Label()
        Panel2 = New Panel()
        AffichementEtudiants = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(BtnDéconnexion)
        Panel1.Controls.Add(BtnSaisiedesnotes)
        Panel1.Controls.Add(BtnCours)
        Panel1.Controls.Add(BtnEteablissements)
        Panel1.Location = New Point(0, -16)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(345, 737)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.System
        Button2.Font = New Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(12, 564)
        Button2.Name = "Button2"
        Button2.Size = New Size(305, 41)
        Button2.TabIndex = 6
        Button2.Text = "Résultats"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(11, 506)
        Button1.Name = "Button1"
        Button1.Size = New Size(305, 41)
        Button1.TabIndex = 5
        Button1.Text = " Saisie des notes"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.téléchargement_removebg_preview
        PictureBox1.Location = New Point(16, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(299, 302)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' BtnDéconnexion
        ' 
        BtnDéconnexion.FlatStyle = FlatStyle.System
        BtnDéconnexion.Font = New Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnDéconnexion.Location = New Point(0, 667)
        BtnDéconnexion.Name = "BtnDéconnexion"
        BtnDéconnexion.Size = New Size(174, 52)
        BtnDéconnexion.TabIndex = 3
        BtnDéconnexion.Text = "Déconnexion"
        BtnDéconnexion.UseVisualStyleBackColor = True
        ' 
        ' BtnSaisiedesnotes
        ' 
        BtnSaisiedesnotes.FlatStyle = FlatStyle.System
        BtnSaisiedesnotes.Font = New Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSaisiedesnotes.Location = New Point(12, 449)
        BtnSaisiedesnotes.Name = "BtnSaisiedesnotes"
        BtnSaisiedesnotes.Size = New Size(305, 43)
        BtnSaisiedesnotes.TabIndex = 2
        BtnSaisiedesnotes.Text = "Apprenants"
        BtnSaisiedesnotes.UseVisualStyleBackColor = True
        ' 
        ' BtnCours
        ' 
        BtnCours.FlatStyle = FlatStyle.System
        BtnCours.Font = New Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCours.Location = New Point(11, 391)
        BtnCours.Name = "BtnCours"
        BtnCours.Size = New Size(305, 45)
        BtnCours.TabIndex = 1
        BtnCours.Text = "Cours"
        BtnCours.UseVisualStyleBackColor = True
        ' 
        ' BtnEteablissements
        ' 
        BtnEteablissements.BackColor = SystemColors.ButtonHighlight
        BtnEteablissements.FlatStyle = FlatStyle.System
        BtnEteablissements.Font = New Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEteablissements.ForeColor = SystemColors.ControlLight
        BtnEteablissements.Location = New Point(11, 336)
        BtnEteablissements.Name = "BtnEteablissements"
        BtnEteablissements.Size = New Size(305, 42)
        BtnEteablissements.TabIndex = 0
        BtnEteablissements.Text = "Etablissements"
        BtnEteablissements.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.téléchargement__1__removebg_preview
        PictureBox2.Location = New Point(335, -13)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(789, 734)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Constantia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(563, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 41)
        Label1.TabIndex = 8
        Label1.Text = "Menu principal"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Goldenrod
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label5)
        Panel4.Location = New Point(466, 478)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(474, 125)
        Panel4.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonFace
        Label7.Location = New Point(25, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(225, 24)
        Label7.TabIndex = 4
        Label7.Text = "Etudiants en difficulté"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Constantia", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(25, 55)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 58)
        Label5.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.ForestGreen
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(AffichageEtab)
        Panel3.Location = New Point(466, 297)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(475, 142)
        Panel3.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(25, 7)
        Label6.Name = "Label6"
        Label6.Size = New Size(208, 24)
        Label6.TabIndex = 3
        Label6.Text = "Total établissements"
        ' 
        ' AffichageEtab
        ' 
        AffichageEtab.AutoSize = True
        AffichageEtab.Font = New Font("Constantia", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AffichageEtab.ForeColor = SystemColors.ButtonFace
        AffichageEtab.Location = New Point(25, 50)
        AffichageEtab.Name = "AffichageEtab"
        AffichageEtab.Size = New Size(0, 58)
        AffichageEtab.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightSlateGray
        Panel2.Controls.Add(AffichementEtudiants)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(466, 130)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(465, 134)
        Panel2.TabIndex = 5
        ' 
        ' AffichementEtudiants
        ' 
        AffichementEtudiants.AutoSize = True
        AffichementEtudiants.Font = New Font("Constantia", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AffichementEtudiants.ForeColor = SystemColors.ButtonFace
        AffichementEtudiants.Location = New Point(25, 43)
        AffichementEtudiants.Name = "AffichementEtudiants"
        AffichementEtudiants.Size = New Size(0, 58)
        AffichementEtudiants.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(25, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 24)
        Label2.TabIndex = 0
        Label2.Text = "Total étudiants"
        ' 
        ' Acceuil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(1123, 715)
        Controls.Add(Label1)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Name = "Acceuil"
        Text = "Menu principal"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEteablissements As Button
    Friend WithEvents BtnDéconnexion As Button
    Friend WithEvents BtnSaisiedesnotes As Button
    Friend WithEvents BtnCours As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents AffichageEtab As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AffichementEtudiants As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
