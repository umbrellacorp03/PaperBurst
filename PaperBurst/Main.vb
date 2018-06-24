Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports MigraDoc.Rendering
Imports MigraDoc.DocumentObjectModel.Tables
Imports MigraDoc.DocumentObjectModel
Imports System.Numerics
Imports System.Security.Cryptography
Imports QRCoder
Imports System.Text

Public Class Home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Generate.Click
        'Creation of a new pdf doc, with a new page
        Dim pdf As PdfDocument = New PdfDocument
        Dim pdfPage As PdfPage = pdf.AddPage
        Dim graph As XGraphics = XGraphics.FromPdfPage(pdfPage)

        'Setting font and format
        Dim font As XFont = New XFont("Arial", 8, XFontStyle.Bold)
        Dim font2 As XFont = New XFont("NotoSans", 13, XFontStyle.Bold)
        Dim format As XStringFormat = New XStringFormat()
        Dim rect As XRect = New XRect(100, 30, XUnit.FromCentimeter(7), XUnit.FromCentimeter(2))

        'Storing the generated Passphrase, Public Key, Private Key, and Account RS
        Dim Passphrase1 As String = Passphrase.Text
        Dim PublicKey As String = PublicKey1.Text
        Dim PrivateKey As String = PrivateKey1.Text
        Dim AccountRS As String = ReedSolomonAddress.Text

        'Generating new random strings for gibberish QR Code
        Dim r As New Random
        Dim strings As New List(Of String)
        Dim strings2 As New List(Of String)
        For i As Integer = 1 To 1
            strings.Add(RandomString(r))
        Next
        For i As Integer = 1 To 4
            strings2.Add(RandomString(r))
        Next

        Dim rand1 As String = String.Join("", strings)
        Dim rand2 As String = String.Join("", strings2)

        'Setting settings of pdf page 
        pdfPage.Orientation = PageOrientation.Landscape
        pdfPage.Width = XUnit.FromCentimeter(29.7)
        pdfPage.Height = XUnit.FromCentimeter(21)

        If (Passphrase.Text = "") Then
            MsgBox("The passphrase is empty!")
        Else
            'Adding the "background" to the pdf page
            Dim background As Image = My.Resources.Backg
            graph.DrawImage(background, XUnit.FromCentimeter(0), XUnit.FromCentimeter(0), XUnit.FromCentimeter(29.7), XUnit.FromCentimeter(21))

            'Generating the QR Code for the Account RS
            Dim qrGenerator As QRCodeGenerator = New QRCodeGenerator()
            Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(AccountRS, QRCodeGenerator.ECCLevel.Q)
            Dim qrCode As QRCode = New QRCode(qrCodeData)
            Dim qrCodeImage As Bitmap = qrCode.GetGraphic(20)
            graph.DrawImage(qrCodeImage, XUnit.FromCentimeter(9.125), XUnit.FromCentimeter(10.325), XUnit.FromCentimeter(3.8), XUnit.FromCentimeter(3.8))

            'Writing the Account RS
            graph.DrawString(AccountRS, font, XBrushes.Black, XUnit.FromCentimeter(8.8), XUnit.FromCentimeter(10))

            'Generating the QR Code for the Passphrase
            qrCodeData = qrGenerator.CreateQrCode(Passphrase1, QRCodeGenerator.ECCLevel.Q)
            qrCode = New QRCode(qrCodeData)
            qrCodeImage = qrCode.GetGraphic(20)
            graph.DrawString(AccountRS, font, XBrushes.Black, XUnit.FromCentimeter(16.325), XUnit.FromCentimeter(10))
            graph.DrawImage(qrCodeImage, XUnit.FromCentimeter(16.625), XUnit.FromCentimeter(10.325), XUnit.FromCentimeter(3.8), XUnit.FromCentimeter(3.8))

            'Generating the first gibberish QR Code
            qrCodeData = qrGenerator.CreateQrCode(rand1, QRCodeGenerator.ECCLevel.Q)
            qrCode = New QRCode(qrCodeData)
            qrCodeImage = qrCode.GetGraphic(20)
            graph.DrawImage(qrCodeImage, XUnit.FromCentimeter(1.425), XUnit.FromCentimeter(10.325), XUnit.FromCentimeter(3.8), XUnit.FromCentimeter(3.8))

            'Generating the second gibberish QR Code
            qrCodeData = qrGenerator.CreateQrCode(rand2, QRCodeGenerator.ECCLevel.Q)
            qrCode = New QRCode(qrCodeData)
            qrCodeImage = qrCode.GetGraphic(20)
            graph.DrawImage(qrCodeImage, XUnit.FromCentimeter(24.425), XUnit.FromCentimeter(10.325), XUnit.FromCentimeter(3.8), XUnit.FromCentimeter(3.8))

            'Using Migradoc to generate a paragraph and use autowrap function
            'Warning : Only works with separate words - long strings will not be cropped/auto-wrapped
            genPassphrase(pdf, Passphrase1, graph)

            'Adding see-through protection for the passphrase
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(14.815))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(14.9))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(15.015))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(15.115))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(15.215))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(15.315))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(15.415))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(15.515))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(15.615))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(15.715))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(15.815))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(15.915))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(23.735), XUnit.FromCentimeter(16.015))

            'Adding see-through protection for the infos of the account
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(14.815))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(14.915))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(15.015))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(15.115))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(15.215))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(15.315))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(15.415))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(15.515))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(15.615))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(15.715))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(15.815))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(15.915))
            graph.DrawString("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", font, XBrushes.Black, XUnit.FromCentimeter(0.775), XUnit.FromCentimeter(16.015))

            'Creating a second pdf page
            Dim pdfPage2 As PdfPage = pdf.AddPage
            Dim graph2 As XGraphics = XGraphics.FromPdfPage(pdfPage2)
            pdfPage2.Orientation = PageOrientation.Landscape
            pdfPage2.Width = XUnit.FromCentimeter(29.7)
            pdfPage2.Height = XUnit.FromCentimeter(21)

            'Adding instructions
            Dim instructions As Image = My.Resources.Instructions
            graph2.DrawImage(instructions, XUnit.FromCentimeter(0), XUnit.FromCentimeter(0), XUnit.FromCentimeter(29.7), XUnit.FromCentimeter(21))

            Dim dialog As New FolderBrowserDialog()
            dialog.RootFolder = Environment.SpecialFolder.Desktop
            dialog.Description = "Select a folder to save the generated paper wallet."
            If dialog.ShowDialog() = DialogResult.OK Then
                Dim cpath As String = dialog.SelectedPath & "\" & AccountRS & ".pdf"
                pdf.Save(cpath)
                Process.Start(cpath)
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles GeneratePassphrase.Click
        Dim KeySeed As String = ""
        Dim curwords As String = ""
        Dim PrivateKey As Byte()
        Dim PublicKey As Byte()
        Dim PublicKeyHash As Byte()

        If (RadioButton1.Checked = True) Then
            Passphrase.Text = MakeSeed(12)

        ElseIf (RadioButton2.Checked = True) Then
            Passphrase.Text = MakeSeed(24)

        End If

        KeySeed = Passphrase.Text
        Dim cSHA256 As SHA256 = SHA256Managed.Create()

        'create private key
        PrivateKey = cSHA256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(KeySeed))
        PrivateKey1.Text = BytesToHexString(PrivateKey)

        'create public key
        PublicKey = Curve25519.GetPublicKey(PrivateKey)
        PublicKey1.Text = BytesToHexString(PublicKey)

        'create public key hash
        PublicKeyHash = cSHA256.ComputeHash(PublicKey)

        'create numeric account id
        Dim b = New Byte() {PublicKeyHash(0), PublicKeyHash(1), PublicKeyHash(2), PublicKeyHash(3), PublicKeyHash(4), PublicKeyHash(5), PublicKeyHash(6), PublicKeyHash(7)}
        If (b(b.Length - 1) And &H80) <> 0 Then
            Array.Resize(Of Byte)(b, b.Length + 1)
        End If
        Dim Bint As New BigInteger(b)

        'Create RS-Address
        ReedSolomonAddress.Text = "BURST-" & ReedSolomon.encode(Bint.ToString)

    End Sub
    Private Function BytesToHexString(ByVal bArray As Byte()) As String
        Dim HexString As String = ""
        Dim buffer As String = ""
        For Each b As Byte In bArray
            buffer = Conversion.Hex(b)
            If buffer.Length = 1 Then buffer = "0" & buffer
            HexString &= buffer
        Next
        Return HexString
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim KeySeed As String = ""
        Dim curwords As String = ""
        Dim AccountID As String
        Dim PrivateKey As Byte()
        Dim PublicKey As Byte()
        Dim PublicKeyHash As Byte()

        If (Passphrase.Text = "") Then
            MsgBox("The passphrase is empty!")
        Else
            KeySeed = Passphrase.Text
            Dim cSHA256 As SHA256 = SHA256Managed.Create()

            'create private key
            PrivateKey = cSHA256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(KeySeed))
            PrivateKey1.Text = BytesToHexString(PrivateKey)

            'create public key
            PublicKey = Curve25519.GetPublicKey(PrivateKey)
            PublicKey1.Text = BytesToHexString(PublicKey)

            'create public key hash
            PublicKeyHash = cSHA256.ComputeHash(PublicKey)

            'create numeric account id
            Dim b = New Byte() {PublicKeyHash(0), PublicKeyHash(1), PublicKeyHash(2), PublicKeyHash(3), PublicKeyHash(4), PublicKeyHash(5), PublicKeyHash(6), PublicKeyHash(7)}
            If (b(b.Length - 1) And &H80) <> 0 Then
                Array.Resize(Of Byte)(b, b.Length + 1)
            End If

            Dim Bint As New BigInteger(b)
            'Account ID
            AccountID = Bint.ToString

            'Create RS-Address
            ReedSolomonAddress.Text = "BURST-" & ReedSolomon.encode(Bint.ToString)
        End If
    End Sub
    Private Shared Sub genPassphrase(ByVal document As PdfDocument, passphrase As String, graph As XGraphics)

        Dim font As Font = New Font("Arial", 7)

        Dim doc As Document = New Document()
        Dim sec As Section = doc.AddSection()
        Dim paragraph As Paragraph = New Paragraph

        Dim table As Table = New Table()

        Dim column As Column = table.AddColumn(Unit.FromCentimeter(5.5))
        column.Format.Alignment = ParagraphAlignment.Center

        Dim row As Row = table.AddRow()

        Dim cell As Cell = row.Cells(0)
        cell.Format.Font = font
        cell.AddParagraph(passphrase)

        doc.LastSection.Add(table)

        Dim docRenderer As DocumentRenderer = New DocumentRenderer(doc)

        docRenderer.PrepareDocument()
        docRenderer.RenderObject(graph, XUnit.FromCentimeter(15.775), XUnit.FromCentimeter(14.69), XUnit.FromCentimeter(1), table)

    End Sub
    Private Sub revealPwd_Click(sender As Object, e As EventArgs) Handles revealPwd.Click

        If (Passphrase.PasswordChar = "*") Then
            Passphrase.PasswordChar = ""
        Else
            Passphrase.PasswordChar = "*"
        End If

    End Sub
    Private Sub revealPK_Click(sender As Object, e As EventArgs) Handles revealPK.Click

        If (PrivateKey1.PasswordChar = "*") Then
            PrivateKey1.PasswordChar = ""
        Else
            PrivateKey1.PasswordChar = "*"
        End If

    End Sub
    Private Sub Passphrase_TextChanged(sender As Object, e As EventArgs) Handles Passphrase.TextChanged
        Dim KeySeed As String = ""
        Dim curwords As String = ""
        Dim PrivateKey As Byte()
        Dim PublicKey As Byte()
        Dim PublicKeyHash As Byte()

        KeySeed = Passphrase.Text
        Dim cSHA256 As SHA256 = SHA256Managed.Create()

        'create private key
        PrivateKey = cSHA256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(KeySeed))
        PrivateKey1.Text = BytesToHexString(PrivateKey)

        'create public key
        PublicKey = Curve25519.GetPublicKey(PrivateKey)
        PublicKey1.Text = BytesToHexString(PublicKey)

        'create public key hash
        PublicKeyHash = cSHA256.ComputeHash(PublicKey)

        'create numeric account id
        Dim b = New Byte() {PublicKeyHash(0), PublicKeyHash(1), PublicKeyHash(2), PublicKeyHash(3), PublicKeyHash(4), PublicKeyHash(5), PublicKeyHash(6), PublicKeyHash(7)}
        If (b(b.Length - 1) And &H80) <> 0 Then
            Array.Resize(Of Byte)(b, b.Length + 1)
        End If
        Dim Bint As New BigInteger(b)

        'Create RS-Address
        ReedSolomonAddress.Text = "BURST-" & ReedSolomon.encode(Bint.ToString)

    End Sub
    Function RandomString(r As Random)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(15, 33)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function MakeSeed(ByVal nrWords As Integer) As String
        Dim KeySeed As String = ""
        Dim RNGCSP As RNGCryptoServiceProvider = New RNGCryptoServiceProvider()
        Dim rngdata((nrWords * 2) - 1) As Byte
        RNGCSP.GetBytes(rngdata)
        For t As Integer = 0 To (nrWords * 2) - 1 Step 2
            KeySeed &= SGlobal.PassPhraseWords(((rngdata(t) * 256) + rngdata(t + 1)) Mod 1626) & " "
        Next
        If KeySeed.Length > 0 Then
            Return Mid(KeySeed, 1, KeySeed.Length - 1)
        End If
        Return ""
    End Function
End Class