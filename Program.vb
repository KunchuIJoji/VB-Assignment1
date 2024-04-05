Imports System

Module Program
    Public Class Student
        Public roll_no As Integer
        Public name As String
        Public age As Integer
        Public gender As String

        Public Function Add()
            Console.Write("Enter roll number: ")
            roll_no = Integer.Parse(Console.ReadLine())

            Console.Write("Enter student name: ")
            name = Console.ReadLine()

            Console.Write("Enter student age: ")
            age = Integer.Parse(Console.ReadLine())

            Console.Write("Enter student gender: ")
            gender = Console.ReadLine()
        End Function

        Public Function Print(Array As String)
            Console.WriteLine("Student Information")
            Console.WriteLine(vbTab & "Roll Number: " & roll_no)
            Console.WriteLine(vbTab & "Name  : " & name)
            Console.WriteLine(vbTab & "Age       : " & age)
            Console.WriteLine(vbTab & "Gender    : " & gender)
        End Function
    End Class
    Sub Main(args As String())
        Dim array() As String
        Dim aa = New Student()
        Dim op2 As Integer = 1
        Do
            Console.WriteLine(vbTab & "MENU:")
            Console.WriteLine("1. Add Student Details")
            Console.WriteLine("2. Get Student Details")
            Console.WriteLine("")
            Console.Write("Enter you option:")
            Dim op As Integer = Console.ReadLine()


            Select Case op
                Case 1
                    array = aa.Add()
                Case 2
                    aa.Print(array)
                Case Else
                    Console.WriteLine("Invalid Option")
            End Select
            Console.WriteLine("Do you want to continue? (Yes:1 / No:0)")
            op2 = Console.ReadLine()
        Loop While (op2 = 1)
    End Sub
End Module
