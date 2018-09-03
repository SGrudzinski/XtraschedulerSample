Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraScheduler
Imports System.Data.Entity

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
	 Dim db As CalendarDB
	 Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		  db = New CalendarDB

		  db.Appointments.Load
		  db.Resources.Load

		  If db.Resources.Local.Count = 0 Then
				db.Resources.Add(New EFResource With {.ResourceName = "Default", .ResourceID = 1})
				db.Resources.Add(New EFResource With {.ResourceName = "Custom", .ResourceID = 2})
		  End If

		  AppointmentBindingSource.DataSource = db.Appointments.Local.ToBindingList
		  ResourceBindingSource.DataSource = db.Resources.Local.ToBindingList
	 End Sub

	 Private Sub schedulerStorage_AppointmentsChanged(sender As Object, e As PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentsChanged, schedulerStorage.AppointmentsInserted, schedulerStorage.AppointmentsDeleted

		  db.SaveChanges()
	 End Sub

	 Private Sub schedulerControl_InitNewAppointment(sender As Object, e As AppointmentEventArgs) Handles schedulerControl.InitNewAppointment

	 End Sub
End Class
