'Program Name: Pizza Selection
'Developer: Lisa Santiago
'Date: 13SEP2021
'Purpose: This program displays two pizz types for the user to choose from.
Public Class frmPizzaSelection
    Private Sub frmPizzaSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'events for thin crust button
    Private Sub btnThinCrust_Click(sender As Object, e As EventArgs) Handles btnThinCrust.Click
        picThinCrust.Visible = True 'thin crust pic visible
        picDeepDish.Visible = False 'deep dish pic not visible
        btnSelectPizza.Enabled = True 'select pizza button enabled
    End Sub

    'events for deep dish button
    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click
        picDeepDish.Visible = True 'deep dish pick visible
        picThinCrust.Visible = False 'thin crust pic not visible
        btnSelectPizza.Enabled = True 'select pizza button enabled
    End Sub

    Private Sub picDeepDish_Click(sender As Object, e As EventArgs) Handles picDeepDish.Click

    End Sub

    Private Sub lblConfirmation_Click(sender As Object, e As EventArgs) Handles lblConfirmation.Click

    End Sub

    Private Sub btnSelectPizza_Click(sender As Object, e As EventArgs) Handles btnSelectPizza.Click
        lblConfirmation.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub lblInstructions_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click

    End Sub
End Class
