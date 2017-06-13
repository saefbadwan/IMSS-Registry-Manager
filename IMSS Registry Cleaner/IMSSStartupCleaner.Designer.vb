<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSSStartupCleaner
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSSStartupCleaner))
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me._IMSS_ToolsBar = New DevComponents.DotNetBar.Bar()
        Me._IMSS_OrganizeButton = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_RegistryEditor = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_OnlineSearch = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_RemoveButton = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_AddButton = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_EditButton = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_ViewItemButton = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_RunButton = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_ScanInVirusTotal = New DevComponents.DotNetBar.ButtonItem()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.Bar2 = New DevComponents.DotNetBar.Bar()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_ContextRun = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_ContextAdd = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_ContextEdit = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_ContextView = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_ContextRemove = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_ContextRefresh = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_ContextRegedit = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_ContextOnlineSearch = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_Context_ScanInVirusTotal = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_MainListView = New ComponentOwl.BetterListView.BetterListView()
        Me.BetterListViewColumnHeader1 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader4 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader5 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader6 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxItem1 = New DevComponents.DotNetBar.TextBoxItem()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.DockSite7.SuspendLayout()
        CType(Me._IMSS_ToolsBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_MainListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me.DotNetBarManager1.BottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.EnableFullSizeDock = False
        Me.DotNetBarManager1.LeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.DockSite2
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite8
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite5
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite6
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite7
        Me.DotNetBarManager1.TopDockSite = Me.DockSite3
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite4.Location = New System.Drawing.Point(0, 531)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(1128, 0)
        Me.DockSite4.TabIndex = 3
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 34)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 497)
        Me.DockSite1.TabIndex = 0
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(1128, 34)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 497)
        Me.DockSite2.TabIndex = 1
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 531)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(1128, 0)
        Me.DockSite8.TabIndex = 7
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 34)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 497)
        Me.DockSite5.TabIndex = 4
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(1128, 34)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 497)
        Me.DockSite6.TabIndex = 5
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.DockSite7.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DockSite7.Controls.Add(Me._IMSS_ToolsBar)
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(1128, 34)
        Me.DockSite7.TabIndex = 6
        Me.DockSite7.TabStop = False
        '
        '_IMSS_ToolsBar
        '
        Me._IMSS_ToolsBar.AccessibleDescription = "DotNetBar Bar (_IMSS_ToolsBar)"
        Me._IMSS_ToolsBar.AccessibleName = "DotNetBar Bar"
        Me._IMSS_ToolsBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me._IMSS_ToolsBar.Dock = System.Windows.Forms.DockStyle.Top
        Me._IMSS_ToolsBar.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me._IMSS_ToolsBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me._IMSS_ToolsBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me._IMSS_ToolsBar.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_OrganizeButton, Me._IMSS_RegistryEditor, Me._IMSS_OnlineSearch, Me._IMSS_RemoveButton, Me._IMSS_AddButton, Me._IMSS_EditButton, Me._IMSS_ViewItemButton, Me._IMSS_RunButton, Me._IMSS_ScanInVirusTotal})
        Me._IMSS_ToolsBar.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_ToolsBar.Name = "_IMSS_ToolsBar"
        Me._IMSS_ToolsBar.Size = New System.Drawing.Size(1128, 33)
        Me._IMSS_ToolsBar.Stretch = True
        Me._IMSS_ToolsBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me._IMSS_ToolsBar.TabIndex = 0
        Me._IMSS_ToolsBar.TabStop = False
        Me._IMSS_ToolsBar.Text = "Tools Bar"
        '
        '_IMSS_OrganizeButton
        '
        Me._IMSS_OrganizeButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_OrganizeButton.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources.ico_alpha_Refresh_24x24
        Me._IMSS_OrganizeButton.Name = "_IMSS_OrganizeButton"
        Me._IMSS_OrganizeButton.Text = "&Refresh"
        '
        '_IMSS_RegistryEditor
        '
        Me._IMSS_RegistryEditor.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_RegistryEditor.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources._IMSS__alpha_RegistryEditor_Icon_24x24
        Me._IMSS_RegistryEditor.Name = "_IMSS_RegistryEditor"
        Me._IMSS_RegistryEditor.Text = "Registry editor"
        '
        '_IMSS_OnlineSearch
        '
        Me._IMSS_OnlineSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_OnlineSearch.Enabled = False
        Me._IMSS_OnlineSearch.Image = CType(resources.GetObject("_IMSS_OnlineSearch.Image"), System.Drawing.Image)
        Me._IMSS_OnlineSearch.Name = "_IMSS_OnlineSearch"
        Me._IMSS_OnlineSearch.Text = "Online search"
        '
        '_IMSS_RemoveButton
        '
        Me._IMSS_RemoveButton.BeginGroup = True
        Me._IMSS_RemoveButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_RemoveButton.Enabled = False
        Me._IMSS_RemoveButton.Image = CType(resources.GetObject("_IMSS_RemoveButton.Image"), System.Drawing.Image)
        Me._IMSS_RemoveButton.Name = "_IMSS_RemoveButton"
        Me._IMSS_RemoveButton.Text = "Remove"
        '
        '_IMSS_AddButton
        '
        Me._IMSS_AddButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_AddButton.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources._IMSS_StartUpManager_AddIcon_24x24
        Me._IMSS_AddButton.Name = "_IMSS_AddButton"
        Me._IMSS_AddButton.Text = "&Add"
        '
        '_IMSS_EditButton
        '
        Me._IMSS_EditButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_EditButton.Enabled = False
        Me._IMSS_EditButton.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources._IMSS_StartUpManager_EditIcon_24x24
        Me._IMSS_EditButton.Name = "_IMSS_EditButton"
        Me._IMSS_EditButton.Text = "Edit"
        '
        '_IMSS_ViewItemButton
        '
        Me._IMSS_ViewItemButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_ViewItemButton.Enabled = False
        Me._IMSS_ViewItemButton.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources._IMSS_StartUpManager_ViewIcon_24x24
        Me._IMSS_ViewItemButton.Name = "_IMSS_ViewItemButton"
        Me._IMSS_ViewItemButton.Text = "View Item"
        '
        '_IMSS_RunButton
        '
        Me._IMSS_RunButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_RunButton.Enabled = False
        Me._IMSS_RunButton.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources._IMSS_StartUpManager_RunIcon_24x24
        Me._IMSS_RunButton.Name = "_IMSS_RunButton"
        Me._IMSS_RunButton.Text = "Run"
        '
        '_IMSS_ScanInVirusTotal
        '
        Me._IMSS_ScanInVirusTotal.BeginGroup = True
        Me._IMSS_ScanInVirusTotal.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_ScanInVirusTotal.Enabled = False
        Me._IMSS_ScanInVirusTotal.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources.ico_alpha_Search_24x24
        Me._IMSS_ScanInVirusTotal.Name = "_IMSS_ScanInVirusTotal"
        Me._IMSS_ScanInVirusTotal.Text = "Scan in <b>VirusTotal</b>"
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(0, 34)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(1128, 0)
        Me.DockSite3.TabIndex = 2
        Me.DockSite3.TabStop = False
        '
        'Bar2
        '
        Me.Bar2.AccessibleDescription = "DotNetBar Bar (Bar2)"
        Me.Bar2.AccessibleName = "DotNetBar Bar"
        Me.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar
        Me.Bar2.AntiAlias = True
        Me.Bar2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle
        Me.Bar2.Location = New System.Drawing.Point(0, 506)
        Me.Bar2.Name = "Bar2"
        Me.Bar2.Size = New System.Drawing.Size(1128, 25)
        Me.Bar2.Stretch = True
        Me.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar2.TabIndex = 8
        Me.Bar2.TabStop = False
        Me.Bar2.Text = "Bar2"
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 33)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1128, 473)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.PanelEx1.Style.BorderWidth = 2
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 9
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.ContextMenuBar1)
        Me.PanelEx2.Controls.Add(Me._IMSS_MainListView)
        Me.PanelEx2.Controls.Add(Me.PanelEx3)
        Me.PanelEx2.Location = New System.Drawing.Point(6, 6)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1119, 461)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem5})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(629, 185)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(126, 25)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ContextMenuBar1.TabIndex = 10
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.AutoExpandOnClick = True
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_ContextRun, Me._IMSS_ContextAdd, Me._IMSS_ContextEdit, Me._IMSS_ContextView, Me._IMSS_ContextRemove, Me._IMSS_ContextRefresh, Me._IMSS_ContextRegedit, Me._IMSS_ContextOnlineSearch, Me._IMSS_Context_ScanInVirusTotal})
        Me.ButtonItem5.Text = "ButtonItem5"
        '
        '_IMSS_ContextRun
        '
        Me._IMSS_ContextRun.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources._IMSS_Run
        Me._IMSS_ContextRun.Name = "_IMSS_ContextRun"
        Me._IMSS_ContextRun.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlEnter)
        Me._IMSS_ContextRun.ShowSubItems = False
        Me._IMSS_ContextRun.Text = "Run"
        '
        '_IMSS_ContextAdd
        '
        Me._IMSS_ContextAdd.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources._IMSS_RegeditAdd_MainIcon_16x16
        Me._IMSS_ContextAdd.Name = "_IMSS_ContextAdd"
        Me._IMSS_ContextAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me._IMSS_ContextAdd.ShowSubItems = False
        Me._IMSS_ContextAdd.Text = "Add"
        '
        '_IMSS_ContextEdit
        '
        Me._IMSS_ContextEdit.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources._IMSS_Edit_Icon_16x16
        Me._IMSS_ContextEdit.Name = "_IMSS_ContextEdit"
        Me._IMSS_ContextEdit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE)
        Me._IMSS_ContextEdit.Text = "Edit"
        '
        '_IMSS_ContextView
        '
        Me._IMSS_ContextView.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources._IMSS_View_Icon_16x16
        Me._IMSS_ContextView.Name = "_IMSS_ContextView"
        Me._IMSS_ContextView.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me._IMSS_ContextView.Text = "View"
        '
        '_IMSS_ContextRemove
        '
        Me._IMSS_ContextRemove.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources.ico_alpha_Delete_16x16
        Me._IMSS_ContextRemove.Name = "_IMSS_ContextRemove"
        Me._IMSS_ContextRemove.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlR)
        Me._IMSS_ContextRemove.Text = "Remove"
        '
        '_IMSS_ContextRefresh
        '
        Me._IMSS_ContextRefresh.BeginGroup = True
        Me._IMSS_ContextRefresh.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources._IMSS_Refresh_Icon_16x16
        Me._IMSS_ContextRefresh.Name = "_IMSS_ContextRefresh"
        Me._IMSS_ContextRefresh.Text = "Refresh"
        '
        '_IMSS_ContextRegedit
        '
        Me._IMSS_ContextRegedit.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources.Registry_Defrag_16x16
        Me._IMSS_ContextRegedit.Name = "_IMSS_ContextRegedit"
        Me._IMSS_ContextRegedit.Text = "Registry Editor"
        '
        '_IMSS_ContextOnlineSearch
        '
        Me._IMSS_ContextOnlineSearch.BeginGroup = True
        Me._IMSS_ContextOnlineSearch.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources.ico_alpha_browser_settings_16x16
        Me._IMSS_ContextOnlineSearch.Name = "_IMSS_ContextOnlineSearch"
        Me._IMSS_ContextOnlineSearch.Text = "Online Search"
        '
        '_IMSS_Context_ScanInVirusTotal
        '
        Me._IMSS_Context_ScanInVirusTotal.Image = Global.IMSS_StartUp_Manager.My.Resources.Resources.ico_alpha_InternetCache_16x16
        Me._IMSS_Context_ScanInVirusTotal.Name = "_IMSS_Context_ScanInVirusTotal"
        Me._IMSS_Context_ScanInVirusTotal.Text = "Scan in <b>VirusTotal</b>"
        '
        '_IMSS_MainListView
        '
        Me._IMSS_MainListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_MainListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._IMSS_MainListView.Columns.AddRange(New Object() {Me.BetterListViewColumnHeader1, Me.BetterListViewColumnHeader4, Me.BetterListViewColumnHeader5, Me.BetterListViewColumnHeader6})
        Me.ContextMenuBar1.SetContextMenuEx(Me._IMSS_MainListView, Me.ButtonItem5)
        Me._IMSS_MainListView.ForeColor = System.Drawing.Color.Black
        Me._IMSS_MainListView.GridLines = ComponentOwl.BetterListView.BetterListViewGridLines.Horizontal
        Me._IMSS_MainListView.GroupHeaderBehavior = ComponentOwl.BetterListView.BetterListViewGroupHeaderBehavior.MouseSelect
        Me._IMSS_MainListView.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_MainListView.Location = New System.Drawing.Point(2, 29)
        Me._IMSS_MainListView.Name = "_IMSS_MainListView"
        Me._IMSS_MainListView.Size = New System.Drawing.Size(1115, 430)
        Me._IMSS_MainListView.TabIndex = 2
        '
        'BetterListViewColumnHeader1
        '
        Me.BetterListViewColumnHeader1.Name = "BetterListViewColumnHeader1"
        Me.BetterListViewColumnHeader1.Text = "Name"
        Me.BetterListViewColumnHeader1.Width = 189
        '
        'BetterListViewColumnHeader4
        '
        Me.BetterListViewColumnHeader4.Name = "BetterListViewColumnHeader4"
        Me.BetterListViewColumnHeader4.Text = "Run type"
        Me.BetterListViewColumnHeader4.Width = 163
        '
        'BetterListViewColumnHeader5
        '
        Me.BetterListViewColumnHeader5.Name = "BetterListViewColumnHeader5"
        Me.BetterListViewColumnHeader5.Text = "Path"
        Me.BetterListViewColumnHeader5.Width = 210
        '
        'BetterListViewColumnHeader6
        '
        Me.BetterListViewColumnHeader6.Name = "BetterListViewColumnHeader6"
        Me.BetterListViewColumnHeader6.Text = "Registry Path"
        Me.BetterListViewColumnHeader6.Width = 516
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.ButtonX1)
        Me.PanelEx3.Controls.Add(Me.LabelX1)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1119, 29)
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 1
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.Location = New System.Drawing.Point(1014, 3)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(102, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.TextBoxItem1})
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "Search Items"
        '
        'TextBoxItem1
        '
        Me.TextBoxItem1.GlobalItem = False
        Me.TextBoxItem1.Name = "TextBoxItem1"
        Me.TextBoxItem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBoxItem1.TextBoxWidth = 140
        Me.TextBoxItem1.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelX1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(0, 0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(283, 29)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "  All Satrtup Programs Settings"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX2.Location = New System.Drawing.Point(3, 2)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 28)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 1
        Me.ButtonX2.Text = "ButtonX2"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "ButtonItem2"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "ButtonItem3"
        '
        'IMSSStartupCleaner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 531)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.Bar2)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "IMSSStartupCleaner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS StartUp Manager"
        Me.DockSite7.ResumeLayout(False)
        CType(Me._IMSS_ToolsBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_MainListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar2 As DevComponents.DotNetBar.Bar
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents _IMSS_ToolsBar As DevComponents.DotNetBar.Bar
    Friend WithEvents _IMSS_OrganizeButton As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_OnlineSearch As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_AddButton As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_EditButton As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_ViewItemButton As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_RunButton As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_ScanInVirusTotal As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxItem1 As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents _IMSS_MainListView As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents BetterListViewColumnHeader1 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader4 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader5 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_RegistryEditor As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_RemoveButton As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BetterListViewColumnHeader6 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_ContextRun As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_ContextAdd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_ContextRemove As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_ContextEdit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_ContextView As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_ContextRefresh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_ContextRegedit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_ContextOnlineSearch As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_Context_ScanInVirusTotal As DevComponents.DotNetBar.ButtonItem

End Class
