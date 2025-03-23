'Noah Holloway
'RCET 2265
'Spring 2025
'Diner Menu
'https://github.com/hollnoah/DinerMenu.git

Option Strict On
Option Explicit On
Option Compare Text

Public Class DinerMenuForm
    Private Sub DinerNameLabel_Click(sender As Object, e As EventArgs) Handles DinerNameLabel.Click
        Me.Text = "Restaraunte de Comida Special Menu"
        DisplaySpecialLabel.Text = "Select a menu option to view todays special!"
    End Sub
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text =
            "La sopa del dia" & vbCrLf &
          "~ Cozy Chicken & Gnocchi Soup ~" & vbCrLf & vbCrLf &
            "Warm up with a bowl of pure comfort! Our Chicken & Gnocchi Soup" & vbCrLf &
            "is packed with tender roasted chicken, pillowy potato gnocchi," & vbCrLf &
            "and a creamy, herb-infused broth that'll make you feel like" & vbCrLf &
            "you're wrapped in a grandma-approved hug. A touch of nutmeg," & vbCrLf &
            "a sprinkle of parmesan, and a handful of baby spinach" & vbCrLf &
            "complete this heartwarming dish. Grab a spoon and dive in!"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text =
           "La enselada del dia" & vbCrLf &
            "~ Mandarin Walnut Bliss Salad ~" & vbCrLf & vbCrLf &
            "Sweet, tangy, crunchy, and fresh—this salad has it all!" & vbCrLf &
            "Juicy mandarin oranges, toasted walnuts, and crumbled feta" & vbCrLf &
            "rest on a bed of crisp romaine and baby spinach. Tossed in a" & vbCrLf &
            "zingy honey-lime vinaigrette, this salad is the perfect balance" & vbCrLf &
            "of flavors. Add some grilled chicken for extra heartiness," & vbCrLf &
            "or just enjoy it as is—because it's already pretty perfect!"
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text =
             "El Pescado del dia" & vbCrLf &
            "~ Honey Chipotle Smoked Salmon ~" & vbCrLf & vbCrLf &
            "Sweet, smoky, and just the right amount of heat—this dish" & vbCrLf &
            "is a flavor explosion! Our fresh Atlantic salmon is smoked" & vbCrLf &
            "to perfection, then glazed with a house-made honey-chipotle sauce." & vbCrLf &
            "Served with a side of garlic butter asparagus and roasted red potatoes," & vbCrLf &
            "this meal will make you wonder why you ever ate anything else." & vbCrLf &
            "Spice up your life—order this salmon today!"

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
