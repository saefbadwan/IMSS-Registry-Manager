<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_RegeditAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_RegeditAdd))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Ok_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_Cancel_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_Section_ComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me._IMSS_Section_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_GroupItems = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me._IMSS_Path_RichTextBoxEx = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_ButtonX = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_Arguments_TextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_Name_TextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_Arguments_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Path_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Name_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_GroupItems.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Ok_Button)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Cancel_Button)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Section_ComboBox)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Section_Label)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_GroupItems)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(329, 173)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.BorderWidth = 0
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        '_IMSS_Ok_Button
        '
        Me._IMSS_Ok_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Ok_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Ok_Button.Location = New System.Drawing.Point(170, 149)
        Me._IMSS_Ok_Button.Name = "_IMSS_Ok_Button"
        Me._IMSS_Ok_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Ok_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Ok_Button.TabIndex = 4
        Me._IMSS_Ok_Button.Text = "&OK"
        '
        '_IMSS_Cancel_Button
        '
        Me._IMSS_Cancel_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Cancel_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Cancel_Button.Location = New System.Drawing.Point(251, 149)
        Me._IMSS_Cancel_Button.Name = "_IMSS_Cancel_Button"
        Me._IMSS_Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Cancel_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Cancel_Button.TabIndex = 3
        Me._IMSS_Cancel_Button.Text = "&Cancel"
        '
        '_IMSS_Section_ComboBox
        '
        Me._IMSS_Section_ComboBox.AutoCompleteCustomSource.AddRange(New String() {"StartUp\All Users", "StartUp\Current User", "Registry\All Users\Run", "Registry\All Users\Run Once", "Registry\All Users\Run Services", "Registry\All Users\Run Services Once", "Registry\Current User\Run", "Registry\Current User\Run Once", "Registry\Current User\Run Services", "Registry\Current User\Run Services Once"})
        Me._IMSS_Section_ComboBox.DisplayMember = "Text"
        Me._IMSS_Section_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me._IMSS_Section_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._IMSS_Section_ComboBox.FormattingEnabled = True
        Me._IMSS_Section_ComboBox.ItemHeight = 14
        Me._IMSS_Section_ComboBox.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8, Me.ComboItem9, Me.ComboItem10})
        Me._IMSS_Section_ComboBox.Location = New System.Drawing.Point(61, 6)
        Me._IMSS_Section_ComboBox.Name = "_IMSS_Section_ComboBox"
        Me._IMSS_Section_ComboBox.Size = New System.Drawing.Size(256, 20)
        Me._IMSS_Section_ComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Section_ComboBox.TabIndex = 2
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "StartUp\All Users"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "StartUp\Current User"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Registry\All Users\Run"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Registry\All Users\Run Once"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Registry\All Users\BootExecute"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Registry\All Users\StartupPrograms"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Registry\Current User\Run"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Registry\Current User\Run Once"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Registry\All Users\Shell"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "Registry\All Usersr\Userinit"
        '
        '_IMSS_Section_Label
        '
        '
        '
        '
        Me._IMSS_Section_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Section_Label.Location = New System.Drawing.Point(4, 4)
        Me._IMSS_Section_Label.Name = "_IMSS_Section_Label"
        Me._IMSS_Section_Label.Size = New System.Drawing.Size(51, 23)
        Me._IMSS_Section_Label.TabIndex = 1
        Me._IMSS_Section_Label.Text = "Section :"
        '
        '_IMSS_GroupItems
        '
        Me._IMSS_GroupItems.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_GroupItems.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me._IMSS_GroupItems.Controls.Add(Me._IMSS_Path_RichTextBoxEx)
        Me._IMSS_GroupItems.Controls.Add(Me._IMSS_ButtonX)
        Me._IMSS_GroupItems.Controls.Add(Me._IMSS_Arguments_TextBoxX)
        Me._IMSS_GroupItems.Controls.Add(Me._IMSS_Name_TextBoxX)
        Me._IMSS_GroupItems.Controls.Add(Me._IMSS_Arguments_Label)
        Me._IMSS_GroupItems.Controls.Add(Me._IMSS_Path_Label)
        Me._IMSS_GroupItems.Controls.Add(Me._IMSS_Name_Label)
        Me._IMSS_GroupItems.Location = New System.Drawing.Point(3, 33)
        Me._IMSS_GroupItems.Name = "_IMSS_GroupItems"
        Me._IMSS_GroupItems.Size = New System.Drawing.Size(323, 114)
        '
        '
        '
        Me._IMSS_GroupItems.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_GroupItems.Style.BackColorGradientAngle = 90
        Me._IMSS_GroupItems.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_GroupItems.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me._IMSS_GroupItems.Style.BorderBottomWidth = 1
        Me._IMSS_GroupItems.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_GroupItems.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me._IMSS_GroupItems.Style.BorderLeftWidth = 1
        Me._IMSS_GroupItems.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me._IMSS_GroupItems.Style.BorderRightWidth = 1
        Me._IMSS_GroupItems.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me._IMSS_GroupItems.Style.BorderTopWidth = 1
        Me._IMSS_GroupItems.Style.CornerDiameter = 4
        Me._IMSS_GroupItems.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me._IMSS_GroupItems.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me._IMSS_GroupItems.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_GroupItems.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me._IMSS_GroupItems.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me._IMSS_GroupItems.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_GroupItems.TabIndex = 0
        Me._IMSS_GroupItems.Text = "Name And Path"
        '
        '_IMSS_Path_RichTextBoxEx
        '
        '
        '
        '
        Me._IMSS_Path_RichTextBoxEx.Border.Class = "TextBoxBorder"
        Me._IMSS_Path_RichTextBoxEx.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Path_RichTextBoxEx.Location = New System.Drawing.Point(76, 39)
        Me._IMSS_Path_RichTextBoxEx.Name = "_IMSS_Path_RichTextBoxEx"
        Me._IMSS_Path_RichTextBoxEx.ReadOnly = True
        Me._IMSS_Path_RichTextBoxEx.Size = New System.Drawing.Size(154, 20)
        Me._IMSS_Path_RichTextBoxEx.TabIndex = 9
        '
        '_IMSS_ButtonX
        '
        Me._IMSS_ButtonX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_ButtonX.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_ButtonX.Location = New System.Drawing.Point(236, 38)
        Me._IMSS_ButtonX.Name = "_IMSS_ButtonX"
        Me._IMSS_ButtonX.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_ButtonX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ButtonX.TabIndex = 8
        Me._IMSS_ButtonX.Text = "Browse"
        '
        '_IMSS_Arguments_TextBoxX
        '
        '
        '
        '
        Me._IMSS_Arguments_TextBoxX.Border.Class = "TextBoxBorder"
        Me._IMSS_Arguments_TextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Arguments_TextBoxX.Location = New System.Drawing.Point(76, 72)
        Me._IMSS_Arguments_TextBoxX.Name = "_IMSS_Arguments_TextBoxX"
        Me._IMSS_Arguments_TextBoxX.Size = New System.Drawing.Size(235, 20)
        Me._IMSS_Arguments_TextBoxX.TabIndex = 7
        '
        '_IMSS_Name_TextBoxX
        '
        '
        '
        '
        Me._IMSS_Name_TextBoxX.Border.Class = "TextBoxBorder"
        Me._IMSS_Name_TextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Name_TextBoxX.Location = New System.Drawing.Point(76, 7)
        Me._IMSS_Name_TextBoxX.Name = "_IMSS_Name_TextBoxX"
        Me._IMSS_Name_TextBoxX.Size = New System.Drawing.Size(235, 20)
        Me._IMSS_Name_TextBoxX.TabIndex = 5
        '
        '_IMSS_Arguments_Label
        '
        '
        '
        '
        Me._IMSS_Arguments_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Arguments_Label.Location = New System.Drawing.Point(6, 72)
        Me._IMSS_Arguments_Label.Name = "_IMSS_Arguments_Label"
        Me._IMSS_Arguments_Label.Size = New System.Drawing.Size(63, 23)
        Me._IMSS_Arguments_Label.TabIndex = 4
        Me._IMSS_Arguments_Label.Text = "Arguments :"
        '
        '_IMSS_Path_Label
        '
        '
        '
        '
        Me._IMSS_Path_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Path_Label.Location = New System.Drawing.Point(6, 36)
        Me._IMSS_Path_Label.Name = "_IMSS_Path_Label"
        Me._IMSS_Path_Label.Size = New System.Drawing.Size(63, 23)
        Me._IMSS_Path_Label.TabIndex = 3
        Me._IMSS_Path_Label.Text = "File Path :"
        '
        '_IMSS_Name_Label
        '
        '
        '
        '
        Me._IMSS_Name_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Name_Label.Location = New System.Drawing.Point(6, 5)
        Me._IMSS_Name_Label.Name = "_IMSS_Name_Label"
        Me._IMSS_Name_Label.Size = New System.Drawing.Size(63, 23)
        Me._IMSS_Name_Label.TabIndex = 2
        Me._IMSS_Name_Label.Text = "Name :"
        '
        '_IMSS_OpenFileDialog
        '
        Me._IMSS_OpenFileDialog.Filter = "Applications (*.exe)|*.exe|All Files (*.*)|*.*"
        '
        'IMSS_RegeditAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 173)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(345, 211)
        Me.MinimumSize = New System.Drawing.Size(345, 211)
        Me.Name = "IMSS_RegeditAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registry Run Add Value"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_GroupItems.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_GroupItems As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents _IMSS_Section_ComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents _IMSS_Section_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Name_TextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents _IMSS_Arguments_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Path_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Name_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Arguments_TextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents _IMSS_ButtonX As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents _IMSS_Path_RichTextBoxEx As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents _IMSS_Ok_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_Cancel_Button As DevComponents.DotNetBar.ButtonX
End Class
