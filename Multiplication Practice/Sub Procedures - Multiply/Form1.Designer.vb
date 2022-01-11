<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblShowProblem = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAnswerHere = New System.Windows.Forms.Label()
        Me.picWallpaper = New System.Windows.Forms.PictureBox()
        CType(Me.picWallpaper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblShowProblem
        '
        Me.lblShowProblem.AutoSize = True
        Me.lblShowProblem.BackColor = System.Drawing.SystemColors.Control
        Me.lblShowProblem.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowProblem.Location = New System.Drawing.Point(111, 41)
        Me.lblShowProblem.Name = "lblShowProblem"
        Me.lblShowProblem.Size = New System.Drawing.Size(0, 21)
        Me.lblShowProblem.TabIndex = 0
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(109, 117)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(105, 33)
        Me.txtAnswer.TabIndex = 1
        '
        'btnLaunch
        '
        Me.btnLaunch.BackColor = System.Drawing.SystemColors.Control
        Me.btnLaunch.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaunch.Location = New System.Drawing.Point(38, 171)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(105, 43)
        Me.btnLaunch.TabIndex = 2
        Me.btnLaunch.Text = "Submit"
        Me.btnLaunch.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(175, 171)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 44)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblAnswerHere
        '
        Me.lblAnswerHere.AutoSize = True
        Me.lblAnswerHere.BackColor = System.Drawing.SystemColors.Control
        Me.lblAnswerHere.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerHere.ForeColor = System.Drawing.Color.Black
        Me.lblAnswerHere.Location = New System.Drawing.Point(105, 91)
        Me.lblAnswerHere.Name = "lblAnswerHere"
        Me.lblAnswerHere.Size = New System.Drawing.Size(114, 21)
        Me.lblAnswerHere.TabIndex = 4
        Me.lblAnswerHere.Text = "Answer Below"
        '
        'picWallpaper
        '
        Me.picWallpaper.Image = Global.Sub_Procedures___Multiply.My.Resources.Resources.flat_landscape_minimalism_trees_sunset_river_artwork
        Me.picWallpaper.Location = New System.Drawing.Point(0, -2)
        Me.picWallpaper.Name = "picWallpaper"
        Me.picWallpaper.Size = New System.Drawing.Size(317, 261)
        Me.picWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWallpaper.TabIndex = 5
        Me.picWallpaper.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 256)
        Me.Controls.Add(Me.picWallpaper)
        Me.Controls.Add(Me.lblAnswerHere)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblShowProblem)
        Me.MaximumSize = New System.Drawing.Size(332, 295)
        Me.Name = "Form1"
        Me.Text = "Multiplication Practice"
        CType(Me.picWallpaper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblShowProblem As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnLaunch As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAnswerHere As Label
    Friend WithEvents picWallpaper As PictureBox
End Class
