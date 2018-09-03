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

	 Private Sub schedulerControl_EditAppointmentFormShowing(sender As Object, e As AppointmentFormEventArgs) Handles schedulerControl.EditAppointmentFormShowing
		  Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
		  Using form As CustomFieldSample.OutlookAppointmentForm = New CustomFieldSample.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm)
				Try
					 e.DialogResult = form.ShowDialog
					 e.Handled = True
				Catch ex As Exception
				End Try
		  End Using



	 End Sub
End Class
