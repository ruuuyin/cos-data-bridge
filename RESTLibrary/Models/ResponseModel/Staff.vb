﻿Public Class Staff
    Private _username As String
    Private _password As String
    Private _first_name As String
    Private _last_name As String
    Private _role_code As String

    Public Property username As String
        Get
            Return _username
        End Get
        Set
            _username = value
        End Set
    End Property

    Public Property password As String
        Get
            Return _password
        End Get
        Set
            _password = value
        End Set
    End Property

    Public Property first_name As String
        Get
            Return _first_name
        End Get
        Set
            _first_name = value
        End Set
    End Property

    Public Property last_name As String
        Get
            Return _last_name
        End Get
        Set
            _last_name = value
        End Set
    End Property

    Public Property role_code As String
        Get
            Return _role_code
        End Get
        Set
            _role_code = value
        End Set
    End Property
End Class