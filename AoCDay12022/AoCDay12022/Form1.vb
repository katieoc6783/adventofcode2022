Imports System.IO
Public Class Form1

	Public Sub readInData(ByVal linecount, ByRef innput)
		Dim strReader As StreamReader
		strReader = File.OpenText("C:\Users\neil\Desktop\AOC 2022\day1Input.txt")

		For i = 0 To linecount
			innput(i) = strReader.ReadLine
		Next
		strReader.Close()
	End Sub

	Public Sub TotalWithinLoop(ByVal linecount, ByVal innput)
		Dim tempTotal As Integer = 0
		Dim max1, max2, max3, totalMax, temp, temp2 As Integer
		'loop
		For i = 0 To linecount
			If innput(i) <> "" Then
				'add together
				tempTotal = tempTotal + innput(i)
			Else
				If tempTotal > max1 Then
					temp = max1
					temp2 = max2
					max2 = temp
					max3 = temp2
					max1 = tempTotal
				ElseIf tempTotal > max2 Then
					temp = max2
					max3 = temp
					max2 = tempTotal
				ElseIf tempTotal > max3 Then
					max3 = tempTotal
				End If

				tempTotal = 0
			End If
			'restart loop
		Next

		'add maxes
		totalMax = max1 + max2 + max3

		MsgBox(totalMax)
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim linecount As Integer = File.ReadAllLines("C:\Users\neil\Desktop\AOC 2022\day1Input.txt").Length
		Dim innput(linecount) As String
		Dim total As Integer = 0

		Call readInData(linecount, innput)
		Call TotalWithinLoop(linecount, innput)

	End Sub
End Class

