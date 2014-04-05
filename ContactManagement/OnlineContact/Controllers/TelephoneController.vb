Namespace Controllers
    Public Class TelephoneController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Telephone
        ReadOnly _contactdB As OnlineContact = New OnlineContact()
        Function Index(Optional ByVal id As Integer = 1) As ActionResult

            Dim telephoneNumberList = _contactdB.PhoneNumbers.Where(Function(p) p.FKProfileID = id)

            Dim phoneNumbersType = _contactdB.PhoneTypes.ToList()
            ViewBag.phoneNumbersType = phoneNumbersType

            Dim phoneNumbersTypeList As SelectList = New SelectList(phoneNumbersType, "ID", "Name")
            ViewBag.PhoneNumbersTypeList = phoneNumbersTypeList

            Dim phoneProfile = _contactdB.profiles.SingleOrDefault(Function(p) p.ID = id)
            ViewBag.PhoneProfile = phoneProfile

            Return View(telephoneNumberList)
        End Function

        <HttpGet()>
        Function Create(ByVal id As Integer)

            Dim createProfile = _contactdB.Profiles.Single(Function(p) p.ID = id)
            ViewBag.createProfile = createProfile

            Dim phoneNumbersType = _contactdB.PhoneTypes.ToList()
            Dim phoneNumbersTypeList As SelectList = New SelectList(phoneNumbersType, "ID", "Name")
            ViewBag.PhoneNumbersTypeList = phoneNumbersTypeList

            'Dim createPhoneNumber As PhoneNumber = New PhoneNumber()
            Return View()

        End Function

        <HttpPost()>
        Function Create(ByVal createPhone As PhoneNumber) As ActionResult

            'check if the phone number field only contains numeric characters
            '' if not add an error to the list of error of the model

            If Not IsNumeric(createPhone.Number) Then
                ModelState.AddModelError("Number", "Phone number cant only has numeric characters")
            End If

            If ModelState.IsValid Then
                _contactdB.PhoneNumbers.AddObject(createPhone)
                _contactdB.SaveChanges()
                Return RedirectToAction("Index", "Telephone", New With {.id = createPhone.FKProfileID})
            End If

            Dim createProfile = _contactdB.Profiles.Single(Function(p) p.ID = createPhone.FKProfileID)
            ViewBag.createProfile = createProfile

            Dim phoneNumbersType = _contactdB.PhoneTypes.ToList()
            Dim phoneNumbersTypeList As SelectList = New SelectList(phoneNumbersType, "ID", "Name")
            ViewBag.PhoneNumbersTypeList = phoneNumbersTypeList


            Return View(createPhone)
        End Function

        '<HttpGet()>
        'Function Delete(ByVal id As Integer) As ActionResult
        '    Dim phone = _contactdB.PhoneNumbers.Single(Function(p) p.ID = id)
        '    Return View(phone)
        'End Function

        <HttpPost()>
        Function Delete(ByVal id As Integer) As ActionResult
            Dim deletePhone = _contactdB.PhoneNumbers.Single(Function(p) p.ID = id)
            _contactdB.PhoneNumbers.DeleteObject(deletePhone)
            _contactdB.SaveChanges()

            Return RedirectToAction("Index", "Telephone", New With {.profileId = deletePhone.FKProfileID})
        End Function
    End Class
End Namespace