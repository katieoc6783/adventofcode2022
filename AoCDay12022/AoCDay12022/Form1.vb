Imports System.IO
Public Class Form1

	Public Sub readInData(ByVal linecount, ByRef innput)
		Dim strReader As StreamReader
		strReader = File.OpenText("C:\Users\neil\Desktop\AOC 2022\day1Input.txt")

		For i = 0 To linecount - 1
			innput(i) = strReader.ReadLine
		Next
		strReader.Close()
	End Sub

	Public Sub TotalWithinLoop(ByVal linecount, ByVal innput)
		Dim tempTotal As Integer = 0
		Dim max As Integer
		'loop
		For i = 0 To linecount - 1
			If innput(i) <> "" Then
				'add together
				tempTotal = tempTotal + innput(i)
			Else
				If tempTotal > max Then
					max = tempTotal
				End If

				tempTotal = 0
			End If
			'restart loop
		Next

		MsgBox(max)
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim linecount As Integer = File.ReadAllLines("C:\Users\neil\Desktop\AOC 2022\day1Input.txt").Length
		Dim innput(linecount - 1) As String
		Dim total As Integer = 0

		Call readInData(linecount, innput)
		Call TotalWithinLoop(linecount, innput)

	End Sub
End Class

