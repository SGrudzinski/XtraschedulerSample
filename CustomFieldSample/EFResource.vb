Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
<Table("Resources")>
Partial Public Class EFResource
	 <Key>
	 Public Property UniqueID As Long

	 Public Property ResourceID As Integer

	 <StringLength(50)>
	 Public Property ResourceName As String

	 Public Property Color As Integer?

	 <Column(TypeName:="image")>
	 Public Property Image As Byte()

	 Public Property CustomField1 As String
End Class
