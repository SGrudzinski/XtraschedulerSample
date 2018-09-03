Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
<Table("Appointments")>
Partial Public Class EFAppointment
	 <Key>
	 Public Property UniqueID As Long

	 Public Property Type As Integer?

    <Column(TypeName:="smalldatetime")>
    Public Property StartDate As Date?

    <Column(TypeName:="smalldatetime")>
    Public Property EndDate As Date?

    Public Property AllDay As Boolean?

    <StringLength(50)>
    Public Property Subject As String

    <StringLength(50)>
    Public Property Location As String

    Public Property Description As String

    Public Property Status As Integer?

    Public Property Label As Integer?

    Public Property ResourceID As Integer?

    Public Property ResourceIDs As String

    Public Property ReminderInfo As String

    Public Property RecurrenceInfo As String

    Public Property TimeZoneId As String

    Public Property Department As String
End Class
