<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResults
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
        dgvResultats = New DataGridView()
        Button1 = New Button()
        btnPDF = New Button()
        btnExcel = New Button()
        Panel1 = New Panel()
        btnWord = New Button()
        Label2 = New Label()
        Button2 = New Button()
        CType(dgvResultats, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(316, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(466, 35)
        Label1.TabIndex = 0
        Label1.Text = "Tableau récapitulatif des résultats"
        ' 
        ' dgvResultats
        ' 
        dgvResultats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResultats.Location = New Point(20, 98)
        dgvResultats.Name = "dgvResultats"
        dgvResultats.RowHeadersWidth = 51
        dgvResultats.Size = New Size(867, 404)
        dgvResultats.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button1.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1025, 563)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 43)
        Button1.TabIndex = 2
        Button1.Text = "Retour"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnPDF
        ' 
        btnPDF.BackColor = Color.Red
        btnPDF.Font = New Font("Constantia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPDF.Location = New Point(68, 82)
        btnPDF.Name = "btnPDF"
        btnPDF.Size = New Size(112, 33)
        btnPDF.TabIndex = 3
        btnPDF.Text = "PDF"
        btnPDF.UseVisualStyleBackColor = False
        ' 
        ' btnExcel
        ' 
        btnExcel.BackColor = Color.ForestGreen
        btnExcel.Font = New Font("Constantia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExcel.Location = New Point(68, 141)
        btnExcel.Name = "btnExcel"
        btnExcel.Size = New Size(112, 35)
        btnExcel.TabIndex = 4
        btnExcel.Text = "Doc. Excel"
        btnExcel.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(btnWord)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnExcel)
        Panel1.Controls.Add(btnPDF)
        Panel1.Location = New Point(906, 98)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 282)
        Panel1.TabIndex = 5
        ' 
        ' btnWord
        ' 
        btnWord.BackColor = Color.Blue
        btnWord.Font = New Font("Constantia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnWord.Location = New Point(68, 203)
        btnWord.Name = "btnWord"
        btnWord.Size = New Size(112, 32)
        btnWord.TabIndex = 5
        btnWord.Text = "Doc. Word"
        btnWord.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(68, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 24)
        Label2.TabIndex = 0
        Label2.Text = "Impression"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button2.Font = New Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(20, 563)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 43)
        Button2.TabIndex = 6
        Button2.Text = "Rafraîchir"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' FormResults
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1168, 628)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(dgvResultats)
        Controls.Add(Label1)
        Name = "FormResults"
        Text = "FormResults"
        CType(dgvResultats, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvResultats As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPDF As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnWord As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
