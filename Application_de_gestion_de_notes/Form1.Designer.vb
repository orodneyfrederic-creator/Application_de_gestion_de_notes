<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        txtNom = New TextBox()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        txtPass = New TextBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(432, 87)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(395, 343)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Constantia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(349, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(478, 45)
        Label1.TabIndex = 1
        Label1.Text = "Bienvenue cher utilisateur"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(txtNom)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(26, 335)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 66)
        Panel1.TabIndex = 2
        ' 
        ' txtNom
        ' 
        txtNom.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNom.Location = New Point(90, 17)
        txtNom.Multiline = True
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(253, 34)
        txtNom.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(11, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(58, 53)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel2.Controls.Add(txtPass)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(26, 444)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(400, 72)
        Panel2.TabIndex = 3
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPass.Location = New Point(90, 23)
        txtPass.Multiline = True
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(253, 34)
        txtPass.TabIndex = 6
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(11, 8)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(58, 54)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(12, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(331, 317)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button1.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(490, 399)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 57)
        Button1.TabIndex = 5
        Button1.Text = "Se connecter"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button2.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(685, 399)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 57)
        Button2.TabIndex = 6
        Button2.Text = "S'inscrire"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(835, 557)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Page de connection"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
