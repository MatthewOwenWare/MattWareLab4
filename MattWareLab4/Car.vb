'Matthew Ware
'MattWareLab4 file
'July 20 2020
'Durham College NETD 2202
Option Strict On
Public Class Car
    'Variable Declarations
    Private ReadOnly Count As Integer = 0       'Keeps track of how many cars there are
    Private ReadOnly IdentificationNumber As Integer = 0    'Assigns an ID number based on count
    Private carMake As String = String.Empty    'Holds the Car Make as a String
    Private carModel As String = String.Empty   'Holds the Car Model as a String
    Private carYear As Integer = 0              'Holds the Year the Car was Made as an integer
    Private carPrice As Decimal = 0             'Holds the price of the car as a double
    Private carNewStatus As Boolean = False     'Determines if the car is new or used
    Public Sub New()    'Default Constructor Adds a new number to the count each time an object is created and assigns that to the new Identification number
        Count += 1
        IdentificationNumber = Count
    End Sub

    Public Sub New(make As String, model As String, year As Integer, price As Decimal, newStatus As Boolean)    'Parameterized Constructor for Car Objects
        Me.New()                    'Calls the default constructor

        carMake = make              'Assigns the string make to the carMake variable
        carModel = model            'Assigns the string model to the carModel variable
        carYear = year              'Assigns the year as an Integer to carYear variable
        carPrice = price            'Assigns the price as a Decimal to the carPrice variable
        carNewStatus = newStatus    'Determines if the carNewStatus is new or used, boolean true meaning new

    End Sub
    Public Function GetCarData(field As Integer) As String  'Function to print the values of the variables as strings depending on which field is sent to the function by the field variable
        If (field = 0) Then
            Return carNewStatus.ToString
        End If
        If (field = 1) Then
            Return IdentificationNumber.ToString
        End If
        If (field = 2) Then
            Return carMake.ToString
        End If
        If (field = 3) Then
            Return carModel.ToString
        End If
        If (field = 4) Then
            Return carYear.ToString
        End If
        If (field = 5) Then
            Return carPrice.ToString
        End If
        Return String.Empty 'Return an empty string by default
    End Function
End Class
