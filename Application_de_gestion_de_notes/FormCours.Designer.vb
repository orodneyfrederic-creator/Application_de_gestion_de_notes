<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCours
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
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        cmbEtablissement = New ComboBox()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        txtLibelle = New TextBox()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        dgvCours = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCours, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.téléchargement__1__removebg_preview1
        PictureBox1.Location = New Point(444, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(852, 752)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(cmbEtablissement)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(845, 553)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(411, 89)
        Panel2.TabIndex = 40
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Constantia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(324, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(543, 41)
        Label1.TabIndex = 39
        Label1.Text = "Gestionnaire des différents cours"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(txtLibelle)
        Panel1.Location = New Point(35, 553)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(413, 89)
        Panel1.TabIndex = 38
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(77, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 18)
        Label2.TabIndex = 10
        Label2.Text = "Libellé du cours"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Notes_free_icons_designed_by_Freepik_removebg_preview
        PictureBox2.Location = New Point(3, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(70, 62)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' txtLibelle
        ' 
        txtLibelle.Font = New Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLibelle.Location = New Point(199, 28)
        txtLibelle.Name = "txtLibelle"
        txtLibelle.Size = New Size(204, 29)
        txtLibelle.TabIndex = 9
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(1134, 274)
        Button5.Name = "Button5"
        Button5.Size = New Size(117, 46)
        Button5.TabIndex = 37
        Button5.Text = "Rafraichir"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(1134, 151)
        Button4.Name = "Button4"
        Button4.Size = New Size(117, 46)
        Button4.TabIndex = 36
        Button4.Text = "Supprimer"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(38, 688)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 46)
        Button3.TabIndex = 35
        Button3.Text = "Modifier"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(288, 688)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 46)
        Button2.TabIndex = 34
        Button2.Text = "Ajouter"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1139, 687)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 46)
        Button1.TabIndex = 33
        Button1.Text = "Retour"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' dgvCours
        ' 
        dgvCours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCours.Location = New Point(35, 139)
        dgvCours.Name = "dgvCours"
        dgvCours.RowHeadersWidth = 51
        dgvCours.Size = New Size(697, 339)
        dgvCours.TabIndex = 32
        ' 
        ' FormCours
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(1291, 774)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(dgvCours)
        Controls.Add(PictureBox1)
        Name = "FormCours"
        Text = "FormCours"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCours, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbEtablissement As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtLibelle As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvCours As DataGridView
End Class
