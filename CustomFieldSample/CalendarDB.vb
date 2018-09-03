Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class CalendarDB
	 Inherits DbContext

	 Public Sub New()
		  MyBase.New("name=CalendarDB")
	 End Sub

	 Public Overridable Property Appointments As DbSet(Of EFAppointment)
	 Public Overridable Property Resources As DbSet(Of EFResource)

	 Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
	 End Sub
End Class
