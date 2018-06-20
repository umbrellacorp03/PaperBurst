Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports MigraDoc.Rendering
Imports MigraDoc.DocumentObjectModel.Tables
Imports MigraDoc.DocumentObjectModel
Imports System.Numerics
Imports System.Security.Cryptography
Imports QRCoder

Public Class Home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Generate.Click
        Dim pdf As PdfDocument = New PdfDocument
        Dim pdfPage As PdfPage = pdf.AddPage
        Dim graph As XGraphics = XGraphics.FromPdfPage(pdfPage)

        Dim font As XFont = New XFont("Arial", 8, XFontStyle.Bold)
        Dim format As XStringFormat = New XStringFormat()
        Dim rect As XRect = New XRect(100, 30, XUnit.FromCentimeter(7), XUnit.FromCentimeter(2))

        Dim Passphrase1 As String = Passphrase.Text
        Dim PublicKey As String = PublicKey1.Text
        Dim PrivateKey As String = PrivateKey1.Text
        Dim AccountRS As String = ReedSolomonAddress.Text

        pdfPage.Orientation = PageOrientation.Landscape
        pdfPage.Width = XUnit.FromCentimeter(29.7)
        pdfPage.Height = XUnit.FromCentimeter(21)

        If (Passphrase.Text = "") Then
            MsgBox("The passphrase is empty!")
        Else
            Dim background As Image = My.Resources.Backg
            graph.DrawImage(background, XUnit.FromCentimeter(0), XUnit.FromCentimeter(0), XUnit.FromCentimeter(29.7), XUnit.FromCentimeter(21))

            Dim qrGenerator As QRCodeGenerator = New QRCodeGenerator()
            Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(AccountRS, QRCodeGenerator.ECCLevel.Q)
            Dim qrCode As QRCode = New QRCode(qrCodeData)
            Dim qrCodeImage As Bitmap = qrCode.GetGraphic(20)
            graph.DrawImage(qrCodeImage, XUnit.FromCentimeter(9), XUnit.FromCentimeter(10.5), XUnit.FromCentimeter(4.2), XUnit.FromCentimeter(4.2))
            graph.DrawString(AccountRS, font, XBrushes.Black, XUnit.FromCentimeter(8.8), XUnit.FromCentimeter(10))

            qrCodeData = qrGenerator.CreateQrCode(Passphrase1, QRCodeGenerator.ECCLevel.Q)
            qrCode = New QRCode(qrCodeData)
            qrCodeImage = qrCode.GetGraphic(20)
            graph.DrawString(AccountRS, font, XBrushes.Black, XUnit.FromCentimeter(16.325), XUnit.FromCentimeter(10))
            graph.DrawImage(qrCodeImage, XUnit.FromCentimeter(16.5), XUnit.FromCentimeter(10.5), XUnit.FromCentimeter(4.2), XUnit.FromCentimeter(4.2))

            genPassphrase(pdf, Passphrase1, graph)

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
            Randomize()
            Dim value As Integer = 0
            KeySeed = SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd())))
            Passphrase.Text = KeySeed
        ElseIf (RadioButton2.Checked = True) Then
            Randomize()
            Dim value As Integer = 0
            KeySeed = SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd()))) & " "
            KeySeed &= SGlobal.PassPhraseWords(CInt(Int(1626 * Rnd())))
            Passphrase.Text = KeySeed
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

        Dim column As Column = table.AddColumn(Unit.FromCentimeter(5))
        column.Format.Alignment = ParagraphAlignment.Center

        Dim row As Row = table.AddRow()

        Dim cell As Cell = row.Cells(0)
        cell.Format.Font = font
        cell.AddParagraph(passphrase)

        doc.LastSection.Add(table)

        Dim docRenderer As DocumentRenderer = New DocumentRenderer(doc)

        docRenderer.PrepareDocument()
        docRenderer.RenderObject(graph, XUnit.FromCentimeter(16.15), XUnit.FromCentimeter(15.25), XUnit.FromCentimeter(1), table)

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
End Class