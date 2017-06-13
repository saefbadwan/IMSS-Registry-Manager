Public Class IMSS_VaurisTotalScanner
    Private _IMSS_VirusTotalClass As New IMSS_VirusTotal

    Private Sub IMSS_VaurisTotalScanner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Control.CheckForIllegalCrossThreadCalls = False
        If Not _IMSS_ViurusTotalUploaderPath = "none" Then
            Dim _IMSS_StartsWebBrowser As New Threading.Thread(AddressOf _IMSS_WebBrowser)
            _IMSS_StartsWebBrowser.Start()
        Else
            WebBrowser1.Stop()
            WebBrowser1.Dispose()
            Me.Close()
        End If
    End Sub
    Private Sub _IMSS_WebBrowser()
        On Error Resume Next
        WebBrowser1.Navigate(_IMSS_VirusTotalClass.checkFile(_IMSS_ViurusTotalUploaderPath))
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        On Error Resume Next
        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            _IMSS_LoadingImage.Enabled = False
            _IMSS_LoadingPanel.Visible = False
            Me.Text = "IMSS Virus Total Scanner (...)"
        End If
    End Sub
End Class