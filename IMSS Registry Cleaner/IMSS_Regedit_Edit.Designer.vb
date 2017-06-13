<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_Regedit_Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_Regedit_Edit))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_EditStartUpEntriy = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me._IMSS_Path_RichTextBoxEx = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_ButtonX = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_Name_TextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_Path_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Name_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Ok_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_Cancel_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_EditStartUpEntriy.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Ok_Button)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Cancel_Button)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_EditStartUpEntriy)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(273, 131)
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
        '_IMSS_EditStartUpEntriy
        '
        Me._IMSS_EditStartUpEntriy.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_EditStartUpEntriy.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me._IMSS_EditStartUpEntriy.Controls.Add(Me._IMSS_Path_RichTextBoxEx)
        Me._IMSS_EditStartUpEntriy.Controls.Add(Me._IMSS_ButtonX)
        Me._IMSS_EditStartUpEntriy.Controls.Add(Me._IMSS_Name_TextBoxX)
        Me._IMSS_EditStartUpEntriy.Controls.Add(Me._IMSS_Path_Label)
        Me._IMSS_EditStartUpEntriy.Controls.Add(Me._IMSS_Name_Label)
        Me._IMSS_EditStartUpEntriy.Location = New System.Drawing.Point(4, 4)
        Me._IMSS_EditStartUpEntriy.Name = "_IMSS_EditStartUpEntriy"
        Me._IMSS_EditStartUpEntriy.Size = New System.Drawing.Size(265, 96)
        '
        '
        '
        Me._IMSS_EditStartUpEntriy.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_EditStartUpEntriy.Style.BackColorGradientAngle = 90
        Me._IMSS_EditStartUpEntriy.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_EditStartUpEntriy.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me._IMSS_EditStartUpEntriy.Style.BorderBottomWidth = 1
        Me._IMSS_EditStartUpEntriy.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_EditStartUpEntriy.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me._IMSS_EditStartUpEntriy.Style.BorderLeftWidth = 1
        Me._IMSS_EditStartUpEntriy.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me._IMSS_EditStartUpEntriy.Style.BorderRightWidth = 1
        Me._IMSS_EditStartUpEntriy.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me._IMSS_EditStartUpEntriy.Style.BorderTopWidth = 1
        Me._IMSS_EditStartUpEntriy.Style.CornerDiameter = 4
        Me._IMSS_EditStartUpEntriy.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me._IMSS_EditStartUpEntriy.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me._IMSS_EditStartUpEntriy.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_EditStartUpEntriy.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me._IMSS_EditStartUpEntriy.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me._IMSS_EditStartUpEntriy.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_EditStartUpEntriy.TabIndex = 0
        Me._IMSS_EditStartUpEntriy.Text = "Edit Startup Entry"
        '
        '_IMSS_Path_RichTextBoxEx
        '
        '
        '
        '
        Me._IMSS_Path_RichTextBoxEx.Border.Class = "TextBoxBorder"
        Me._IMSS_Path_RichTextBoxEx.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Path_RichTextBoxEx.Location = New System.Drawing.Point(65, 43)
        Me._IMSS_Path_RichTextBoxEx.Name = "_IMSS_Path_RichTextBoxEx"
        Me._IMSS_Path_RichTextBoxEx.ReadOnly = True
        Me._IMSS_Path_RichTextBoxEx.Size = New System.Drawing.Size(109, 20)
        Me._IMSS_Path_RichTextBoxEx.TabIndex = 14
        '
        '_IMSS_ButtonX
        '
        Me._IMSS_ButtonX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_ButtonX.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_ButtonX.Location = New System.Drawing.Point(180, 42)
        Me._IMSS_ButtonX.Name = "_IMSS_ButtonX"
        Me._IMSS_ButtonX.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_ButtonX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ButtonX.TabIndex = 13
        Me._IMSS_ButtonX.Text = "Browse"
        '
        '_IMSS_Name_TextBoxX
        '
        '
        '
        '
        Me._IMSS_Name_TextBoxX.Border.Class = "TextBoxBorder"
        Me._IMSS_Name_TextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Name_TextBoxX.Location = New System.Drawing.Point(65, 12)
        Me._IMSS_Name_TextBoxX.Name = "_IMSS_Name_TextBoxX"
        Me._IMSS_Name_TextBoxX.Size = New System.Drawing.Size(190, 20)
        Me._IMSS_Name_TextBoxX.TabIndex = 12
        '
        '_IMSS_Path_Label
        '
        '
        '
        '
        Me._IMSS_Path_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Path_Label.Location = New System.Drawing.Point(1, 40)
        Me._IMSS_Path_Label.Name = "_IMSS_Path_Label"
        Me._IMSS_Path_Label.Size = New System.Drawing.Size(63, 23)
        Me._IMSS_Path_Label.TabIndex = 11
        Me._IMSS_Path_Label.Text = "File Path :"
        '
        '_IMSS_Name_Label
        '
        '
        '
        '
        Me._IMSS_Name_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Name_Label.Location = New System.Drawing.Point(2, 9)
        Me._IMSS_Name_Label.Name = "_IMSS_Name_Label"
        Me._IMSS_Name_Label.Size = New System.Drawing.Size(63, 23)
        Me._IMSS_Name_Label.TabIndex = 10
        Me._IMSS_Name_Label.Text = "Arguments :"
        '
        '_IMSS_Ok_Button
        '
        Me._IMSS_Ok_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Ok_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Ok_Button.Location = New System.Drawing.Point(111, 106)
        Me._IMSS_Ok_Button.Name = "_IMSS_Ok_Button"
        Me._IMSS_Ok_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Ok_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Ok_Button.TabIndex = 6
        Me._IMSS_Ok_Button.Text = "&OK"
        '
        '_IMSS_Cancel_Button
        '
        Me._IMSS_Cancel_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Cancel_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Cancel_Button.Location = New System.Drawing.Point(192, 106)
        Me._IMSS_Cancel_Button.Name = "_IMSS_Cancel_Button"
        Me._IMSS_Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Cancel_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Cancel_Button.TabIndex = 5
        Me._IMSS_Cancel_Button.Text = "&Cancel"
        '
        '_IMSS_OpenFileDialog
        '
        Me._IMSS_OpenFileDialog.Filter = "Applications (*.exe)|*.exe|All Files (*.*)|*.*"
        '
        'IMSS_Regedit_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 131)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(289, 169)
        Me.MinimumSize = New System.Drawing.Size(289, 169)
        Me.Name = "IMSS_Regedit_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registry Edit Value"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_EditStartUpEntriy.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_EditStartUpEntriy As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents _IMSS_Path_RichTextBoxEx As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents _IMSS_ButtonX As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_Name_TextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents _IMSS_Path_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Name_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Ok_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_Cancel_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_OpenFileDialog As System.Windows.Forms.OpenFileDialog
End Class
