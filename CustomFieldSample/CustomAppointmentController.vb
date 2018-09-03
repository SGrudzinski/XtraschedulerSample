Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI

Public Class CustomAppointmentController
	 Inherits AppointmentFormController

	 Public Property Department() As String
		  Get
				Dim tmp As Object = EditedAppointmentCopy.CustomFields("Department")

				If tmp Is Nothing OrElse tmp Is DBNull.Value Then
					 Return "IT"
				Else
					 Return tmp
				End If
		  End Get
		  Set(ByVal value As String)
				EditedAppointmentCopy.CustomFields("Department") = value
		  End Set
	 End Property

	 Private Property SourceDepartment() As String
		  Get
				Return CStr(SourceAppointment.CustomFields("Department"))
		  End Get
		  Set(ByVal value As String)
				SourceAppointment.CustomFields("Department") = value
		  End Set
	 End Property

	 Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
		  MyBase.New(control, apt)
	 End Sub

	 Public Overrides Function IsAppointmentChanged() As Boolean
		  If MyBase.IsAppointmentChanged() Then
				Return True
		  End If
		  Return SourceDepartment <> Department
	 End Function

	 Protected Overrides Sub ApplyCustomFieldsValues()
		  SourceDepartment = Department
	 End Sub

End Class
