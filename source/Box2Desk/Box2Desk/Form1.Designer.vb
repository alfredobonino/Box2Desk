<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Login1 = New System.Windows.Forms.Button()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.PassWord = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Login2 = New System.Windows.Forms.Button()
        Me.ViewFile = New System.Windows.Forms.Button()
        Me.Logout1 = New System.Windows.Forms.Button()
        Me.language = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Login1
        '
        resources.ApplyResources(Me.Login1, "Login1")
        Me.Login1.Name = "Login1"
        Me.Login1.UseVisualStyleBackColor = True
        '
        'UserName
        '
        resources.ApplyResources(Me.UserName, "UserName")
        Me.UserName.Name = "UserName"
        '
        'PassWord
        '
        resources.ApplyResources(Me.PassWord, "PassWord")
        Me.PassWord.Name = "PassWord"
        Me.PassWord.UseSystemPasswordChar = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Login2
        '
        resources.ApplyResources(Me.Login2, "Login2")
        Me.Login2.Name = "Login2"
        Me.Login2.UseVisualStyleBackColor = True
        '
        'ViewFile
        '
        resources.ApplyResources(Me.ViewFile, "ViewFile")
        Me.ViewFile.Name = "ViewFile"
        Me.ViewFile.UseVisualStyleBackColor = True
        '
        'Logout1
        '
        resources.ApplyResources(Me.Logout1, "Logout1")
        Me.Logout1.Name = "Logout1"
        Me.Logout1.UseVisualStyleBackColor = True
        '
        'language
        '
        Me.language.FormattingEnabled = True
        resources.ApplyResources(Me.language, "language")
        Me.language.Name = "language"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.language)
        Me.Controls.Add(Me.Logout1)
        Me.Controls.Add(Me.ViewFile)
        Me.Controls.Add(Me.Login2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PassWord)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Login1)
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login1 As System.Windows.Forms.Button
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents PassWord As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Login2 As System.Windows.Forms.Button
    Friend WithEvents ViewFile As System.Windows.Forms.Button
    Friend WithEvents Logout1 As System.Windows.Forms.Button
    Friend WithEvents language As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
