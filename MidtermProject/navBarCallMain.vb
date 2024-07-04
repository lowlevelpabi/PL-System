Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class navBarCallMain

    Public Shared Sub btn1(mainForm As mainForm)

        mainForm.storePanel.BringToFront()

        mainForm.btnStore.BackColor = Color.FromArgb(199, 54, 89)

        mainForm.btnHome.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnAbout.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnSettings.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnCart.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnHistory.BackColor = Color.FromArgb(47, 43, 44)

        dikoalamto()

        mainForm.Load_Items()

    End Sub

    Public Shared Sub btn2(mainForm As mainForm)

        mainForm.homePanel.BringToFront()

        mainForm.btnStore.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnHome.BackColor = Color.FromArgb(199, 54, 89)

        mainForm.btnAbout.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnSettings.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnCart.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnHistory.BackColor = Color.FromArgb(47, 43, 44)

    End Sub

    Public Shared Sub btn3(mainForm As mainForm)

        mainForm.panelAbout.BringToFront()

        mainForm.btnStore.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnHome.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnAbout.BackColor = Color.FromArgb(199, 54, 89)

        mainForm.btnSettings.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnCart.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnHistory.BackColor = Color.FromArgb(47, 43, 44)

    End Sub

    Public Shared Sub btn4(mainForm As mainForm)

        mainForm.panelCart.BringToFront()

        mainForm.btnStore.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnHome.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnAbout.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnSettings.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnCart.BackColor = Color.FromArgb(199, 54, 89)

        mainForm.btnHistory.BackColor = Color.FromArgb(47, 43, 44)

    End Sub

    Public Shared Sub btn5(mainForm As mainForm)

        mainForm.panelSettings.BringToFront()

        mainForm.btnStore.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnHome.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnAbout.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnSettings.BackColor = Color.FromArgb(199, 54, 89)

        mainForm.btnCart.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnHistory.BackColor = Color.FromArgb(47, 43, 44)

    End Sub

    Public Shared Sub btn6(mainForm As mainForm)

        mainForm.historyPanel.BringToFront()

        mainForm.btnStore.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnHome.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnAbout.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnSettings.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnCart.BackColor = Color.FromArgb(47, 43, 44)

        mainForm.btnHistory.BackColor = Color.FromArgb(199, 54, 89)

        AllFunctionsMain.retrieveOrders(mainForm)

    End Sub

    Public Shared Sub revoke2(mainForm As mainForm)

        Dim response As String

        response = MsgBox("Do you want to log out?", MsgBoxStyle.Question & vbYesNo, "Log out?")

        If response = vbYes Then

            mainForm.unSession = Nothing

            mainForm.isLoginSession = False

            Form1.txtUsername.Focus()

            Application.Restart() ' wala na kong ibang option :)

        Else

            ' ... more function for else clause here

        End If

    End Sub

    Public Shared Sub deleteAccount(mainForm As mainForm)

        MsgBox(" :p ", , "No comment.")

    End Sub
End Class