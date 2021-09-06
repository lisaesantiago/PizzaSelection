<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzaSelection
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picDeepDish = New System.Windows.Forms.PictureBox()
        Me.picThinCrust = New System.Windows.Forms.PictureBox()
        Me.btnDeepDish = New System.Windows.Forms.Button()
        Me.btnSelectPizza = New System.Windows.Forms.Button()
        Me.btnThinCrust = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThinCrust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblHeading.Location = New System.Drawing.Point(93, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(226, 34)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Pizza Selection"
        '
        'picDeepDish
        '
        Me.picDeepDish.Location = New System.Drawing.Point(13, 65)
        Me.picDeepDish.Name = "picDeepDish"
        Me.picDeepDish.Size = New System.Drawing.Size(185, 150)
        Me.picDeepDish.TabIndex = 1
        Me.picDeepDish.TabStop = False
        '
        'picThinCrust
        '
        Me.picThinCrust.Location = New System.Drawing.Point(215, 65)
        Me.picThinCrust.Name = "picThinCrust"
        Me.picThinCrust.Size = New System.Drawing.Size(185, 150)
        Me.picThinCrust.TabIndex = 2
        Me.picThinCrust.TabStop = False
        '
        'btnDeepDish
        '
        Me.btnDeepDish.Location = New System.Drawing.Point(72, 226)
        Me.btnDeepDish.Name = "btnDeepDish"
        Me.btnDeepDish.Size = New System.Drawing.Size(75, 23)
        Me.btnDeepDish.TabIndex = 3
        Me.btnDeepDish.Text = "Deep Dish"
        Me.btnDeepDish.UseVisualStyleBackColor = True
        '
        'btnSelectPizza
        '
        Me.btnSelectPizza.Location = New System.Drawing.Point(169, 226)
        Me.btnSelectPizza.Name = "btnSelectPizza"
        Me.btnSelectPizza.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectPizza.TabIndex = 4
        Me.btnSelectPizza.Text = "Select Pizza"
        Me.btnSelectPizza.UseVisualStyleBackColor = True
        '
        'btnThinCrust
        '
        Me.btnThinCrust.Location = New System.Drawing.Point(265, 226)
        Me.btnThinCrust.Name = "btnThinCrust"
        Me.btnThinCrust.Size = New System.Drawing.Size(75, 23)
        Me.btnThinCrust.TabIndex = 5
        Me.btnThinCrust.Text = "Thin Crust"
        Me.btnThinCrust.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(325, 313)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(11, 272)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(391, 18)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Choose a pizza type and then click the Select Pizza button."
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(106, 316)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(182, 18)
        Me.lblConfirmation.TabIndex = 8
        Me.lblConfirmation.Text = "Enjoy Your pizza selection."
        '
        'frmPizzaSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 348)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnThinCrust)
        Me.Controls.Add(Me.btnSelectPizza)
        Me.Controls.Add(Me.btnDeepDish)
        Me.Controls.Add(Me.picThinCrust)
        Me.Controls.Add(Me.picDeepDish)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmPizzaSelection"
        Me.Text = "Pizza Selection"
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThinCrust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picDeepDish As PictureBox
    Friend WithEvents picThinCrust As PictureBox
    Friend WithEvents btnDeepDish As Button
    Friend WithEvents btnSelectPizza As Button
    Friend WithEvents btnThinCrust As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
End Class
