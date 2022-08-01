Class Person
	Sub New(_Name As String, _AgeInYears As Integer = 0, _Hobbies As List(Of String) = {})
		Name = _Name
		AgeInYears = _AgeInYears
		Hobbies = _Hobbies
	End Sub

	Dim Name As String

	Dim AgeInYears As Integer

	Dim Hobbies As List(Of String)
End Class

Dim Aiden As Person = New Person("Aiden", -1, {"Programming", "Gaming", "Legos", "Origami"})