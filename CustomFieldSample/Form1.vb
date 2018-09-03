Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraScheduler


Public Class Form1
	 Sub New()
		  InitSkins()
		  InitializeComponent()
		  Me.InitSkinGallery()
		  schedulerControl.Start = DateTime.Now
	 End Sub
	 Sub InitSkins()
		  DevExpress.Skins.SkinManager.EnableFormSkins()
		  DevExpress.UserSkins.BonusSkins.Register()

	 End Sub
	 Private Sub InitSkinGallery()
		  SkinHelper.InitSkinGallery(rgbiSkins, True)
	 End Sub

	 Private Sub schedulerControl_Click(sender As Object, e As EventArgs) Handles schedulerControl.Click

	 End Sub
End Class
