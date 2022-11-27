Public Class frmAbout
	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Process.Start(String.Format("mailto:{0}", "Chris.DePaul@allstate.com"))
	End Sub
End Class