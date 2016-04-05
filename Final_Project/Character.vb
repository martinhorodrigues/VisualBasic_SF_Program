Public Class Character

    Private cName As String
    Private cLP As String
    Private cHP As String
    Private cLK As String
    Private cHK As String
    Private cSuper As String
    Private cNotes As String
    Private dbID As String


    Public Property characterID() As String
        Get
            Return dbID
        End Get
        Set(ByVal value As String)
            dbID = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return cName
        End Get
        Set(ByVal value As String)
            cName = value
        End Set
    End Property

    Public Property LightPunch() As String
        Get
            Return cLP
        End Get
        Set(ByVal value As String)
            cLP = value
        End Set
    End Property

    Public Property HeavyPunch() As String
        Get
            Return cHP
        End Get
        Set(ByVal value As String)
            cHP = value
        End Set
    End Property

    Public Property LightKick() As String
        Get
            Return cLK
        End Get
        Set(ByVal value As String)
            cLK = value
        End Set
    End Property

    Public Property HeavyKick() As String
        Get
            Return cHK
        End Get
        Set(ByVal value As String)
            cHK = value
        End Set
    End Property

    Public Property Super() As String
        Get
            Return cSuper
        End Get
        Set(ByVal value As String)
            cSuper = value
        End Set
    End Property

    Public Property CharNotes() As String
        Get
            Return cNotes
        End Get
        Set(ByVal value As String)
            cNotes = value
        End Set
    End Property

End Class
