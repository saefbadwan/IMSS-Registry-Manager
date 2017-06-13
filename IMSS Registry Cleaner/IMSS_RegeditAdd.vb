Imports System.IO
Imports IWshRuntimeLibrary
Public Class IMSS_RegeditAdd
    'Private IMSSStartupCleaner As IMSSStartupCleaner
    Private _IMSS_RegeditClass As New clsNGSRegistry
    Private Sub _IMSS_ButtonX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ButtonX.Click
        _IMSS_OpenFileDialog.ShowDialog()
        _IMSS_Path_RichTextBoxEx.Text = _IMSS_OpenFileDialog.FileName.ToString()
    End Sub

    Private Sub _IMSS_Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub _IMSS_Ok_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Ok_Button.Click
        If _IMSS_Path_RichTextBoxEx.Text.Length > 0 Then
            Select Case CType(_IMSS_Section_ComboBox.SelectedItem.Text, String)
                Case "StartUp\All Users"
                    If _IMSS_Name_TextBoxX.Text.Length > 0 Then
                        Try
                            Dim _IMSS_PATH As String = Environment.ExpandEnvironmentVariables("%AllUsersProfile%") + "\Start Menu\Programs\Startup\" & _IMSS_Name_TextBoxX.Text & New FileInfo(_IMSS_Path_RichTextBoxEx.Text).Extension.ToString()
                            If Not IO.File.Exists(_IMSS_PATH) Then _IMSS_CreateShortCut(New String() {_IMSS_Name_TextBoxX.Text, _IMSS_Path_RichTextBoxEx.Text, Environment.ExpandEnvironmentVariables("%AllUsersProfile%")})
                        Catch : End Try
                    End If
                Case "StartUp\Current User"
                    If _IMSS_Name_TextBoxX.Text.Length > 0 Then
                        Try
                            Dim _IMSS_PATH As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\" & _IMSS_Name_TextBoxX.Text & New FileInfo(_IMSS_Path_RichTextBoxEx.Text).Extension.ToString()
                            If Not IO.File.Exists(_IMSS_PATH) Then _IMSS_CreateShortCut(New String() {_IMSS_Name_TextBoxX.Text, _IMSS_Path_RichTextBoxEx.Text, Environment.GetFolderPath(Environment.SpecialFolder.Startup)})
                        Catch : End Try
                    End If
                Case "Registry\All Users\Run"
                    Try
                        If _IMSS_Name_TextBoxX.Text.Length > 0 Then
                            If Not _IMSS_Arguments_TextBoxX.Text.Length > 0 Then
                                _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "Software\Microsoft\Windows\CurrentVersion\Run", _IMSS_Name_TextBoxX.Text, _IMSS_Path_RichTextBoxEx.Text)
                            Else
                                _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "Software\Microsoft\Windows\CurrentVersion\Run", _IMSS_Name_TextBoxX.Text, """" & _IMSS_Path_RichTextBoxEx.Text & """" & " " & _IMSS_Arguments_TextBoxX.Text)
                            End If
                        End If
                    Catch : End Try
                Case "Registry\All Users\Run Once"
                    Try
                        If _IMSS_Name_TextBoxX.Text.Length > 0 Then
                            If Not _IMSS_Arguments_TextBoxX.Text.Length > 0 Then
                                _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "Software\Microsoft\Windows\CurrentVersion\RunOnce", _IMSS_Name_TextBoxX.Text, _IMSS_Path_RichTextBoxEx.Text)
                            Else
                                _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "Software\Microsoft\Windows\CurrentVersion\RunOnce", _IMSS_Name_TextBoxX.Text, """" & _IMSS_Path_RichTextBoxEx.Text & """" & " " & _IMSS_Arguments_TextBoxX.Text)
                            End If
                        End If
                    Catch : End Try
                Case "Registry\All Users\BootExecute"
                    Try
                        If Not _IMSS_Arguments_TextBoxX.Text.Length > 0 Then
                            _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "System\CurrentControlSet\Control\Session Manager\BootExecute", _IMSS_Name_TextBoxX.Text, _IMSS_Path_RichTextBoxEx.Text)
                        Else
                            _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "System\CurrentControlSet\Control\Session Manager\BootExecute", _IMSS_Name_TextBoxX.Text, """" & _IMSS_Path_RichTextBoxEx.Text & """" & " " & _IMSS_Arguments_TextBoxX.Text)
                        End If
                    Catch : End Try
                Case "Registry\All Users\StartupPrograms"
                    Try
                        If Not _IMSS_Arguments_TextBoxX.Text.Length > 0 Then
                            _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "System\CurrentControlSet\Control\Terminal Server\Wds\rdpwd\StartupPrograms", _IMSS_Name_TextBoxX.Text, _IMSS_Path_RichTextBoxEx.Text)
                        Else
                            _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "System\CurrentControlSet\Control\Terminal Server\Wds\rdpwd\StartupPrograms", _IMSS_Name_TextBoxX.Text, """" & _IMSS_Path_RichTextBoxEx.Text & """" & " " & _IMSS_Arguments_TextBoxX.Text)
                        End If
                    Catch : End Try
                Case "Registry\Current User\Run"
                    Try
                        If Not _IMSS_Arguments_TextBoxX.Text.Length > 0 Then
                            _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Run", _IMSS_Name_TextBoxX.Text, _IMSS_Path_RichTextBoxEx.Text)
                        Else
                            _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Run", _IMSS_Name_TextBoxX.Text, """" & _IMSS_Path_RichTextBoxEx.Text & """" & " " & _IMSS_Arguments_TextBoxX.Text)
                        End If
                    Catch : End Try
                Case "Registry\Current User\Run Once"
                    Try
                        If Not _IMSS_Arguments_TextBoxX.Text.Length > 0 Then
                            _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\RunOnce", _IMSS_Name_TextBoxX.Text, _IMSS_Path_RichTextBoxEx.Text)
                        Else
                            _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\RunOnce", _IMSS_Name_TextBoxX.Text, """" & _IMSS_Path_RichTextBoxEx.Text & """" & " " & _IMSS_Arguments_TextBoxX.Text)
                        End If
                    Catch : End Try
                Case "Registry\All Users\Shell"
                    Try
                        If Not _IMSS_Arguments_TextBoxX.Text.Length > 0 Then
                            _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER, "Microsoft\Windows NT\CurrentVersion\Winlogon\Shell", _IMSS_Name_TextBoxX.Text, _IMSS_Path_RichTextBoxEx.Text)
                        Else
                            _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER, "Microsoft\Windows NT\CurrentVersion\Winlogon\Shell", _IMSS_Name_TextBoxX.Text, """" & _IMSS_Path_RichTextBoxEx.Text & """" & " " & _IMSS_Arguments_TextBoxX.Text)
                        End If
                    Catch ex As Exception
                    End Try
                Case "Registry\All Usersr\Userinit"
                    Try
                        If Not _IMSS_Arguments_TextBoxX.Text.Length > 0 Then
                            _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\Userinit", _IMSS_Name_TextBoxX.Text, _IMSS_Path_RichTextBoxEx.Text)
                        Else
                            _IMSS_RegeditClass.CreateValue(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\Userinit", _IMSS_Name_TextBoxX.Text, """" & _IMSS_Path_RichTextBoxEx.Text & """" & " " & _IMSS_Arguments_TextBoxX.Text)
                        End If
                    Catch : End Try
            End Select
            Me.Close()
        End If
    End Sub

    Private Sub _IMSS_Section_ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Section_ComboBox.SelectedIndexChanged
        If _IMSS_Section_ComboBox.SelectedIndex = 0 Or _IMSS_Section_ComboBox.SelectedIndex = 1 Then
            _IMSS_Arguments_TextBoxX.Enabled = False
        Else
            _IMSS_Arguments_TextBoxX.Enabled = True
        End If
    End Sub

    Private Sub _IMSS_CreateShortCut(ByRef _IMSS_ShortCutValues() As String)
        Dim WshShell As WshShellClass = New WshShellClass
        Dim MyShortcut As IWshRuntimeLibrary.IWshShortcut
        MyShortcut = CType(WshShell.CreateShortcut(_IMSS_ShortCutValues(2) & "\" & _IMSS_ShortCutValues(0) & ".lnk"), IWshRuntimeLibrary.IWshShortcut)
        MyShortcut.TargetPath = _IMSS_ShortCutValues(1)  'Specify target file full path
        MyShortcut.Save()
    End Sub

End Class