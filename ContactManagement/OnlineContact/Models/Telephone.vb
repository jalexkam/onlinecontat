Imports System.ComponentModel.DataAnnotations
Imports System.Web
Imports System.Runtime.CompilerServices
Imports System.Runtime.Remoting.Activation
Imports System.ComponentModel


<MetadataType(GetType(MetaDataPhoneNumber))>
Partial Public Class PhoneNumber

End Class

Public Class MetaDataPhoneNumber
    <Required(ErrorMessage:="The Phone Number is required")>
    <StringLength(15, ErrorMessage:="The Phone Number has to be between 3 and 15 characters", MinimumLength:=3)>
    <DataType(DataType.PhoneNumber, ErrorMessage:="Incorrect phone number type")>
    <Display(Name:="Phone Number")>
    Public Property Number() As String

    <Display(Name:="Phone Type")>
    <Required(ErrorMessage:="The Phone Type is required")>
    Public Property FKPhoneTypeID() As Int32

    <Display(Name:="Profile ID")>
    <Required(ErrorMessage:="The profile ID is required")>
    Public Property FKProfileID() As Int32

End Class
