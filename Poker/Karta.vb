Public Class Karta
    Inherits PictureBox
    Public Enum BarvaKarty
        Srdce = 0
        Kule = 1
        Piky = 2
        Krize = 3
    End Enum

    Public Enum Hodnota
        Dvojka = 2
        Trojka = 3
        Ctyrka = 4
        Petka = 5
        Sestka = 6
        Sedmicka = 7
        Osmicka = 8
        Devitka = 9
        Desitka = 10
        Kluk = 11
        Dama = 12
        Kral = 13
        Eso = 1
    End Enum

    Private myBarva As BarvaKarty
    Private myHodnota As Hodnota
    Private myImageLic As Bitmap
    Private myImageRub As Bitmap
    Private myOtocena As Boolean = False

    Public Sub New(barva As BarvaKarty, hodnota As Hodnota, lic As Bitmap, rub As Bitmap)
        MyBase.New()
        myBarva = barva
        myHodnota = hodnota
        myImageLic = lic
        myImageRub = rub
    End Sub

    Public ReadOnly Property Barva As BarvaKarty
        Get
            Return myBarva
        End Get
    End Property


    Public ReadOnly Property HodnotaKarty As Hodnota
        Get
            Return myHodnota
        End Get
    End Property


    Public Property Otocena As Boolean
        Set(value As Boolean)
            myOtocena = value
        End Set
        Get
            Return myOtocena
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return myHodnota.ToString & ":" & myBarva.ToString
    End Function

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        If Otocena Then
            pe.Graphics.DrawImage(myImageLic, 0, 0, 50, 80)
        Else
            pe.Graphics.DrawImage(myImageRub, 0, 0, 50, 80)
        End If
    End Sub

End Class

