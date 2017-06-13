Public Class IMSS_Regedit_Edit
    Private _IMSS_RegeditClass As New clsNGSRegistry
    Private Sub IMSS_Regedit_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '_IMSS_Name_TextBoxX.Text = _IMSS_Name
        _IMSS_Path_RichTextBoxEx.Text = _IMSS_FilePath
    End Sub

    Private Sub _IMSS_ButtonX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ButtonX.Click
        _IMSS_OpenFileDialog.ShowDialog()
        _IMSS_Path_RichTextBoxEx.Text = _IMSS_OpenFileDialog.FileName.ToString()
    End Sub

    Private Sub _IMSS_Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub _IMSS_Ok_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Ok_Button.Click
        If Not _IMSS_Name = "none" Then
            If Not _IMSS_Path_RichTextBoxEx.Text = _IMSS_FilePath Then
                If _IMSS_RegeditClassPath = "HKEY_CURRENT_USER" Then
                    _IMSS_RegeditClass.DeleteValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER, _IMSS_RegeditPath, _IMSS_Name)
                    If _IMSS_Name_TextBoxX.Text = Nothing Then
                        Dim autoshell = My.Computer.Registry.CurrentUser.OpenSubKey(_IMSS_RegeditPath, True)
                        autoshell.SetValue(_IMSS_Name, _IMSS_Path_RichTextBoxEx.Text)
                        autoshell.Close()
                        _IMSS_ReLoadAndClose()
                    Else
                        Dim autoshell = My.Computer.Registry.CurrentUser.OpenSubKey(_IMSS_RegeditPath, True)
                        autoshell.SetValue(_IMSS_Name, """" & _IMSS_Path_RichTextBoxEx.Text & """" & _IMSS_Name_TextBoxX.Text)
                        autoshell.Close()
                        _IMSS_ReLoadAndClose()
                    End If
                    _IMSS_ReLoadAndClose()
                ElseIf _IMSS_RegeditClassPath = "HKEY_LOCALE_MACHINE" Then
                    _IMSS_RegeditClass.DeleteValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, _IMSS_RegeditPath, _IMSS_Name)
                    If _IMSS_Name_TextBoxX.Text = Nothing Then
                        Dim autoshell = My.Computer.Registry.LocalMachine.OpenSubKey(_IMSS_RegeditPath, True)
                        autoshell.SetValue(_IMSS_Name, _IMSS_Path_RichTextBoxEx.Text)
                        autoshell.Close()
                        _IMSS_ReLoadAndClose()
                    Else
                        Dim autoshell = My.Computer.Registry.LocalMachine.OpenSubKey(_IMSS_RegeditPath, True)
                        autoshell.SetValue(_IMSS_Name, """" & _IMSS_Path_RichTextBoxEx.Text & """" & _IMSS_Name_TextBoxX.Text)
                        autoshell.Close()
                        _IMSS_ReLoadAndClose()
                    End If
                End If
            Else
                _IMSS_ReLoadAndClose()
            End If
        End If
    End Sub
    Private Sub _IMSS_ReLoadAndClose()
        System.Threading.Thread.Sleep(400)
        'IMSSStartupCleaner._IMSS_ReLoad()
        Me.Close()
    End Sub
End Class