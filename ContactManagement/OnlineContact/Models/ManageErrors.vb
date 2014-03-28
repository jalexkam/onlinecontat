Imports OnlineContact
Namespace Models
    ''' <summary>
    ''' Class for managing delete profile error 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class DeleteProfileErrorMessage
        Public Property ErrorMessage() As String

        Public Property OriginalProfile() As Profile
    End Class

    ''' <summary>
    ''' class for managing successful delete profile
    ''' </summary>
    ''' <remarks></remarks>
    Public Class DeleteProfileSuccessMessage
        Public Property SuccessMessage() As String

        Public Property OriginalProfile() As Profile
    End Class


    ''' <summary>
    ''' class for managing successful creating of a contact
    ''' </summary>
    ''' <remarks></remarks>
    Public Class CreateProfileSuccessMessage
        Public Property SuccessMessage() As String

        Public Property OriginalProfile() As Profile
    End Class




    ''' <summary>
    ''' Class for managing delete Address error 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class DeleteAddressErrorMessage
        Public Property ErrorMessage() As String

        Public Property OriginalAddress() As Address
    End Class

    ''' <summary>
    ''' class for managing successful delete Address
    ''' </summary>
    ''' <remarks></remarks>
    Public Class DeleteAddressSuccessMessage
        Public Property SuccessMessage() As String

        Public Property OriginalAddress() As Address
    End Class


    ''' <summary>
    ''' class for managing successful creating of a contact
    ''' </summary>
    ''' <remarks></remarks>
    Public Class CreateAddressSuccessMessage
        Public Property SuccessMessage() As String

        Public Property OriginalProfile() As Profile
    End Class

    ''' <summary>
    ''' class for managing successful Edit contact
    ''' </summary>
    ''' <remarks></remarks>
    Public Class EditAddressSuccessMessage
        Public Property SuccessMessage() As String

        Public Property OriginalAddress() As Address
    End Class


    ''' <summary>
    ''' class for managing successful Edit contact
    ''' </summary>
    ''' <remarks></remarks>
    Public Class EditProfileSuccessMessage
        Public Property SuccessMessage() As String

        Public Property OriginalProfile() As Profile
    End Class



    'Public Enum MessageContent

    'End Enum
    Public Enum MessageType
        Warning
        [Error]
        Success
        Information

    End Enum

End Namespace