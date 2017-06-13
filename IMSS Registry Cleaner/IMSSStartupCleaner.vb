' بسم الله الرحمن الرحيم
Imports Microsoft.Win32
Imports System.IO
Imports ComponentOwl.BetterListView

Public Class IMSSStartupCleaner
    Private _IMSS_RegeditClass As New clsNGSRegistry
    Private _IMSS_FileFulInfiPath(1) As String
    Private i_Enable As Integer = 0
    Private i_Disable As Integer = 0
    Private _IMSS_CURUNTUSER_STARTUPDIR As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Startup"
    Private _IMSS_ALLUSER_STARTUPDIR As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ALLUSERStartup"
    'Public Sub New()
    '    ' This call is required by the designer.
    '    InitializeComponent()
    '    ' Add any initialization after the InitializeComponent() call.
    '    'Me.Size = New System.Drawing.Size(1144, 569)
    'End Sub



#Region "Set ListView and Load regedit Run Targets"

    Private Sub IMSS_LISTVIEW_AddGroubs()
        _IMSS_MainListView.Groups.Add("Registry Startup Programs").Font = New Font("Arial", 9, FontStyle.Regular)
        _IMSS_MainListView.Groups(0).Image = My.Resources._IMSS__alpha_RegistryEditor_Icon_24x24
        _IMSS_MainListView.Groups.Add("Startup Folders Programs").Font = New Font("Arial", 9, FontStyle.Regular)
        _IMSS_MainListView.Groups(1).Image = My.Resources._IMSS_Folder_24x24
        _IMSS_MainListView.ShowGroups = True
    End Sub





    'Private Sub _IMSS_SetRegeditKeysRun()
    '    On Error Resume Next
    '    If Not _IMSS_RegeditClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "Software\Microsoft\Windows\CurrentVersion\Run-") = True Then
    '        _IMSS_RegeditClass.CreateKey(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "Software\Microsoft\Windows\CurrentVersion\Run-")
    '    End If
    '    If Not _IMSS_RegeditClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Run-") = True Then
    '        _IMSS_RegeditClass.CreateKey(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Run-")
    '    End If
    '    If Not IO.Directory.Exists(_IMSS_CURUNTUSER_STARTUPDIR) Then IO.Directory.CreateDirectory(_IMSS_CURUNTUSER_STARTUPDIR)
    '    If Not IO.Directory.Exists(_IMSS_ALLUSER_STARTUPDIR) Then IO.Directory.CreateDirectory(_IMSS_ALLUSER_STARTUPDIR)
    'End Sub
    'Private Sub _IMSS_GetRegeditTargetValueForStartupEnabeld(ByVal _IMSS_LocalMachine_RegeditKey As RegistryKey, ByVal _IMSS_CurrentUser As RegistryKey, ByVal _IMSS_RegistryTargetPath As String)
    '    Try
    '        For Each Programs As String In _IMSS_LocalMachine_RegeditKey.GetValueNames()
    '            Dim GetValue As String = _IMSS_LocalMachine_RegeditKey.GetValue(Programs).ToString()
    '            If GetValue.Contains("""") Then
    '                GetValue = GetStringBetween(GetValue, """", """")
    '            End If
    '            Dim item1 As BetterListViewItem = _IMSS_MainListView.Groups(0).Items.Add(Programs)
    '            Try
    '                item1.Font = New Font("Sans Serif", 8, FontStyle.Regular)
    '                item1.Image = ResizeImage(Icon.ExtractAssociatedIcon(GetValue).ToBitmap, 16, 16)
    '            Catch ex As Exception
    '                item1.Image = My.Resources.favicon__1_.ToBitmap
    '            End Try
    '            item1.SubItems.Add("Startup enabeld").Image = My.Resources._IMSS_StatusOn_Icon_16x16
    '            item1.SubItems.Add("Optional").Image = My.Resources._IMSS_Optional_Icon_16x16
    '            item1.SubItems.Add("Registry Local Machine").Image = My.Resources._IMSS_AllUsers_Icon_16x16
    '            If Not GetValue.Length = 0 Then
    '                item1.SubItems.Add(GetValue).Image = My.Resources._IMSS_alpha_Folder_Opened_Icon_16x16
    '            Else
    '                item1.SubItems.Add("none")
    '            End If
    '            item1.SubItems.Add(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE.ToString() & _IMSS_RegistryTargetPath).Image = My.Resources.Registry_Defrag_16x16
    '            i_Enable += 1
    '        Next
    '        For Each Programs As String In _IMSS_CurrentUser.GetValueNames()
    '            Dim GetValue As String = _IMSS_CurrentUser.GetValue(Programs).ToString()
    '            If GetValue.Contains("""") Then
    '                GetValue = GetStringBetween(GetValue, """", """")
    '            End If
    '            Dim item2 As BetterListViewItem = _IMSS_MainListView.Groups(0).Items.Add(Programs)
    '            Try
    '                item2.Font = New Font("Sans Serif", 8, FontStyle.Regular)
    '                item2.Image = ResizeImage(Icon.ExtractAssociatedIcon(GetValue).ToBitmap, 16, 16)
    '            Catch ex As Exception
    '                item2.Image = My.Resources.favicon__1_.ToBitmap
    '            End Try
    '            item2.SubItems.Add("Startup enabeld").Image = My.Resources._IMSS_StatusOn_Icon_16x16
    '            item2.SubItems.Add("Optional").Image = My.Resources._IMSS_Optional_Icon_16x16
    '            item2.SubItems.Add("Registry Current User").Image = My.Resources._IMSS_CurrentUser_Icon_16x16
    '            If Not GetValue.Length = 0 Then
    '                item2.SubItems.Add(GetValue).Image = My.Resources._IMSS_alpha_Folder_Opened_Icon_16x16
    '            Else
    '                item2.SubItems.Add("none")
    '            End If
    '            item2.SubItems.Add(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER.ToString() & _IMSS_RegistryTargetPath).Image = My.Resources.Registry_Defrag_16x16
    '            i_Enable += 1
    '        Next
    '    Catch ex As Exception
    '        Dim item2 As BetterListViewItem = _IMSS_MainListView.Groups(0).Items.Add("Unknown error can't load this application")
    '        item2.Font = New Font("Sans Serif", 8, FontStyle.Regular)
    '        item2.Image = My.Resources.favicon__1_.ToBitmap
    '        item2.SubItems.Add("none").ForeColor = Color.Green
    '        item2.SubItems.Add("none")
    '        item2.SubItems.Add("none")
    '        item2.SubItems.Add("none")
    '        item2.SubItems.Add("none")
    '    End Try

    'End Sub
    'Private Sub _IMSS_GetRegeditTargetValueForStartupDisabled(ByVal _IMSS_LocalMachine_RegeditKey As RegistryKey, ByVal _IMSS_CurrentUser As RegistryKey)
    '    If _IMSS_RegeditClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "Software\Microsoft\Windows\CurrentVersion\Run-") = True Then
    '        For Each Programs As String In _IMSS_LocalMachine_RegeditKey.GetValueNames()
    '            Dim GetValue As String = _IMSS_LocalMachine_RegeditKey.GetValue(Programs).ToString()
    '            If GetValue.Contains("""") Then
    '                GetValue = GetStringBetween(GetValue, """", """")
    '            End If
    '            Dim item1 As BetterListViewItem = _IMSS_MainListView.Groups(1).Items.Add(Programs)
    '            Try
    '                item1.Font = New Font("Sans Serif", 8, FontStyle.Regular)
    '                item1.Image = ResizeImage(Icon.ExtractAssociatedIcon(GetValue).ToBitmap, 16, 16)
    '            Catch ex As Exception
    '                item1.Image = My.Resources.favicon__1_.ToBitmap
    '            End Try
    '            item1.SubItems.Add("Startup disabled").Image = My.Resources._IMSS_StatusOff_Icon_16x16
    '            item1.SubItems.Add("Optional").Image = My.Resources._IMSS_Optional_Icon_16x16
    '            item1.SubItems.Add("Registry Local Machine").Image = My.Resources._IMSS_AllUsers_Icon_16x16
    '            If Not GetValue.Length = 0 Then
    '                item1.SubItems.Add(GetValue).Image = My.Resources._IMSS_alpha_Folder_Opened_Icon_16x16
    '            Else
    '                item1.SubItems.Add("none")
    '            End If
    '            item1.SubItems.Add(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE.ToString & "\Software\Microsoft\Windows\CurrentVersion\Run-").Image = My.Resources.Registry_Defrag_16x16
    '            i_Disable += 1
    '        Next
    '    End If
    '    If _IMSS_RegeditClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Run-") = True Then
    '        For Each Programs As String In _IMSS_CurrentUser.GetValueNames()
    '            Dim GetValue As String = _IMSS_CurrentUser.GetValue(Programs).ToString()
    '            If GetValue.Contains("""") Then
    '                GetValue = GetStringBetween(GetValue, """", """")
    '            End If
    '            Dim item2 As BetterListViewItem = _IMSS_MainListView.Groups(1).Items.Add(Programs)
    '            Try
    '                item2.Font = New Font("Sans Serif", 8, FontStyle.Regular)
    '                item2.Image = ResizeImage(Icon.ExtractAssociatedIcon(GetValue).ToBitmap, 16, 16)
    '            Catch ex As Exception
    '                item2.Image = My.Resources.favicon__1_.ToBitmap
    '            End Try
    '            item2.SubItems.Add("Startup disabled").Image = My.Resources._IMSS_StatusOff_Icon_16x16
    '            item2.SubItems.Add("Optional").Image = My.Resources._IMSS_Optional_Icon_16x16
    '            item2.SubItems.Add("Registry Current User").Image = My.Resources._IMSS_CurrentUser_Icon_16x16
    '            If Not GetValue.Length = 0 Then
    '                item2.SubItems.Add(GetValue).Image = My.Resources._IMSS_alpha_Folder_Opened_Icon_16x16
    '            Else
    '                item2.SubItems.Add("none")
    '            End If
    '            item2.SubItems.Add(clsNGSRegistry.ERegistryPossibleRoots.HKEY_CURRENT_USER.ToString & "\Software\Microsoft\Windows\CurrentVersion\Run-").Image = My.Resources.Registry_Defrag_16x16
    '            i_Disable += 1
    '        Next
    '    End If
    'End Sub
    'Private Sub _IMSS_LocalMachineGetRegeditTargetValueForStartupEnabeld(ByVal _IMSS_LocalMachine_RegeditKey As RegistryKey, ByVal _IMSS_RegistryTargetPath As String)
    '    For Each Programs As String In _IMSS_LocalMachine_RegeditKey.GetValueNames()
    '        Dim GetValue As String = _IMSS_LocalMachine_RegeditKey.GetValue(Programs).ToString()
    '        If GetValue.Contains("""") Then
    '            GetValue = GetStringBetween(GetValue, """", """")
    '        End If
    '        Dim item1 As BetterListViewItem = _IMSS_MainListView.Groups(0).Items.Add(Programs)
    '        Try
    '            item1.Font = New Font("Sans Serif", 8, FontStyle.Regular)
    '            item1.Image = ResizeImage(Icon.ExtractAssociatedIcon(GetValue).ToBitmap, 16, 16)
    '        Catch ex As Exception
    '            item1.Image = My.Resources.favicon__1_.ToBitmap
    '        End Try
    '        item1.SubItems.Add("Startup enabeld").Image = My.Resources._IMSS_StatusOn_Icon_16x16
    '        item1.SubItems.Add("Optional").Image = My.Resources._IMSS_Optional_Icon_16x16
    '        item1.SubItems.Add("Registry Local Machine").Image = My.Resources._IMSS_AllUsers_Icon_16x16
    '        If Not GetValue.Length = 0 Then
    '            item1.SubItems.Add(GetValue).Image = My.Resources._IMSS_alpha_Folder_Opened_Icon_16x16
    '        Else
    '            item1.SubItems.Add("none")
    '        End If
    '        item1.SubItems.Add(_IMSS_RegistryTargetPath).Image = My.Resources.Registry_Defrag_16x16
    '        '_IMSS_MainListView.Items(0).Group = _IMSS_MainListView.Groups(0)
    '        i_Enable += 1
    '    Next
    'End Sub
    'Private Sub _IMSS_GET_STARTUP_ENABLE() ' IMSS Load Startup Enabeld From Registry LocalMachine and CurrentUser
    '    Dim _IMSS_LocalMachine_RegeditKey_Run As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
    '    Dim _IMSS_CurrentUser_RegeditKey_Run As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
    '    _IMSS_GetRegeditTargetValueForStartupEnabeld(_IMSS_LocalMachine_RegeditKey_Run, _IMSS_CurrentUser_RegeditKey_Run, "\Software\Microsoft\Windows\CurrentVersion\Run")
    '    Dim _IMSS_LocalMachine_RegeditKey_RunOnce As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\RunOnce")
    '    Dim _IMSS_CurrentUser_RegeditKey_RunOnce As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\RunOnce")
    '    _IMSS_GetRegeditTargetValueForStartupEnabeld(_IMSS_LocalMachine_RegeditKey_RunOnce, _IMSS_CurrentUser_RegeditKey_RunOnce, "\Software\Microsoft\Windows\CurrentVersion\RunOnce")
    '    If _IMSS_RegeditClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "System\CurrentControlSet\Control\Session Manager\BootExecute") = True Then
    '        Dim _IMSS_LocalMachine_RegeditKey_BootExecute As RegistryKey = Registry.LocalMachine.OpenSubKey("System\CurrentControlSet\Control\Session Manager\BootExecute")
    '        _IMSS_LocalMachineGetRegeditTargetValueForStartupEnabeld(_IMSS_LocalMachine_RegeditKey_BootExecute, clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE.ToString() & "\System\CurrentControlSet\Control\Session Manager\BootExecute")
    '    End If
    '    If _IMSS_RegeditClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "System\CurrentControlSet\Control\Terminal Server\Wds\rdpwd\StartupPrograms") = True Then
    '        Dim _IMSS_LocalMachine_RegeditKey_StartupPrograms As RegistryKey = Registry.LocalMachine.OpenSubKey("System\CurrentControlSet\Control\Terminal Server\Wds\rdpwd\StartupProgram")
    '        _IMSS_LocalMachineGetRegeditTargetValueForStartupEnabeld(_IMSS_LocalMachine_RegeditKey_StartupPrograms, clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE.ToString() & "\System\CurrentControlSet\Control\Terminal Server\Wds\rdpwd\StartupPrograms")
    '    End If
    '    If _IMSS_RegeditClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\Shell") = True Then
    '        Dim _IMSS_LocalMachine_RegeditKey_Shell As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\Shell")
    '        _IMSS_LocalMachineGetRegeditTargetValueForStartupEnabeld(_IMSS_LocalMachine_RegeditKey_Shell, clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE.ToString() & "\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\Shell")
    '    End If
    '    If _IMSS_RegeditClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\Userinit") = True Then
    '        Dim _IMSS_LocalMachine_RegeditKey_Userinit As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\Userinit")
    '        _IMSS_LocalMachineGetRegeditTargetValueForStartupEnabeld(_IMSS_LocalMachine_RegeditKey_Userinit, clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE.ToString() & "\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\Userinit")
    '    End If
    '    If System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").Contains(64) = True Then
    '        If _IMSS_RegeditClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run") = True Then
    '            Dim _IMSS_LocalMachine_RegeditKey_Run64 As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run")
    '            _IMSS_LocalMachineGetRegeditTargetValueForStartupEnabeld(_IMSS_LocalMachine_RegeditKey_Run64, clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE.ToString() & "\SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run")
    '        End If
    '    End If
    'End Sub
    'Private Sub _IMSS_GET_STARTUP_DISABLE()  ' IMSS Load Startup dsiabeld From Registry LocalMachine and CurrentUser
    '    Dim _IMSS_HRLOKM As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run-")
    '    Dim _IMSS_CUSER As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run-")
    '    _IMSS_GetRegeditTargetValueForStartupDisabled(_IMSS_HRLOKM, _IMSS_CUSER)
    'End Sub
    'Private Sub _IMSS_LoadFromCUSERStartUpfolder() ' IMSS Load CUSER StartUp Files Folder
    '    For Each _IMSS_Dir As String In My.Computer.FileSystem.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup))
    '        If Not Path.GetExtension(_IMSS_Dir).ToString = ".ini" And Not Path.GetExtension(_IMSS_Dir).ToString = ".inf" Then
    '            Dim item1 As BetterListViewItem = _IMSS_MainListView.Groups(0).Items.Add(Path.GetFileNameWithoutExtension(New FileInfo(_IMSS_Dir).FullName).ToString())
    '            Try
    '                item1.Font = New Font("Sans Serif", 8, FontStyle.Regular)
    '                item1.Image = ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_Dir).ToBitmap, 16, 16)
    '            Catch ex As Exception
    '                item1.Image = My.Resources.favicon__1_.ToBitmap
    '            End Try
    '            item1.SubItems.Add("Startup enabeld").Image = My.Resources._IMSS_StatusOn_Icon_16x16
    '            item1.SubItems.Add("Optional").Image = My.Resources._IMSS_Optional_Icon_16x16
    '            item1.SubItems.Add("Current User Startup Folder").Image = My.Resources._IMSS_CurrentUser_Icon_16x16
    '            item1.SubItems.Add(_IMSS_Dir).Image = My.Resources._IMSS_alpha_Folder_Opened_Icon_16x16
    '            item1.SubItems.Add("No need for registry key").Image = My.Resources._IMSS_RegeditPathNotAvailable_Icon_16x16
    '            '_IMSS_MainListView.Items(0).Group = _IMSS_MainListView.Groups(0)
    '            '_IMSS_MainListView.ShowGroups = True
    '            i_Enable += 1
    '        End If
    '    Next
    '    For Each _IMSS_Dir As String In My.Computer.FileSystem.GetFiles(_IMSS_CURUNTUSER_STARTUPDIR)
    '        If Not Path.GetExtension(_IMSS_Dir).ToString = ".ini" And Not Path.GetExtension(_IMSS_Dir).ToString = ".inf" Then
    '            Dim item1 As BetterListViewItem = _IMSS_MainListView.Groups(1).Items.Add(Path.GetFileNameWithoutExtension(New FileInfo(_IMSS_Dir).FullName).ToString())
    '            Try
    '                item1.Font = New Font("Sans Serif", 8, FontStyle.Regular)
    '                item1.Image = ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_Dir).ToBitmap, 16, 16)
    '            Catch ex As Exception
    '                item1.Image = My.Resources.favicon__1_.ToBitmap
    '            End Try
    '            item1.SubItems.Add("Startup disabled").Image = My.Resources._IMSS_StatusOff_Icon_16x16
    '            item1.SubItems.Add("Optional").Image = My.Resources._IMSS_Optional_Icon_16x16
    '            item1.SubItems.Add("Current User Startup Folder").Image = My.Resources._IMSS_CurrentUser_Icon_16x16
    '            item1.SubItems.Add(_IMSS_Dir).Image = My.Resources._IMSS_alpha_Folder_Opened_Icon_16x16
    '            item1.SubItems.Add("No need for registry key").Image = My.Resources._IMSS_RegeditPathNotAvailable_Icon_16x16
    '            '_IMSS_MainListView.Items(0).Group = _IMSS_MainListView.Groups(0)
    '            '_IMSS_MainListView.ShowGroups = True
    '            i_Disable += 1
    '        End If
    '    Next
    'End Sub
    'Private Sub _IMSS_LoadFromLOACALMACHIENStartUpFolder()
    '    For Each _IMSS_Dir As String In My.Computer.FileSystem.GetFiles(Environment.ExpandEnvironmentVariables("%AllUsersProfile%") + "\Start Menu\Programs\Startup")
    '        If Not Path.GetExtension(_IMSS_Dir).ToString = ".ini" And Not Path.GetExtension(_IMSS_Dir).ToString = ".inf" Then
    '            Dim item1 As BetterListViewItem = _IMSS_MainListView.Groups(0).Items.Add(Path.GetFileNameWithoutExtension(New FileInfo(_IMSS_Dir).FullName).ToString())
    '            Try
    '                item1.Font = New Font("Sans Serif", 8, FontStyle.Regular)
    '                item1.Image = ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_Dir).ToBitmap, 16, 16)
    '            Catch ex As Exception
    '                item1.Image = My.Resources.favicon__1_.ToBitmap
    '            End Try
    '            item1.SubItems.Add("Startup enabeld").Image = My.Resources._IMSS_StatusOn_Icon_16x16
    '            item1.SubItems.Add("Optional").Image = My.Resources._IMSS_Optional_Icon_16x16
    '            item1.SubItems.Add("All Users Startup Folder").Image = My.Resources._IMSS_AllUsers_Icon_16x16
    '            item1.SubItems.Add(_IMSS_Dir).Image = My.Resources._IMSS_alpha_Folder_Opened_Icon_16x16
    '            item1.SubItems.Add("No need for registry key").Image = My.Resources._IMSS_RegeditPathNotAvailable_Icon_16x16
    '            '_IMSS_MainListView.Items(0).Group = _IMSS_MainListView.Groups(0)
    '            '_IMSS_MainListView.ShowGroups = True
    '            i_Enable += 1
    '        End If
    '    Next
    '    For Each _IMSS_Dir As String In My.Computer.FileSystem.GetFiles(_IMSS_ALLUSER_STARTUPDIR)
    '        If Not Path.GetExtension(_IMSS_Dir).ToString = ".ini" And Not Path.GetExtension(_IMSS_Dir).ToString = ".inf" Then
    '            Dim item1 As BetterListViewItem = _IMSS_MainListView.Groups(1).Items.Add(Path.GetFileNameWithoutExtension(New FileInfo(_IMSS_Dir).FullName).ToString())
    '            Try
    '                item1.Font = New Font("Sans Serif", 8, FontStyle.Regular)
    '                item1.Image = ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_Dir).ToBitmap, 16, 16)
    '            Catch ex As Exception
    '                item1.Image = My.Resources.favicon__1_.ToBitmap
    '            End Try
    '            item1.SubItems.Add("Startup disabled").Image = My.Resources._IMSS_StatusOff_Icon_16x16
    '            item1.SubItems.Add("Optional").Image = My.Resources._IMSS_Optional_Icon_16x16
    '            item1.SubItems.Add("All Users Startup Folder").Image = My.Resources._IMSS_AllUsers_Icon_16x16
    '            item1.SubItems.Add(_IMSS_Dir).Image = My.Resources._IMSS_alpha_Folder_Opened_Icon_16x16
    '            item1.SubItems.Add("No need for registry key").Image = My.Resources._IMSS_RegeditPathNotAvailable_Icon_16x16
    '            '_IMSS_MainListView.Items(0).Group = _IMSS_MainListView.Groups(0)
    '            '_IMSS_MainListView.ShowGroups = True
    '            i_Disable += 1
    '        End If
    '    Next
    'End Sub
    'Private Sub _IMSS_Set_LISTVIEW_GROUB_TITLE()
    '    If _IMSS_MainListView.Groups(0).Items.Count <= 0 Then
    '        Dim item1 As BetterListViewItem = _IMSS_MainListView.Groups(0).Items.Add("There is no application in this group")
    '        item1.SubItems.Add("none")
    '        item1.SubItems.Add("none") '.Image = My.Resources.ico_alpha_Refresh_24x24
    '        item1.SubItems.Add("none")
    '        item1.SubItems.Add("none")
    '        _IMSS_MainListView.Groups(0).Header = "Startup enabeld (Group Empty)"
    '        _IMSS_TotalStartupPrograms.Text = "Total Enabled Programs Is 0"
    '    Else
    '        _IMSS_MainListView.Groups(0).Header = "Startup enabeld (" & i_Enable & ")"
    '        _IMSS_TotalStartupPrograms.Text = "Total Enabled Programs Is " & i_Enable
    '    End If
    '    If _IMSS_MainListView.Groups(1).Items.Count <= 0 Then
    '        Dim item1 As BetterListViewItem = _IMSS_MainListView.Groups(1).Items.Add("There is no application in this group")
    '        item1.SubItems.Add("none")
    '        item1.SubItems.Add("none") '.Image = My.Resources.ico_alpha_Refresh_24x24
    '        item1.SubItems.Add("none")
    '        item1.SubItems.Add("none")
    '        _IMSS_MainListView.Groups(1).Header = "Startup dsiabeld (Group Empty)"
    '    Else
    '        _IMSS_MainListView.Groups(1).Header = "Startup dsiabeld (" & i_Disable & ")"
    '    End If
    '    Dim _IMSS_Calc As Integer = 0
    '    If i_Enable > i_Disable Then
    '        _IMSS_Calc = i_Enable - i_Disable
    '    Else
    '        _IMSS_Calc = i_Disable - i_Enable
    '    End If
    '    _IMSS_AvailableStartUpPrograms_Label.Text = _IMSS_Calc & " Available startup programs"
    '    _IMSS_A_Startup_Label.Text = _IMSS_Calc & " Available startup programs"
    '    _IMSS_StartupE.Text = i_Enable & " Startup programs is enabeld"
    '    _IMSS_StartupD.Text = i_Disable & " Startup programs is dsiabeld"
    'End Sub
    'Private Function GetVersionFromRegistry() As Boolean
    '    Try
    '        If _IMSS_RegeditClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full") = True Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Return False
    '    End Try
    '    Return True
    'End Function

#End Region

#Region " ResizeImage "
    Private Function _IMSS_ResizeImage(ByVal SourceImage As Drawing.Image, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap
        Dim bmSource = New Drawing.Bitmap(SourceImage)
        Return _IMSS_ResizeImage(bmSource, TargetWidth, TargetHeight)
    End Function

    Private Function _IMSS_ResizeImage(ByVal bmSource As Drawing.Bitmap, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver

                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using

        Return bmDest
    End Function
#End Region

    Private Sub IMSSStartupCleaner_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            IMSS_Regedit_Edit.Close()
            IMSS_RegeditAdd.Close()
            IMSS_VaurisTotalScanner.Close()
        Catch : End Try
    End Sub

    Private Sub IMSSStartupCleaner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _IMSS_MainListView.Items.Clear()
        _IMSS_MainListView.BeginUpdate()
        IMSS_LISTVIEW_AddGroubs()
        _IMSS_LoadRegistryStartUp()
        _IMSS_LoadStartupFiles()
        _IMSS_MainListView.EndUpdate()
    End Sub

#Region " IMSS Load Startup Declarations"

    Private Sub _IMSS_LoadRegistryStartUp()
        Dim _IMSS_REGISTRY_KEY As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
        _IMSS_LoadRegistryKey(_IMSS_REGISTRY_KEY)
        _IMSS_REGISTRY_KEY = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
        _IMSS_LoadRegistryKey(_IMSS_REGISTRY_KEY)
    End Sub

    Private Sub _IMSS_LoadStartupFiles()
        If System.Environment.OSVersion.Version.Major = 5 Then
            Dim _IMSS_HomeDrive As String = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 2)
            _IMSS_LoadStartupFolders(_IMSS_HomeDrive & "\Documents and Settings\All Users\Start Menu\Programs\Startup", "All Users Startup")
            _IMSS_LoadStartupFolders(_IMSS_HomeDrive & "\Documents and Settings\" & Environment.UserName & "\Start Menu\Programs\Startup", Environment.UserName & " Startup")
        Else
            _IMSS_LoadStartupFolders(Environment.ExpandEnvironmentVariables("%AllUsersProfile%") & " \Microsoft\Windows\Start Menu\Programs\Startup", "All Users Startup")
            _IMSS_LoadStartupFolders(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Environment.UserName & " Startup")
        End If

    End Sub

    Private Sub _IMSS_LoadRegistryKey(ByRef _IMSS_KEY As RegistryKey)
        Try
            If Not _IMSS_KEY Is Nothing Then
                If _IMSS_KEY.GetValueNames().Length > 0 Then
                    For Each _IMSS_KEY_NAME In _IMSS_KEY.GetValueNames
                        Application.DoEvents()
                        Dim _IMSS_LocalPath As String = _IMSS_ReturnFilePath(_IMSS_KEY.GetValue(_IMSS_KEY_NAME.ToString()).ToString())
                        If Not String.IsNullOrEmpty(_IMSS_LocalPath) = True And _IMSS_CheckIfItemExsts(_IMSS_LocalPath) = True Then
                            With _IMSS_MainListView.Groups(0).Items.Add(IO.Path.GetFileNameWithoutExtension(_IMSS_LocalPath))
                                .Tag = "_IMSS_REGEDIT|" & _IMSS_KEY_NAME.ToString()
                                .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_LocalPath).ToBitmap(), 16, 16)
                                .SubItems.Add(_IMSS_KEY.Name.Split("\")(0))
                                .SubItems.Add(_IMSS_LocalPath)
                                .SubItems.Add(_IMSS_KEY.Name)
                            End With
                        End If
                    Next _IMSS_KEY_NAME : _IMSS_KEY.Close()
                End If
            Else
                Try : _IMSS_KEY.Close() : Catch : End Try
            End If
        Catch
            If Not _IMSS_KEY Is Nothing Then
                _IMSS_KEY.Close()
            End If
        End Try
    End Sub

    Private Sub _IMSS_LoadStartupFolders(ByVal _IMSS_FOLDER_PATH As String, ByVal _IMSS_FOLDER_TYPE As String)
        ' On Error Resume Next
        For Each _IMSS_FileName In Directory.GetFiles(_IMSS_FOLDER_PATH, "*.*")
            Application.DoEvents()
            If Path.GetExtension(_IMSS_FileName) = ".lnk" Or Path.GetExtension(_IMSS_FileName) = ".exe" Then
                If Not String.IsNullOrEmpty(_IMSS_FileName) = True And _IMSS_CheckIfItemExsts(_IMSS_FileName) = True Then
                    With _IMSS_MainListView.Groups(1).Items.Add(IO.Path.GetFileNameWithoutExtension(_IMSS_FileName))
                        .Tag = "_IMSS_STARTUPFOLDER"
                        .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_FileName).ToBitmap(), 16, 16)
                        .SubItems.Add(_IMSS_FOLDER_TYPE)
                        .SubItems.Add(_IMSS_FileName)
                        .SubItems.Add("No need for regisrey keys")
                    End With
                End If
            End If
        Next _IMSS_FileName
    End Sub

    Private Function _IMSS_CheckIfItemExsts(ByVal _IMSS_VALUE As String)
        If IO.Directory.Exists(_IMSS_VALUE) = True Then
            Return True
        ElseIf IO.File.Exists(_IMSS_VALUE) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Shared Function _IMSS_ReturnFilePath(ByVal value As String) As String

        Try
            Dim p As Integer

            ' Check for quotes, and if present, remove them.
            If value.Contains(Chr(34)) Then
                value = value.Replace(Chr(34), "")
            End If

            ' Check for hyphens, and if present, return the part before first one,
            ' unless it is before the extension.
            If value.Contains("-") Then
                p = value.IndexOf("-")
                Dim pDot As Integer = value.IndexOf(".")
                If p > pDot Then
                    value = value.Substring(0, p - 1)
                End If
            End If

            ' Check for forward slashes, and if present, return the part before first one.
            If value.Contains("/") Then
                p = value.IndexOf("/")
                value = value.Substring(0, p - 1)
            End If

            ' Check for a space followed by a percent sign, and if present, return the part before the first one.
            If value.Contains(" %") Then
                p = value.IndexOf(" %")
                value = value.Substring(0, p)
            End If

            If value <> "" Then
                Return Path.GetFullPath(value)
            Else
                Return ""
            End If

        Catch
            Return ""
        End Try

    End Function

#End Region

    Private Function FormatFileSize(ByVal FileSizeBytes As Long) As String
        Dim sizeTypes() As String = {"b", "Kb", "Mb", "Gb"}
        Dim Len As Decimal = FileSizeBytes
        Dim sizeType As Integer = 0
        Do While Len > 1024
            Len = Decimal.Round(Len / 1024, 2)
            sizeType += 1
            If sizeType >= sizeTypes.Length - 1 Then Exit Do
        Loop

        Dim Resp As String = Len.ToString & " " & sizeTypes(sizeType)
        Return Resp
    End Function
    Private Function _IMSS_GetFileType(ByVal _IMSS_FilePath As String) As String
        Select Case _IMSS_FilePath
            Case ".exe"
                Return "Executable applicatin(.exe)"
            Case ".com"
                Return "Command File(.com)"
            Case ".shs"
                Return "Shell Scrap Object(.shs)"
            Case ".PIF"
                Return "Program Information File(.com)"
            Case ".VB"
                Return "VBScript File(.exe)"
            Case ".BAT"
                Return "Batch File(.com)"
            Case ".CMD"
                Return "Command Script(.exe)"
            Case ".SCT"
                Return "Windows Scriptlet(.com)"
            Case ".lnk"
                Return "Windows File Shortcut(.lnk)"
            Case Else
                Return "Unknown extension !"
        End Select
    End Function

    Private Sub _IMSS_MainListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_MainListView.SelectedIndexChanged
        Try
            If _IMSS_MainListView.Items.Count <> -1 Then
                _IMSS_EnableDisableButtons(True)
            Else
                _IMSS_EnableDisableButtons(False)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _IMSS_EnableDisableButtons(ByVal _IMSS_STATUS As Boolean)
        _IMSS_OnlineSearch.Enabled = _IMSS_STATUS
        _IMSS_AddButton.Enabled = _IMSS_STATUS
        _IMSS_EditButton.Enabled = _IMSS_STATUS
        _IMSS_ViewItemButton.Enabled = _IMSS_STATUS
        _IMSS_RunButton.Enabled = _IMSS_STATUS
        _IMSS_ScanInVirusTotal.Enabled = _IMSS_STATUS
        _IMSS_RemoveButton.Enabled = _IMSS_STATUS
    End Sub
   
    Private Sub _IMSS_OrganizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OrganizeButton.Click
        Me.IMSSStartupCleaner_Load(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_RegistryEditor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_RegistryEditor.Click
        Try
            Process.Start("Regedit.exe")
        Catch : End Try
    End Sub
    Private Function _IMSS_CheclListViewItems() As Boolean
        If _IMSS_MainListView.Items.Count > 0 And _IMSS_MainListView.SelectedItems.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub _IMSS_OnlineSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OnlineSearch.Click
        Try
            If _IMSS_CheclListViewItems() = True Then
                If _IMSS_MainListView.SelectedItems(0).Text.Length <> -1 Then
                    Process.Start("https://www.google.com/search?hl=en&q=" & _IMSS_MainListView.SelectedItems(0).Text)
                End If
            End If
        Catch : End Try
    End Sub

    Private Sub _IMSS_RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_RemoveButton.Click
        If _IMSS_CheclListViewItems() = True Then
            If _IMSS_MainListView.SelectedItems(0).Tag.ToString().Split("|")(0) = "_IMSS_REGEDIT" Then
                _IMSS_DeleteFromRegistry(_IMSS_MainListView.SelectedItems(0).Tag.ToString().Split("|")(1), _IMSS_MainListView.SelectedItems(0).SubItems(3).Text)
            Else
                _IMSS_DeleteFromStartupFolder(_IMSS_MainListView.SelectedItems(0).SubItems(2).Text)
            End If : Me.IMSSStartupCleaner_Load(Nothing, Nothing)
        End If
    End Sub
    Private Sub _IMSS_DeleteFromRegistry(ByVal _IMSS_RegistryKey As String, ByVal _IMSS_RegistryPath As String)
        On Error Resume Next
        Dim _IMSS_RegeditKey As RegistryKey = Nothing
        If _IMSS_RegistryPath.Contains("HKEY_LOCAL_MACHINE") Then
            _IMSS_RegeditKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            If Not _IMSS_RegeditKey Is Nothing Then
                _IMSS_RegeditKey.DeleteValue(_IMSS_RegistryKey)
            End If
            _IMSS_RegeditKey.Close()
        Else
            _IMSS_RegeditKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            If Not _IMSS_RegeditKey Is Nothing Then
                _IMSS_RegeditKey.DeleteValue(_IMSS_RegistryKey)
            End If
            _IMSS_RegeditKey.Close()
        End If
    End Sub
    Private Sub _IMSS_DeleteFromStartupFolder(ByVal _IMSS_StartUpTargetPath As String)
        If IO.File.Exists(_IMSS_StartUpTargetPath) = True Then
            Try : IO.File.Delete(_IMSS_StartUpTargetPath) : Catch : End Try
        End If
    End Sub

    Private Sub _IMSS_AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AddButton.Click
        Dim _IMSS_RegistryAdd As New IMSS_RegeditAdd
        _IMSS_RegistryAdd.ShowDialog()
        Me.IMSSStartupCleaner_Load(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_EditButton.Click
        Dim IMSS_Registry_Edit As New IMSS_Regedit_Edit
        IMSS_Registry_Edit.ShowDialog()
        Me.IMSSStartupCleaner_Load(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_ViewItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ViewItemButton.Click
        If _IMSS_CheclListViewItems() = True Then
            _IMSS_ViewApplicationTargert()
        End If
    End Sub

    Private Sub _IMSS_ViewApplicationTargert()
        Try
            If IO.Directory.Exists(Path.GetDirectoryName(_IMSS_MainListView.SelectedItems(0).SubItems(2).Text)) Then Process.Start(Path.GetDirectoryName(_IMSS_MainListView.SelectedItems(0).SubItems(2).Text))
        Catch : End Try
    End Sub

    Private Sub _IMSS_RunButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_RunButton.Click
        If _IMSS_CheclListViewItems() = True Then
            _IMSS_RunApplicationTargert()
        End If
    End Sub
    Private Sub _IMSS_RunApplicationTargert()
        Try
            If IO.File.Exists(_IMSS_MainListView.SelectedItems(0).SubItems(2).Text) Then Process.Start(_IMSS_MainListView.SelectedItems(0).SubItems(2).Text)
        Catch : End Try
    End Sub

    Private Sub _IMSS_ScanInVirusTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ScanInVirusTotal.Click
        If _IMSS_CheclListViewItems() = True Then
            _IMSS_ViurusTotalUploaderPath = _IMSS_MainListView.SelectedItems(0).SubItems(2).Text()
            Dim IMSS_VaurisTotalScanner As New IMSS_VaurisTotalScanner
            IMSS_VaurisTotalScanner.Show()
        End If
    End Sub

    Private Sub _IMSS_ContextRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ContextRun.Click
        _IMSS_RunButton_Click(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_ContextAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ContextAdd.Click
        _IMSS_AddButton_Click(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_ContextEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ContextEdit.Click
        _IMSS_EditButton_Click(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_ContextView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ContextView.Click
        _IMSS_ViewItemButton_Click(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_ContextRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ContextRemove.Click
        _IMSS_RemoveButton_Click(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_ContextRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ContextRefresh.Click
        Me.IMSSStartupCleaner_Load(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_ContextRegedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ContextRegedit.Click
        _IMSS_RegistryEditor_Click(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_ContextOnlineSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ContextOnlineSearch.Click
        _IMSS_OnlineSearch_Click(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_Context_ScanInVirusTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Context_ScanInVirusTotal.Click
        _IMSS_ScanInVirusTotal_Click(Nothing, Nothing)
    End Sub
End Class
