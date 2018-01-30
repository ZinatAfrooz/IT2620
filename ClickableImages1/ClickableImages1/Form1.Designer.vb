<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pctOne = New System.Windows.Forms.PictureBox()
        Me.pctTwo = New System.Windows.Forms.PictureBox()
        Me.pctThree = New System.Windows.Forms.PictureBox()
        Me.pctFour = New System.Windows.Forms.PictureBox()
        Me.pctFive = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        CType(Me.pctOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctFive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctOne
        '
        Me.pctOne.Image = CType(resources.GetObject("pctOne.Image"), System.Drawing.Image)
        Me.pctOne.Location = New System.Drawing.Point(12, 145)
        Me.pctOne.Name = "pctOne"
        Me.pctOne.Size = New System.Drawing.Size(86, 104)
        Me.pctOne.TabIndex = 0
        Me.pctOne.TabStop = False
        '
        'pctTwo
        '
        Me.pctTwo.Image = CType(resources.GetObject("pctTwo.Image"), System.Drawing.Image)
        Me.pctTwo.Location = New System.Drawing.Point(120, 145)
        Me.pctTwo.Name = "pctTwo"
        Me.pctTwo.Size = New System.Drawing.Size(100, 104)
        Me.pctTwo.TabIndex = 1
        Me.pctTwo.TabStop = False
        '
        'pctThree
        '
        Me.pctThree.Image = CType(resources.GetObject("pctThree.Image"), System.Drawing.Image)
        Me.pctThree.Location = New System.Drawing.Point(236, 145)
        Me.pctThree.Name = "pctThree"
        Me.pctThree.Size = New System.Drawing.Size(121, 104)
        Me.pctThree.TabIndex = 2
        Me.pctThree.TabStop = False
        '
        'pctFour
        '
        Me.pctFour.Image = CType(resources.GetObject("pctFour.Image"), System.Drawing.Image)
        Me.pctFour.Location = New System.Drawing.Point(363, 145)
        Me.pctFour.Name = "pctFour"
        Me.pctFour.Size = New System.Drawing.Size(145, 104)
        Me.pctFour.TabIndex = 3
        Me.pctFour.TabStop = False
        '
        'pctFive
        '
        Me.pctFive.Image = CType(resources.GetObject("pctFive.Image"), System.Drawing.Image)
        Me.pctFive.Location = New System.Drawing.Point(531, 145)
        Me.pctFive.Name = "pctFive"
        Me.pctFive.Size = New System.Drawing.Size(145, 104)
        Me.pctFive.TabIndex = 4
        Me.pctFive.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(38, 28)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 261)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.pctFive)
        Me.Controls.Add(Me.pctFour)
        Me.Controls.Add(Me.pctThree)
        Me.Controls.Add(Me.pctTwo)
        Me.Controls.Add(Me.pctOne)
        Me.Name = "Form1"
        Me.Text = "Clickable Images"
        CType(Me.pctOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctFive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctOne As PictureBox
    Friend WithEvents pctTwo As PictureBox
    Friend WithEvents pctThree As PictureBox
    Friend WithEvents pctFour As PictureBox
    Friend WithEvents pctFive As PictureBox
    Friend WithEvents lblMessage As Label
End Class
