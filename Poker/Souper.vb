Public Class Souper

    Inherits Panel

    Private Mkh1 As Integer
    Private Mkh2 As Integer
    Private Mkb1 As Integer
    Private Mkb2 As Integer

    Private poradi As Integer
    Private zehry As Boolean = False
    Private Rozhodnuti As String

    Private myMaxsazka As Integer

    Private allin As Boolean

    Private myBezzetonu As Boolean

    Private kicker As Integer

    Private onepair As Boolean
    Private twopair As Boolean
    Private threeofkind As Boolean
    Private poker As Boolean
    Private highcard As Boolean

    Private postupkahodnota As Integer

    Private rnd As Random
    Private myCas, myOdpocet As Integer
    Private rcislo As Integer
    Private sila As Integer
    Private reakce As Boolean = False
    Dim odpoved As String
    Private myChips As Integer

    Private prvnikolo As Boolean

    Private barva As Integer


    Private poradikombinace As Integer

    Private dalbigblind As Boolean
    Private dalsmallblind As Boolean
    Private castkasmallblind As Integer

    Private id As Integer

    Private vitez As Boolean = False

    Private lblchips As Label
    Private lblrozhodnuti As Label
    Private lblhrac As Label

    Private predchozisazka As Integer

    Public listkarty As New List(Of Karta)

    Public Sub odsednuti()
        odebranikaret()
        Form1.Controls.Remove(Me)
    End Sub

    Public Sub New(l As Integer)
        MyBase.New()
        id = l
        Select Case l
            Case 0
                Location = New Point(460, 35)
            Case 1
                Location = New Point(835, 250)
            Case 2
                Location = New Point(80, 250)
            Case 3
                Location = New Point(190, 85)
            Case 4
                Location = New Point(730, 85)
            Case 5
                Location = New Point(730, 430)
            Case 6
                Location = New Point(190, 430)
        End Select
        BackColor = Color.Transparent
        Size = New Size(102, 120)

        myChips = Form1.Hrachips
        lblchips = New Label
        With lblchips
            .Text = myChips
            .ForeColor = Color.Snow
            .Location = New Point(10, 80)
        End With

        lblhrac = New Label
        With lblhrac
            .ForeColor = Color.Yellow
            .Text = "Hráč: " & l
            .Location = New Point(60, 95)
        End With

        lblrozhodnuti = New Label
        With lblrozhodnuti
            .ForeColor = Color.Red
            .Location = New Point(65, 85)
        End With

        Me.Controls.Add(lblhrac)
        Me.Controls.Add(lblrozhodnuti)
        Me.Controls.Add(lblchips)


        Form1.Controls.Add(Me)

        prvnikolo = True

    End Sub


    Public Sub novahra()

        If myChips <= 0 Then
            odsednuti()
            zehry = True
        Else
            lblrozhodnuti.Text = ""
            lblchips.Text = chipy

            dalbigblind = False
            dalsmallblind = False
            predchozisazka = 0
            vitez = False
            odpoved = ""
            sila = 0
            zehry = False

            Me.Controls.Add(lblhrac)
            Me.Controls.Add(lblrozhodnuti)
            Me.Controls.Add(lblchips)

        End If

    End Sub

    Public Sub odebranikaret()

        Do While Controls.Count > 0
            Controls.RemoveAt(0)
        Loop

        Do While listkarty.Count > 0
            Form1.zahozene.Add(listkarty(0))
            listkarty.RemoveAt(0)
        Loop

    End Sub

    Public Sub vemkarty()

        Do While Controls.Count > 0
            Controls.RemoveAt(0)
        Loop

        For i = 0 To 1
            listkarty(i).Otocena = False
            listkarty(i).Size = New Size(50, 80)
            listkarty(i).Visible = True
            listkarty(i).Left = i * 51
            Controls.Add(listkarty(0))
            Controls.Add(listkarty(1))
        Next
        Me.Controls.Add(lblhrac)
        Me.Controls.Add(lblrozhodnuti)
        Me.Controls.Add(lblchips)



        If listkarty(0).HodnotaKarty > listkarty(1).HodnotaKarty Then
            kicker = listkarty(0).HodnotaKarty
        Else
            kicker = listkarty(1).HodnotaKarty
        End If

        BackColor = Color.Transparent
    End Sub



    Public Sub hrej(maxsazka As Integer)

        If zehry = False Then

            Mkh1 = listkarty(0).HodnotaKarty
            Mkb1 = listkarty(0).Barva
            Mkh2 = listkarty(1).HodnotaKarty
            Mkb2 = listkarty(1).Barva

            sila = Mkh1 + Mkh2


            Dim silakombinace As Integer = ohodnocenikombinace(Form1.stul)

            If maxsazka = 0 And prvnikolo = True Then
                prvnikolo = False
                If sila <= 12 Then
                    rcislo = random(1, 10)
                    If rcislo <= 7 Then
                        odpoved = "check"
                    End If

                    If rcislo = 8 And myChips > maxsazka Then
                        odpoved = "raise"

                    End If

                    If rcislo >= 9 Then
                        odpoved = "fold"
                    End If
                End If

                If (sila >= 13) And (sila <= 20) Then
                    rcislo = random(1, 10)
                    If rcislo <= 6 Then
                        odpoved = "check"
                    End If

                    If (rcislo = 9) Or (rcislo = 8) Or (rcislo = 7) And myChips > maxsazka Then
                        odpoved = "raise"

                    End If

                    If rcislo = 10 Then
                        odpoved = "fold"
                    End If
                End If

                If (sila >= 21) And (sila <= 25) Then
                    rcislo = random(1, 10)
                    If rcislo <= 4 Then
                        odpoved = "check"
                    End If

                    If (rcislo >= 5) And (rcislo <= 9) And myChips > maxsazka Then
                        odpoved = "raise"

                    End If

                    If rcislo = 10 Then
                        odpoved = "fold"
                    End If
                End If


                If (sila >= 26) Then
                    rcislo = random(1, 10)
                    If rcislo <= 2 Then
                        odpoved = "check"
                    End If

                    If (rcislo >= 3) And (rcislo <= 9) And myChips > maxsazka Then
                        odpoved = "raise"

                    End If

                    If rcislo = 10 Then
                        odpoved = "fold"
                    End If
                End If

           

            ElseIf maxsazka > 0 And prvnikolo = False Or maxsazka > 0 And prvnikolo = True Or dalsmallblind = True Then

                Select Case silakombinace
                    Case 0
                        rcislo = random(0, 10)
                        If rcislo = 0 Then
                            odpoved = "raise"
                        ElseIf rcislo = 1 Or rcislo = 2 Then
                            odpoved = "call"
                        Else
                            odpoved = "fold"
                        End If
                    Case 1
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 3 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 4 And rcislo <= 7 Then
                            odpoved = "call"
                        Else
                            odpoved = "fold"
                        End If
                    Case 2
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 4 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 5 And rcislo <= 8 Then
                            odpoved = "call"
                        Else
                            odpoved = "fold"
                        End If
                    Case 3
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 5 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 5 And rcislo <= 8 Then
                            odpoved = "call"
                        Else
                            odpoved = "fold"
                        End If
                    Case 4
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 6 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 7 And rcislo <= 9 Then
                            odpoved = "call"
                        Else
                            odpoved = "fold"
                        End If
                    Case 5
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 6 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 7 And rcislo <= 9 Then
                            odpoved = "call"
                        Else
                            odpoved = "fold"
                        End If
                    Case 6
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 6 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 7 And rcislo <= 9 Then
                            odpoved = "call"
                        Else
                            odpoved = "fold"
                        End If
                    Case 7
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 6 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 7 And rcislo <= 9 Then
                            odpoved = "call"
                        Else
                            odpoved = "fold"
                        End If
                End Select


            Else
                Select Case silakombinace
                    Case 0
                        rcislo = random(0, 10)
                        If rcislo = 0 Then
                            odpoved = "raise"
                        ElseIf rcislo = 1 Or rcislo = 2 Then
                            odpoved = "check"
                        Else
                            odpoved = "fold"
                        End If
                    Case 1
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 3 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 4 And rcislo <= 7 Then
                            odpoved = "check"
                        Else
                            odpoved = "fold"
                        End If
                    Case 2
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 4 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 5 And rcislo <= 8 Then
                            odpoved = "check"
                        Else
                            odpoved = "fold"
                        End If
                    Case 3
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 5 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 5 And rcislo <= 8 Then
                            odpoved = "check"
                        Else
                            odpoved = "fold"
                        End If
                    Case 4
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 6 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 7 And rcislo <= 9 Then
                            odpoved = "check"
                        Else
                            odpoved = "fold"
                        End If
                    Case 5
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 6 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 7 And rcislo <= 9 Then
                            odpoved = "check"
                        Else
                            odpoved = "fold"
                        End If
                    Case 6
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 6 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 7 And rcislo <= 9 Then
                            odpoved = "check"
                        Else
                            odpoved = "fold"
                        End If
                    Case 7
                        rcislo = random(0, 10)
                        If rcislo >= 0 And rcislo <= 6 Then
                            odpoved = "raise"
                        ElseIf rcislo >= 7 And rcislo <= 9 Then
                            odpoved = "check"
                        Else
                            odpoved = "fold"
                        End If
                End Select

            End If

            If maxsazka = predchozisazka And dalbigblind = True Then
                odpoved = "check"
            End If

            Select Case odpoved
                Case "fold"
                    If allin = False Then
                        odebranikaret()
                        Rozhodnuti = -1
                        zehry = True
                        lblrozhodnuti.Text = "Fold"
                    End If

                Case "raise"
                    
                    If myChips > maxsazka Then
                        Dim pom As Integer = random(0, (myChips - maxsazka) / 10)
                        Rozhodnuti = maxsazka + pom
                        predchozisazka = CInt(Rozhodnuti)
                        myChips -= CInt(Rozhodnuti)
                        lblchips.Text = myChips
                        lblrozhodnuti.Text = "Raise"
                    Else
                        If myChips < maxsazka Then
                            predchozisazka = myChips
                            Rozhodnuti = myChips
                            myChips -= CInt(Rozhodnuti)
                            lblchips.Text = "All-in"
                            allin = True
                            lblrozhodnuti.Text = "Call"
                        ElseIf dalsmallblind = True Then
                            dalsmallblind = False
                            Rozhodnuti = maxsazka - castkasmallblind
                            predchozisazka = CInt(Rozhodnuti)
                            myChips -= CInt(Rozhodnuti)
                            lblchips.Text = myChips
                            lblrozhodnuti.Text = "Call"
                        Else
                            Rozhodnuti = maxsazka
                            predchozisazka = CInt(Rozhodnuti)
                            myChips -= CInt(Rozhodnuti)
                            lblchips.Text = myChips
                            lblrozhodnuti.Text = "Call"
                        End If

                    End If

                Case "check"
                    Rozhodnuti = -2
                    lblrozhodnuti.Text = "Check"
                    predchozisazka = 0
                Case "call"
                    If myChips < maxsazka Then
                        predchozisazka = myChips
                        Rozhodnuti = myChips
                        myChips -= CInt(Rozhodnuti)
                        lblchips.Text = "All-in"
                        allin = True
                        lblrozhodnuti.Text = "Call"
                    ElseIf dalsmallblind = True Then
                        dalsmallblind = False
                        Rozhodnuti = maxsazka - castkasmallblind
                        predchozisazka = CInt(Rozhodnuti)
                        myChips -= CInt(Rozhodnuti)
                        lblchips.Text = myChips
                        lblrozhodnuti.Text = "Call"
                    Else
                        Rozhodnuti = maxsazka
                        predchozisazka = CInt(Rozhodnuti)
                        myChips -= CInt(Rozhodnuti)
                        lblchips.Text = myChips
                        lblrozhodnuti.Text = "Call"
                    End If

            End Select
            lblrozhodnuti.Refresh()
        End If

    End Sub


    Public Property vyhra As Integer
        Set(zetony As Integer)
            myChips += zetony
            lblchips.Text = myChips
        End Set

        Get
            Return myChips
        End Get
    End Property


    Public ReadOnly Property kickerhodnota As Integer
        Get
            Return kicker
        End Get
    End Property


    Public Property bezzetonu As Boolean
        Set(stav1 As Boolean)
            myBezzetonu = stav1
        End Set
        Get
            Return myBezzetonu
        End Get
    End Property

    Public Property BigBlind As Integer
        Set(Blind As Integer)
            myChips -= Blind
            predchozisazka = Blind
            dalbigblind = True
            lblchips.Text = myChips
        End Set
        Get
            Return myChips
        End Get
    End Property

    Public Property SmallBlind As Integer
        Set(Blind As Integer)
            myChips -= Blind
            predchozisazka = Blind
            castkasmallblind = Blind
            dalsmallblind = True
            lblchips.Text = myChips
        End Set
        Get
            Return myChips
        End Get
    End Property


    Public ReadOnly Property chipy As Integer
        Get
            Return myChips
        End Get
    End Property

    Public ReadOnly Property Poslednisazka As Integer
        Get
            Return predchozisazka
        End Get
    End Property

    Private Function kombinacetext(kartyzestolu As List(Of Karta)) As String

        Dim par As Integer = 0
        kombinacetext = "High card"
        Dim kartystul As New List(Of Karta)
        Dim pomlist As New List(Of Karta)
        Dim predchozikombinace As Integer
        Dim kombinace As Integer


        kartystul.Add(listkarty(0))
        kartystul.Add(listkarty(1))

        If Form1.stul.Count > 0 Then
            For i = 0 To Form1.stul.Count - 1
                kartystul.Add(Form1.stul(i))
            Next
        End If

        predchozikombinace = -2

        For i = 0 To kartystul.Count - 1
            kombinace = -1
            barva = -1
            pomlist.Add(kartystul(i))

            For j = 0 To kartystul.Count - 1
                If pomlist(0).HodnotaKarty = kartystul(j).HodnotaKarty Then 'porovnává hodnoty karet (1par, ¨2pary, trojicka, poker)
                    kombinace += 1
                End If
                If pomlist(0).Barva = kartystul(j).Barva Then
                    barva += 1
                End If
                If barva = 4 Then
                    kombinace = 5 '5=Barva
                End If
            Next
            If (predchozikombinace <= kombinace) Then

                If kombinace = 1 Then
                    If par = 3 Then
                        kombinacetext = "Dva pary"
                    End If
                    If par < 3 Then
                        kombinacetext = "Jeden par"
                        par += 1
                    End If
                End If

                Select Case kombinace
                    Case 2
                        kombinacetext = "Trojicka"
                        If par >= 3 Then
                            kombinacetext = "Full-house"
                        End If

                    Case 3
                        kombinacetext = "Poker"
                    Case 4

                    Case 5
                        kombinacetext = "Flush"
                End Select
                predchozikombinace = kombinace
            End If
            pomlist.RemoveAt(0)
        Next

        postupkahodnota = 0


        Do While pomlist.Count > 0
            pomlist.RemoveAt(0)
        Loop

        For k = 0 To kartystul.Count - 1
            pomlist.Add(kartystul(k))
            For j = 1 To 4
                Dim prvnikarta As Boolean = False
                Dim barvapostupka As Integer = -1
                For i = 0 To kartystul.Count - 1
                    If (pomlist(0).HodnotaKarty + j) = kartystul(i).HodnotaKarty Then
                        If prvnikarta = False Then
                            postupkahodnota += 1
                            prvnikarta = True

                            If postupkahodnota = 4 And predchozikombinace < 4 Then
                                predchozikombinace = 4
                                kombinacetext = "Straight"
                                kombinace = 4
                                poradikombinace = 4
                            End If

                        End If
                    End If
                Next
            Next
            Do While pomlist.Count > 0
                pomlist.RemoveAt(0)
            Loop
            postupkahodnota = 0
        Next

    End Function
    Private Function ohodnocenikombinace(kartyzestolu As List(Of Karta)) As Integer
        ohodnocenikombinace = -1
        Select Case kombinacetext(kartyzestolu)
            Case "High card"
                ohodnocenikombinace = 0
            Case "Jeden par"
                ohodnocenikombinace = 1
            Case "Dva pary"
                ohodnocenikombinace = 2
            Case "Trojicka"
                ohodnocenikombinace = 3
            Case "Full-house"
                ohodnocenikombinace = 6
            Case "Poker"
                ohodnocenikombinace = 7
            Case "Postupka"
                ohodnocenikombinace = 4
            Case "Flush"
                ohodnocenikombinace = 5

        End Select

    End Function

    Public ReadOnly Property hodnotakombinace As Integer
        Get
            If zehry = False Then

                Return ohodnocenikombinace(Form1.stul)
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property kombinace As String
        Get
            If zehry = False Then

                Return "Hráč " & id & " " & kombinacetext(Form1.stul)
            Else
                Return 0
            End If
        End Get
    End Property

    Private Function random(i As Integer, j As Integer)
        rnd = New Random
        Dim randcislo As Integer
        Randomize()
        randcislo = rnd.Next(i, j)
        Return randcislo
    End Function

    Public ReadOnly Property Rozhodnutif()
        Get
            Return Rozhodnuti
        End Get
    End Property

    Public ReadOnly Property Nehraje()
        Get
            Return zehry
        End Get
    End Property



End Class
