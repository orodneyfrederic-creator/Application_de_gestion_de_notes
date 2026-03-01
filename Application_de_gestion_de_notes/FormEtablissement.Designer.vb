<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEtablissement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEtablissement))
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        txtNom = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        txtVille = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Descargar_esquema_de_útiles_escolares_de_patrones_sin_fisuras_gratis_removebg_preview
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1237, 860)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(29, 116)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(600, 422)
        DataGridView1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1031, 731)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 46)
        Button1.TabIndex = 2
        Button1.Text = "Retour"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(847, 492)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 46)
        Button2.TabIndex = 3
        Button2.Text = "Ajouter"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(1031, 492)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 46)
        Button3.TabIndex = 4
        Button3.Text = "Modifier"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(512, 731)
        Button4.Name = "Button4"
        Button4.Size = New Size(117, 46)
        Button4.TabIndex = 5
        Button4.Text = "Supprimer"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(29, 731)
        Button5.Name = "Button5"
        Button5.Size = New Size(117, 46)
        Button5.TabIndex = 6
        Button5.Text = "Rafraichir"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(txtNom)
        Panel1.Location = New Point(847, 213)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(301, 63)
        Panel1.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(65, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 18)
        Label2.TabIndex = 10
        Label2.Text = "Nom"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.name_tag_Icon___Free_PNG___SVG_1056272___Noun_Project_removebg_preview1
        PictureBox2.Location = New Point(-7, -4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(83, 69)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' txtNom
        ' 
        txtNom.Font = New Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNom.Location = New Point(125, 19)
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(157, 29)
        txtNom.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Constantia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(337, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(536, 41)
        Label1.TabIndex = 8
        Label1.Text = "Gestionnaire des établissements"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(txtVille)
        Panel2.Location = New Point(847, 354)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(301, 63)
        Panel2.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(66, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 18)
        Label3.TabIndex = 11
        Label3.Text = "Ville"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Icônes_gratuites_Adresse_Du_Domicile_conçues_par_Talha_Dogar_removebg_preview1
        PictureBox3.Location = New Point(0, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(69, 56)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' txtVille
        ' 
        txtVille.Font = New Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtVille.Location = New Point(125, 19)
        txtVille.Name = "txtVille"
        txtVille.Size = New Size(157, 29)
        txtVille.TabIndex = 9
        ' 
        ' FormEtablissement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(1200, 808)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormEtablissement"
        Text = "FormEtablissement"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
