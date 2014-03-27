'Imports MvcOnlineContact.Models
Imports OnlineContact.Models

Namespace Controllers
    Public Class AddressController
        Inherits System.Web.Mvc.Controller
        ReadOnly _contactDB As OnlineContact = New OnlineContact()
        '
        ' GET: /Address

        Function Index(Optional ByVal id As Integer = 1) As ActionResult

            Dim addressesList As List(Of Address) = New List(Of Address)()
            ViewBag.AddressProfile = _contactDB.Profiles.Single(Function(p) p.ID = id)

            If _contactDB.Profiles.Single(Function(p) p.ID = id).Addresses().Count > 0 Then
                addressesList = _contactDB.Profiles.Single(Function(p) p.ID = id).Addresses().ToList()
            End If



            ''pass delete Address error message to the view 
            If Not TempData("DeleteAddressError") Is Nothing Then
                Dim errorDeleteAddress As DeleteAddressErrorMessage = CType(TempData("DeleteAddressError"), DeleteAddressErrorMessage)
                ViewBag.ErrorDeleteAddress = errorDeleteAddress
            End If

            ''pass delete Address successful message to the view 
            If Not TempData("DeleteAddressSuccess") Is Nothing Then
                Dim successDeleteAddress As DeleteAddressSuccessMessage = CType(TempData("DeleteAddressSuccess"), DeleteAddressSuccessMessage)
                ViewBag.SuccessDeleteAddress = successDeleteAddress
            End If

            ''pass create Address successful message to the view 
            If Not TempData("CreateAddressSuccess") Is Nothing Then
                Dim successCreateAddress As CreateAddressSuccessMessage = CType(TempData("CreateAddressSuccess"), CreateAddressSuccessMessage)
                ViewBag.SuccessCreateAddress = successCreateAddress
            End If

            ''''pass edit Address error message to the view 
            If Not TempData("EditAddressSuccess") Is Nothing Then
                Dim successEditAddress As EditAddressSuccessMessage = CType(TempData("EditAddressSuccess"), EditAddressSuccessMessage)
                ViewBag.SuccessEditAddress = successEditAddress
            End If


            Return View(addressesList)
        End Function

        <HttpGet()>
        Function Create(ByVal id As Integer) As ActionResult
            ViewBag.createProfileId = id
            Return View()

        End Function
        Function Create(ByVal createAddress As Address) As ActionResult
            If ModelState.IsValid Then
                createAddress.ID = 0
                _contactDB.AddToAddresses(createAddress)
                _contactDB.SaveChanges()


                'generate the success message after a new contact(Address) has been created
                Dim successCreateAddress As CreateAddressSuccessMessage = New CreateAddressSuccessMessage()
                successCreateAddress.SuccessMessage = createAddress.AddressLine1 & " " & createAddress.AddressLine2 & " successfully added to address list"
                successCreateAddress.OriginalProfile = createAddress.Profile

                TempData("CreateAddressSuccess") = successCreateAddress

                Return RedirectToAction("Index", "Address", New With {.id = createAddress.FKProfileID})
            End If
            Return View(createAddress)
        End Function

        <HttpGet()>
        Function Delete(ByVal id As Integer) As ActionResult
            Dim deleteProfile = _contactDB.Addresses.Single(Function(a) a.ID = id)
            Return View(deleteProfile)


        End Function

        <HttpPost()>
        Function Delete(ByVal address As Address) As ActionResult
            Dim deleteAddress = _contactDB.Addresses.Single(Function(a) a.ID = address.ID)
            _contactDB.Addresses.DeleteObject(deleteAddress)
            _contactDB.SaveChanges()


            Dim deleteSuccess As DeleteAddressSuccessMessage = New DeleteAddressSuccessMessage()
            deleteSuccess.SuccessMessage = deleteAddress.AddressLine1 & " " & deleteAddress.AddressLine2 & " has beeen successfully delete from the address list"
            deleteSuccess.OriginalAddress = deleteAddress

            TempData("DeleteAddressSuccess") = deleteSuccess

            Return RedirectToAction("Index", "Address", New With {.id = deleteAddress.FKProfileID})

        End Function

        Public Function Edit(ByVal id As Integer) As ActionResult
            Dim editAddress As Address = _contactDB.Addresses.Single(Function(a) a.ID = id)

            Return View(editAddress)
        End Function

        <HttpPost()>
        Public Function Edit(ByVal address As Address) As ActionResult
            Dim editAddress As Address = _contactDB.Addresses.Single(Function(a) a.ID = address.ID)

            editAddress.AddressLine1 = address.AddressLine1
            editAddress.AddressLine2 = address.AddressLine2
            editAddress.City = address.City
            editAddress.Country = address.Country
            editAddress.County = address.County
            editAddress.PostCode = address.PostCode

            _contactDB.SaveChanges()

            Dim editSuccessAddress As EditAddressSuccessMessage = New EditAddressSuccessMessage()
            editSuccessAddress.SuccessMessage = "Address has beeen successfully edited"
            editSuccessAddress.OriginalAddress = address

            TempData("EditAddressSuccess") = editSuccessAddress
            Return RedirectToAction("Index", "Address", New With {.id = editAddress.FKProfileID})
        End Function
    End Class
End Namespace