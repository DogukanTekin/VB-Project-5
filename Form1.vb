Public Class Form1
    Dim ilac_sayisi, ilac As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim isimler() As String = {"A", "S", "D", "F"}
        MsgBox(String.Join(TextBox1.Text, isimler))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim uzunluk As Integer = CInt(InputBox("Kaç Elemanlı Dizi İstiyorsunuz ?")) - 1
        Dim dizi(uzunluk) As String
        For i = 0 To uzunluk
            Dim veri As String = InputBox((i + 1).ToString() + ". Elemanı Giriniz")
            dizi(i) = veri
        Next
        Dim bol As String = InputBox("Araya Eklemek İstediğiniz Harfi Giriniz")
        MsgBox(String.Join(bol, dizi))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim kelime As String = InputBox("Kelimeyi Giriniz")
        Dim degisen As String = InputBox("Değişecek Harfi Giriniz")
        Dim yeniharf As String = InputBox("Yerine Koymak İstediğiniz Harfi Giriniz")
        MsgBox(kelime.Replace(degisen, yeniharf))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim kelime As String = InputBox("Kelimeyi Giriniz")
        Dim kactan As Integer = CInt(InputBox("Kaçıncı Harften Başlansın")) - 1
        Dim kaca As Integer = CInt(InputBox("Kaç Tane İlerlesin"))
        MsgBox(kelime.Remove(kactan, kaca))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim kelime As String = InputBox("Kelimeyi Giriniz")
        Dim sol As Integer = CInt(InputBox("Soldan Kaç Harf Gelsin"))
        Dim sag As Integer = CInt(InputBox("Sağdan Kaç Harf Gelsin"))
        MsgBox("Soldan " + sol.ToString() + " Kelime : " + Microsoft.VisualBasic.Left(kelime, sol))
        MsgBox("Sağdan " + sag.ToString() + " Kelime : " + Microsoft.VisualBasic.Right(kelime, sag))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox(Asc("Doğukan"))
        MsgBox(Asc("D"))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim kelime As String = InputBox("Kelimeyi Giriniz")
        Dim kactan As Integer = CInt(InputBox("Kaçıncı Harften Başlansın"))
        Dim kaca As Integer = CInt(InputBox("Kaç Tane İlerlesin"))
        MsgBox(Mid(kelime, kactan, kaca))
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Bu çözümde algoritma hatası mevcut
        ListBox1.Items.Clear()
        Dim kelime As String = InputBox("Kelimeyi Giriniz")
        Dim ayrikelime() As String
        If CheckBox1.Checked Then
            ayrikelime = kelime.Split(CheckBox1.Text)
        End If
        If CheckBox2.Checked Then
            ayrikelime = kelime.Split(CheckBox2.Text)
        End If
        If CheckBox3.Checked Then
            ayrikelime = kelime.Split(CheckBox3.Text)
        End If
        If CheckBox4.Checked Then
            ayrikelime = kelime.Split(CheckBox4.Text)
        End If
        For i = 0 To ayrikelime.Length - 1
            ListBox1.Items.Add(ayrikelime(i))
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim kelime As String = InputBox("Karşılaştırılacak kelimeleri giriniz")
        Dim richdizi(), inputdizi() As String
        inputdizi = kelime.Split(" ")
        richdizi = RichTextBox1.Text.Split(" ")
        For i = 0 To richdizi.Length - 1
            For j = 0 To inputdizi.Length - 1
                If richdizi(i).Equals(inputdizi(j)) Then
                    MsgBox("Aynı Kelime : " + richdizi(i))
                End If
            Next
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If CheckBox5.Checked And CheckBox6.Checked Then
            MsgBox("İkisi de işaretli")
        ElseIf CheckBox5.Checked And CheckBox6.Checked = False Then
            MsgBox("A İşaretli")
        ElseIf CheckBox6.Checked And CheckBox5.Checked = False Then
            MsgBox("B İşaretli")
        Else
            MsgBox("İkisi de işaretli değil")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ListBox2.Items.Clear()
        If CheckBox7.Checked Then
            ListBox2.Items.Add(CheckBox7.Text)
        Else
            MsgBox(CheckBox7.Text + " Dersini Almadınız")
        End If
        If CheckBox8.Checked Then
            ListBox2.Items.Add(CheckBox8.Text)
        Else
            MsgBox(CheckBox8.Text + " Dersini Almadınız")
        End If
        If CheckBox9.Checked Then
            ListBox2.Items.Add(CheckBox9.Text)
        Else
            MsgBox(CheckBox9.Text + " Dersini Almadınız")
        End If
        If CheckBox10.Checked Then
            ListBox2.Items.Add(CheckBox10.Text)
        Else
            MsgBox(CheckBox10.Text + " Dersini Almadınız")
        End If
        If CheckBox11.Checked Then
            ListBox2.Items.Add(CheckBox11.Text)
        Else
            MsgBox(CheckBox11.Text + " Dersini Almadınız")
        End If
        If CheckBox12.Checked Then
            ListBox2.Items.Add(CheckBox12.Text)
        Else
            MsgBox(CheckBox12.Text + " Dersini Almadınız")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckedListBox1.Items.Add("Aspirin")
        CheckedListBox1.Items.Add("Novalgin")
        CheckedListBox1.Items.Add("Augmentin")
        CheckedListBox3.Items.Add("Parol")
        CheckedListBox3.Items.Add("Augmentin")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim ekle As String = TextBox2.Text
        If CheckedListBox1.Items.Contains(ekle) Then
            MsgBox("Daha Önce Girilmiş İlaç Adı Girdiniz")
            TextBox2.Clear()
            TextBox2.Focus()
        Else
            CheckedListBox1.Items.Add(ekle)
            MsgBox("İlaç Eklendi")
            TextBox2.Clear()
            TextBox2.Focus()
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim eleman As Integer = CInt(InputBox("Kaçıncı Elemanı Silmek İstiyorsunuz ?"))
        CheckedListBox1.Items.RemoveAt(eleman - 1)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If CheckedListBox1.CheckedItems.Count = 0 Then
            MsgBox("Lütfen Silmek İstediğiniz İlaçları Seçiniz")
        Else
            Dim i As Integer
            For i = CheckedListBox1.CheckedItems.Count - 1 To 0 Step -1
                CheckedListBox1.Items.Remove(CheckedListBox1.CheckedItems(i))
            Next
            MsgBox("Silme İşlemi Başarılı")
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim sira As Integer = CInt(InputBox("Kaçıncı Sıraya Eklemek İstiyorsunuz ?"))
        Dim ekle As String = TextBox2.Text
        If CheckedListBox1.Items.Contains(ekle) Then
            MsgBox("Daha Önce Girilmiş İlaç Adı Girdiniz")
            TextBox2.Clear()
            TextBox2.Focus()
        Else
            CheckedListBox1.Items.Insert(sira - 1, ekle)
            MsgBox("İlaç Eklendi")
            TextBox2.Clear()
            TextBox2.Focus()
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim i As Integer = CheckedListBox2.Items.Count
        If (i < CInt(ilac_sayisi)) Then
            Dim giris As Boolean = False
            Do While (giris = False)
                ilac = InputBox((i + 1).ToString() + ". İlacı Giriniz")
                If CheckedListBox2.Items.Contains(ilac) Then
                    MsgBox("Daha Önce Girdiğiniz İlacı Tekrar Girdiniz")
                Else
                    CheckedListBox2.Items.Add(ilac)
                    MsgBox("Ekleme İşlemi Başarılı")
                    giris = True
                End If
            Loop
        Else
            MsgBox("Belirlediğiniz İlaç Sayısına Ulaştınız")
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If CheckedListBox2.CheckedItems.Count = 0 Then
            MsgBox("Lütfen Silmek İstediğiniz İlaçları Seçiniz")
        Else
            For eleman As Integer = CheckedListBox2.CheckedItems.Count - 1 To 0 Step -1
                CheckedListBox2.Items.Remove(CheckedListBox2.CheckedItems(eleman))
            Next
            MsgBox("Silme İşlemi Başarılı")
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        ListBox3.Items.Clear()
        If CheckedListBox2.CheckedItems.Count = 0 Then
            MsgBox("İlaç Seçmediniz")
        Else
            For eleman As Integer = 0 To CheckedListBox2.CheckedItems.Count - 1
                ListBox3.Items.Add(CheckedListBox2.CheckedItems(eleman))
            Next
            MsgBox("Aktarma İşlemi Başarılı")
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        For Each eleman In CheckedListBox3.CheckedItems
            If eleman.ToString() = "Augmentin" Then
                MsgBox("Antibiyotik")
            End If
            If eleman.ToString() = "Parol" Then
                MsgBox("Ateş Düşürücü")
            End If
        Next
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim sayisal As Boolean = False
        Do While (sayisal = False)
            ilac_sayisi = InputBox("Kaç Adet İlaç Girilecek ?")
            If IsNumeric(ilac_sayisi) Then
                sayisal = True
            Else
                MsgBox("Lütfen Sadece Sayısal Değer Giriniz")
            End If
        Loop
    End Sub
End Class
