Public Class Form1
    Public karty As New List(Of Karta)
    Dim hracja As New List(Of Karta)
    Dim mojekarty As New List(Of Karta)
    Dim japom As New List(Of Karta)
    Public zahozene As New List(Of Karta)


    Dim Hrac(7) As Souper
    Public stul As New List(Of Karta)
    Dim r As New Random


    Dim mykombinace As String = ""
    Dim poradikombinace As Integer

    Dim kontrolasazek As Integer

    Dim odp As String

    Dim pomocnacislo As Integer

    Dim konec As Boolean

    Dim maxsazka As Integer
    Dim pocethracu As Integer
    Dim hracuvehre As Integer

    Dim jakicker As Integer

    Dim SmallBlind, BigBlind As Integer

    Dim blindypocitani As Integer

    Dim ukazkartysouper As Boolean = False
    Dim rozdanhracum As Boolean = False
    Dim stavstul As Boolean = False
    Dim stavhry As Integer
    Dim kontrola As Boolean
    Dim jaodp As Boolean
    Dim ukazanikaret As Boolean = False
    Dim javitez As Boolean = False

    Dim mojepredchozisazka As Integer
    Dim daldohry As Integer


    Dim jasb As Boolean

    Public Hrachips As Integer
    Dim hrapocethracu As Integer

    Dim pom As Integer
    Dim mojechipy As Integer
    Dim cislo As Integer
    Dim cas, pocitani As Integer
    Dim pot As Integer

    Dim jafold As Boolean

    Dim allin As Boolean = False

    Dim nikdonastole As Boolean

    Dim odpovedvsech As Boolean = False



    Public potencialnivitezove As New List(Of Souper)


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form2.Show()
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        VytvorKarty()

        blindypocitani = 0

    End Sub

    Public Sub novahra()


        If Form2.checkblindy.Checked Then
            BigBlind = Form2.numericblindy.Value
            SmallBlind = BigBlind / 2
        Else
            BigBlind = 0
            SmallBlind = 0
        End If


        Hrachips = Form2.numchipy.Value
        hrapocethracu = Form2.numsouperi.Value


        pot = 0
        lblpot.Text = "Pot: " & pot
        mojechipy = Hrachips
        lblmojechips.Text = mojechipy
        pocethracu = hrapocethracu

        If pocethracu = 1 Then
            pomocnacislo = 0
        End If

        For l = 0 To pocethracu - 1
            Hrac(l) = New Souper(l)
        Next



    End Sub

    Private Sub VytvorKarty()

        karty.Add(New Karta(Karta.BarvaKarty.Krize, 1, My.Resources.Krize_A, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Krize, 2, My.Resources.Krize_2, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Krize, 3, My.Resources.Krize_3, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Krize, 4, My.Resources.Krize_4, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Krize, 5, My.Resources.Krize_5, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Krize, 6, My.Resources.Krize_6, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Krize, 7, My.Resources.Krize_7, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Krize, 8, My.Resources.Krize_8, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Krize, 9, My.Resources.Krize_9, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Krize, 10, My.Resources.Krize_10, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Krize, 11, My.Resources.Krize_J, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Krize, 12, My.Resources.Krize_Q, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Krize, 13, My.Resources.Krize_K, My.Resources.rubkarta))

        karty.Add(New Karta(Karta.BarvaKarty.Kule, 1, My.Resources.Kule_A, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Kule, 2, My.Resources.Kule_2, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Kule, 3, My.Resources.Kule_3, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Kule, 4, My.Resources.Kule_4, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Kule, 5, My.Resources.Kule_5, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Kule, 6, My.Resources.Kule_6, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Kule, 7, My.Resources.Kule_7, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Kule, 8, My.Resources.Kule_8, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Kule, 9, My.Resources.Kule_9, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Kule, 10, My.Resources.Kule_10, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Kule, 11, My.Resources.Kule_J, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Kule, 12, My.Resources.Kule_Q, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Kule, 13, My.Resources.Kule_K, My.Resources.rubkarta))

        karty.Add(New Karta(Karta.BarvaKarty.Piky, 1, My.Resources.Piky_A, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Piky, 2, My.Resources.Piky_2, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Piky, 3, My.Resources.Piky_3, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Piky, 4, My.Resources.Piky_4, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Piky, 5, My.Resources.Piky_5, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Piky, 6, My.Resources.Piky_6, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Piky, 7, My.Resources.Piky_7, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Piky, 8, My.Resources.Piky_8, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Piky, 9, My.Resources.Piky_9, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Piky, 10, My.Resources.Piky_10, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Piky, 11, My.Resources.Piky_J, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Piky, 12, My.Resources.Piky_Q, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Piky, 13, My.Resources.Piky_K, My.Resources.rubkarta))

        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 1, My.Resources.Srdce_A, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 2, My.Resources.Srdce_2, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 3, My.Resources.Srdce_3, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 4, My.Resources.Srdce_4, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 5, My.Resources.Srdce_5, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 6, My.Resources.Srdce_6, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 7, My.Resources.Srdce_7, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 8, My.Resources.Srdce_8, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 9, My.Resources.Srdce_9, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 10, My.Resources.Srdce_10, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 11, My.Resources.Srdce_J, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 12, My.Resources.Srdce_Q, My.Resources.rubkarta))
        karty.Add(New Karta(Karta.BarvaKarty.Srdce, 13, My.Resources.Srdce_K, My.Resources.rubkarta))

        For i = 0 To karty.Count - 1
            Me.Controls.Add(karty(i))
            AddHandler karty(i).Click, AddressOf karta_klik
            karty(i).Visible = False
        Next
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    odebranikaret()
    '    rozdanikaretstul(0, 2)
    '    rozdanikarethracum()
    'End Sub

    Public Sub odebranikaret()
        Do While stul.Count > 0
            karty.Add(stul(0))
            stul.RemoveAt(0)
            panelflop.Controls.RemoveAt(0)
        Loop
        ListBox1.Items.Clear()
        maxsazka = 0
    End Sub

    Public Sub rozdanikaretstul(odpocet As Integer, dopocet As Integer)
        
        For i = odpocet To dopocet
            cislo = r.Next(0, karty.Count)
            stul.Add(karty(cislo))
            karty(cislo).Visible = True
            karty(cislo).Size = New Size(50, 80)
            karty(cislo).Left = i * 65
            karty(cislo).Otocena = True
            panelflop.Controls.Add(karty(cislo))
            ListBox1.Items.Add(karty(cislo).ToString)
            karty.RemoveAt(cislo)
        Next
    End Sub

    Public Sub odebranikarethracum()
        Do While panelja.Controls.Count > 0
            panelja.Controls.RemoveAt(0)
        Loop

        Do While hracja.Count > 0
            karty.Add(hracja(0))
            hracja.RemoveAt(0)
        Loop

        For l = 0 To pocethracu - 1
            Do While Hrac(l).listkarty.Count > 0
                karty.Add(Hrac(l).listkarty(0))
                Hrac(l).listkarty.RemoveAt(0)
            Loop
            'For i = 0 To 1
            '    cislo = r.Next(0, karty.Count)
            '    Hrac(l).listkarty.Add(karty(cislo))
            '    karty.RemoveAt(cislo)
            'Next
        Next


    End Sub

    Public Sub rozdanikarethracum()

        Do While panelja.Controls.Count > 0
            panelja.Controls.RemoveAt(0)
        Loop

        Do While hracja.Count > 0
            karty.Add(hracja(0))
            hracja.RemoveAt(0)
        Loop

        For i = 0 To 1
            cislo = r.Next(0, karty.Count)
            hracja.Add(karty(cislo))
            karty.RemoveAt(cislo)
            hracja(i).Otocena = True
            hracja(i).Size = New Size(50, 80)
            hracja(i).Visible = True
            hracja(i).Left = i * 51
            panelja.Controls.Add(hracja(i))

        Next

        If hracja(0).HodnotaKarty > hracja(1).HodnotaKarty Then
            jakicker = hracja(0).HodnotaKarty
        Else
            jakicker = hracja(1).HodnotaKarty
        End If

        '----------------hracPC---------------------------------------------------------

        For l = 0 To pocethracu - 1
            Do While Hrac(l).listkarty.Count > 0
                karty.Add(Hrac(l).listkarty(0))
                Hrac(l).listkarty.RemoveAt(0)
            Loop
            For i = 0 To 1
                cislo = r.Next(0, karty.Count)
                Hrac(l).listkarty.Add(karty(cislo))
                karty.RemoveAt(cislo)
            Next
            Hrac(l).vemkarty()
        Next
    End Sub


    Private Sub karta_klik(sender As Object, e As EventArgs)
        Dim k As Karta = CType(sender, Karta)
        k.Otocena = Not k.Otocena
        k.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        rozdanikaretstul(3, 3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        rozdanikaretstul(4, 4)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To pocethracu - 1
            ListBox1.Items.Add(Hrac(i).kombinace & " " & Hrac(i).hodnotakombinace)
        Next

        ListBox1.Items.Add(kombinacetext(stul) & " " & ohodnocenikombinace(stul))
    End Sub

    Private Sub blinds()

        If pocethracu = 1 Then
            If pomocnacislo = 0 Then
                jasb = True
                mojechipy -= SmallBlind
                Hrac(0).BigBlind = BigBlind
                ListBox1.Items.Add("Hráč 0 Big Blind: " & BigBlind)
                ListBox1.Items.Add("Vy - Small Blind: " & SmallBlind)
                mojepredchozisazka = SmallBlind
                pomocnacislo += 1

            ElseIf pomocnacislo = 1 Then
                mojechipy -= BigBlind
                Hrac(0).SmallBlind = SmallBlind
                ListBox1.Items.Add("Vy - Big Blind: " & BigBlind)
                ListBox1.Items.Add("Hráč 0 Small Blind: " & SmallBlind)
                mojepredchozisazka = BigBlind
                pomocnacislo = 0

            End If

        Else
        For i = 0 To pocethracu
            If i = blindypocitani Then
                If i + 1 = pocethracu Then
                    mojechipy -= BigBlind
                    Hrac(i).SmallBlind = SmallBlind
                    ListBox1.Items.Add("Vy - Big Blind: " & BigBlind)
                    ListBox1.Items.Add("Hráč " & i & " Small Blind: " & SmallBlind)
                    mojepredchozisazka = BigBlind
                ElseIf i = pocethracu Then
                    jasb = True
                    blindypocitani = 0
                    mojechipy -= SmallBlind
                    Hrac(0).BigBlind = BigBlind
                    ListBox1.Items.Add("Vy - Small Blind: " & SmallBlind)
                    ListBox1.Items.Add("Hráč 0 Big Blind: " & BigBlind)
                    mojepredchozisazka = SmallBlind

                Else
                    Hrac(i + 1).BigBlind = BigBlind
                    Hrac(i).SmallBlind = SmallBlind
                    ListBox1.Items.Add("Hráč " & i & " Small Blind: " & SmallBlind)
                    ListBox1.Items.Add("Hráč " & i + 1 & " Big Blind: " & BigBlind)
                End If
            End If
        Next
        End If

        maxsazka = BigBlind
        pot += BigBlind + SmallBlind
        lblpot.Text = "Pot: " & pot
        blindypocitani += 1

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timerlogikahry.Tick
        cas += 1

        lblmojechips.Text = mojechipy

        If cas > 2 Then
            kontrolahracuvehre()
        End If

        If mojechipy <= 0 Then
            allin = True
        End If

      

        If cas = 1 Then
            If BigBlind > 0 Then
                blinds()
            End If


            If mojechipy <= 0 Then
                Timerlogikahry.Stop()
                MsgBox("Prohráli ste všechny žetony")
                Me.Close()
                Form2.Show()
            Else
                allin = False
            End If

            rozdanikarethracum()
            stavhry = -1
            kontrola = False
            jaodp = False
            odpovedvsech = False
        End If

        If cas = 2 Then
            stavstul = True
        End If

        If stavstul = True Then
            If odpovedvsech = False Then
                If pocitani = pocethracu Then

                    If jafold = False And jaodp = False And allin = False Then
                        Timerlogikahry.Stop()
                        If maxsazka > mojechipy Then
                            btncheck.Enabled = True
                            btnfold.Enabled = True
                        Else
                            btnfold.Enabled = True
                            btncheck.Enabled = True
                            btnraise.Enabled = True
                            numsazka.Enabled = True
                        End If
                        numsazka.Minimum = 1
                        numsazka.Maximum = mojechipy - maxsazka
                        If maxsazka > 0 Then
                            btncheck.Text = "Call: " & maxsazka - mojepredchozisazka
                            If maxsazka = mojepredchozisazka Then
                                btncheck.Text = "Check"
                            End If
                        Else
                            btncheck.Text = "Check"
                        End If

                        
                        
                    End If


                    If jafold = False And jaodp = True Then
                        If kontrola = False Then
                            kontrolavseho()
                        End If
                    End If

                    If (jafold = True) Or (allin = True) Then
                        If kontrola = False Then
                            kontrolavseho()
                        End If
                    End If

                Else

                    odpovedhrace(pocitani)
                    pocitani += 1
                End If

            Else

                If stavhry = 0 Then 'Flop
                    rozdanikaretstul(0, 2)
                    pocitani = 0
                    odpovedvsech = False
                    kontrola = False
                    jaodp = False
                End If

                If stavhry = 1 Then 'Turn
                    rozdanikaretstul(3, 3)
                    pocitani = 0
                    odpovedvsech = False
                    kontrola = False
                    jaodp = False
                End If

                If stavhry = 2 Then 'River
                    rozdanikaretstul(4, 4)
                    pocitani = 0
                    odpovedvsech = False
                    kontrola = False
                    jaodp = False
                End If


                If stavhry = 3 Then 'konec hry

                    For i = 0 To pocethracu - 1
                        If Hrac(i).Nehraje = False Then
                            Hrac(i).listkarty(0).Otocena = True
                            Hrac(i).listkarty(1).Otocena = True
                            Hrac(i).listkarty(0).Refresh()
                            Hrac(i).listkarty(1).Refresh()
                        End If
                    Next
                    ukazanikaret = True
                    stavhry = 4
                End If
                If ukazanikaret = True Then

                    cas = 20
                    ukazanikaret = False
                    konec = True

                End If

                If cas = 22 And konec = True Then
                    konechry()
                End If

            End If
        End If



    End Sub

    Private Sub kontrolavseho()

        If kontrolahracusazky() = 0 Then
            kontrola = True
            odpovedvsech = True
            stavhry += 1
            maxsazka = 0
            mojepredchozisazka = 0
        Else
            kontrolahracusazky()
        End If
    End Sub

    Private Sub kontrolahracuvehre()

        hracuvehre = 0
        For i = 0 To pocethracu - 1
            If Hrac(i).Nehraje = False Then
                hracuvehre += 1
            End If
        Next

        If hracuvehre = 1 Then
            If jafold = True Then
                For i = 0 To pocethracu - 1
                    If Hrac(i).Nehraje = False Then
                        nikdonastole = True
                        Hrac(i).odebranikaret()
                        Hrac(i).vyhra = pot
                        konechry()
                    End If
                Next

            End If

        End If

        If hracuvehre = 0 And jafold = False Then
            mojechipy += pot

            nikdonastole = True
            javitez = True
            konechry()
        End If

   


    End Sub


    Private Function kombinacetext(kartyzestolu As List(Of Karta)) As String

        If jafold = False Then

            Dim par As Integer = 0
            kombinacetext = "High card"
            Dim kartystul As New List(Of Karta)
            Dim pomlist As New List(Of Karta)
            Dim predchozikombinace As Integer
            Dim kombinace As Integer
            Dim barva As Integer
            Dim onepair As Boolean = False


            kartystul.Add(hracja(0))
            kartystul.Add(hracja(1))

            If stul.Count > 0 Then
                For i = 0 To stul.Count - 1
                    kartystul.Add(stul(i))
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
                            If par >= 3 Then
                                kombinacetext = "Full-house"
                            Else
                                kombinacetext = "Trojicka"
                            End If
                        Case 3
                            kombinacetext = "Poker"
                        Case 5
                            kombinacetext = "Flush"
                    End Select
                    predchozikombinace = kombinace
                End If
                pomlist.RemoveAt(0)
            Next

            Dim postupkahodnota As Integer = 0

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
                            End If

                            If postupkahodnota = 4 And predchozikombinace < 4 Then
                                predchozikombinace = 4
                                kombinacetext = "Straight"
                                kombinace = 4
                                poradikombinace = 4
                            End If

                        End If
                    Next
                Next
                Do While pomlist.Count > 0
                    pomlist.RemoveAt(0)
                Loop
                postupkahodnota = 0
            Next
        Else
            Return 0
        End If
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
            Case "Straight"
                ohodnocenikombinace = 4
            Case "Flush"
                ohodnocenikombinace = 5
            Case "Straight Flush"
                ohodnocenikombinace = 8
        End Select

    End Function



    Public Sub urceniviteze()

        If jafold = False Then
            poradikombinace = ohodnocenikombinace(stul)
        End If



        Dim prirazeni As Boolean = False


        For i = 0 To pocethracu - 1
            If Hrac(i).Nehraje = False Then
                If prirazeni = False Then
                    potencialnivitezove.Add(Hrac(i))
                    prirazeni = True
                Else
                    If Hrac(i).hodnotakombinace > potencialnivitezove(0).hodnotakombinace Then
                        Do While potencialnivitezove.Count > 0
                            potencialnivitezove.RemoveAt(0)
                        Loop
                        potencialnivitezove.Add(Hrac(i))
                    End If

                    If Hrac(i).hodnotakombinace = potencialnivitezove(0).hodnotakombinace Then

                        For j = 0 To potencialnivitezove.Count - 1
                            If Hrac(i).kickerhodnota > potencialnivitezove(j).kickerhodnota Then
                                Do While potencialnivitezove.Count > 0
                                    potencialnivitezove.RemoveAt(0)
                                Loop
                                potencialnivitezove.Add(Hrac(i))
                            End If

                            If Hrac(i).kickerhodnota = potencialnivitezove(j).kickerhodnota Then
                                potencialnivitezove.Add(Hrac(i))
                            End If
                        Next

                        potencialnivitezove.Add(Hrac(i))
                    End If

                End If
            End If
        Next

        For i = 0 To potencialnivitezove.Count - 1

        Next


        If jafold = False Then
            If potencialnivitezove(0).hodnotakombinace = poradikombinace Then


                If potencialnivitezove(0).kickerhodnota > jakicker Then
                    Dim pocet1 As Integer = potencialnivitezove.Count
                    If pocet1 = 0 Then
                        pocet1 = 1
                    End If
                    For j = 0 To potencialnivitezove.Count - 1
                        potencialnivitezove(j).vyhra = (pot / pocet1)
                    Next
                End If



                If potencialnivitezove(0).kickerhodnota = jakicker Then
                    Dim pocet As Integer = potencialnivitezove.Count
                    If pocet = 0 Then
                        pocet = 2
                    End If
                    Dim vyhra As Integer = pot / pocet
                    For j = 0 To potencialnivitezove.Count - 1
                        potencialnivitezove(j).vyhra = vyhra
                    Next
                    mojechipy = vyhra
                    lblmojechips.Text = mojechipy
                    javitez = False
                End If

                If potencialnivitezove(0).kickerhodnota < jakicker Then
                   
                    mojechipy += pot
                    lblmojechips.Text = mojechipy
                End If

            End If
            If potencialnivitezove(0).hodnotakombinace > poradikombinace Then
                Dim pocet As Integer = potencialnivitezove.Count
                If pocet = 0 Then
                    pocet = 1
                End If
                For j = 0 To potencialnivitezove.Count - 1
                    potencialnivitezove(j).vyhra = (pot / pocet)
                Next
            End If
            If potencialnivitezove(0).hodnotakombinace < poradikombinace Then
                
                mojechipy += pot
                lblmojechips.Text = mojechipy
            End If
        Else
            Dim pocet As Integer = potencialnivitezove.Count
            If pocet = 0 Then
                pocet = 1
            End If
            For j = 0 To potencialnivitezove.Count - 1
                potencialnivitezove(j).vyhra = (pot / pocet)
            Next
        End If
   

        Do While potencialnivitezove.Count > 0
            potencialnivitezove.RemoveAt(0)
        Loop

    End Sub

    Private Sub konechry()

        If nikdonastole = False Then
            urceniviteze()
        End If


        For i = 0 To pocethracu - 1

            Hrac(i).novahra()

        Next


        pot = 0
        lblpot.Text = "Pot: " & pot
        lblmojechips.Text = mojechipy
        maxsazka = 0

        stavhry = -1
        pocitani = 0
        stavstul = False
        odpovedvsech = False
        kontrola = False
        ukazanikaret = False
        odebranikarethracum()
        odebranikaret()
        jafold = False
        jaodp = False
        nikdonastole = False
        jasb = False
        mojepredchozisazka = 0
        konec = False
        Do While zahozene.Count > 0
            karty.Add(zahozene(0))
            zahozene.RemoveAt(0)
        Loop

        cas = -1



    End Sub


    Private Function kontrolahracusazky()
        For i = 0 To pocethracu - 1
            kontrolasazek = 0
            If Hrac(i).Nehraje = False Then
                If Hrac(i).Poslednisazka < maxsazka Then
                    odpovedhrace(i)
                    kontrolasazek += 1
                End If
                If jafold = False Then
                    If daldohry < maxsazka Then
                        kontrolasazek -= 1
                    End If
                End If
                
            End If
        Next

        Return kontrolasazek
    End Function

    Private Sub odpovedhrace(l As Integer)
        If Hrac(l).Nehraje = False Then

            Hrac(l).hrej(maxsazka)


            If Hrac(l).Rozhodnutif = -1 Then
                odp = "Fold"
            End If

            If Hrac(l).Rozhodnutif = -2 Then
                odp = "Check"
            End If

            If Hrac(l).Rozhodnutif > 0 Then

                If Hrac(l).Rozhodnutif = maxsazka Then
                    odp = "Call"
                    pot += maxsazka
                    lblpot.Text = "Pot: " & pot
                ElseIf Not Hrac(l).Rozhodnutif = maxsazka Then
                    odp = "Raise: " & Hrac(l).Rozhodnutif
                    maxsazka = Hrac(l).Rozhodnutif
                    pot += maxsazka
                    lblpot.Text = "Pot: " & pot
                End If

            End If
            ListBox1.Items.Add("Hráč " & l & " - " & odp)
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnraise.Click
        jaodp = True
        If maxsazka > 0 Then
        
            maxsazka = numsazka.Value + maxsazka
            mojechipy -= (numsazka.Value + maxsazka)
            lblmojechips.Text = mojechipy
            pot += numsazka.Value + maxsazka
            lblpot.Text = "Pot: " & pot
            ListBox1.Items.Add("Vy - Raise: " & numsazka.Value + maxsazka)

        ElseIf maxsazka = 0 Then

            maxsazka = numsazka.Value
            mojechipy = mojechipy - numsazka.Value
            lblmojechips.Text = mojechipy
            pot += maxsazka
            lblpot.Text = "Pot: " & pot
            ListBox1.Items.Add("Vy - Raise: " & maxsazka)
        End If

        btnfold.Enabled = False
        btncheck.Enabled = False
        btnraise.Enabled = False
        numsazka.Enabled = False


        If mojechipy <= 0 Then
            lblmojechips.Text = "All-in"
        End If

        Timerlogikahry.Start()
    End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        jaodp = True
        If maxsazka > 0 Then
           
            If mojechipy < maxsazka Then
                ListBox1.Items.Add("Vy - Call")
                lblmojechips.Text = "All-in"
                pot += mojechipy
                mojechipy = 0
                allin = True
                lblpot.Text = "Pot: " & pot
                mojepredchozisazka = mojechipy
            Else
                If mojepredchozisazka = maxsazka Then

                    ListBox1.Items.Add("Vy - Check")
                Else

                    ListBox1.Items.Add("Vy - Call")
                End If

                mojechipy -= maxsazka - mojepredchozisazka
                lblmojechips.Text = mojechipy
                pot += maxsazka - mojepredchozisazka
                lblpot.Text = "Pot: " & pot
                mojepredchozisazka = maxsazka - mojepredchozisazka
                daldohry = maxsazka
            End If
        Else
            ListBox1.Items.Add("Vy - Check")
        End If

        btnfold.Enabled = False
        btncheck.Enabled = False
        btnraise.Enabled = False
        numsazka.Enabled = False
        Timerlogikahry.Start()
    End Sub

    Private Sub btnfold_Click(sender As Object, e As EventArgs) Handles btnfold.Click
        jaodp = True
        jafold = True

        ListBox1.Items.Add("Vy - Fold")
        Do While panelja.Controls.Count > 0
            panelja.Controls.RemoveAt(0)
        Loop

        Do While hracja.Count > 0
            zahozene.Add(hracja(0))
            hracja.RemoveAt(0)
        Loop

        btnfold.Enabled = False
        btncheck.Enabled = False
        btnraise.Enabled = False
        numsazka.Enabled = False

        Timerlogikahry.Start()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles btnnovahra.Click

        Form2.Show()
        Me.Close()

    End Sub

    Private Sub btnnovahra_MouseHover(sender As Object, e As EventArgs) Handles btnnovahra.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub btnnovahra_MouseLeave(sender As Object, e As EventArgs) Handles btnnovahra.MouseLeave
        Cursor = Cursors.Default
    End Sub

End Class



