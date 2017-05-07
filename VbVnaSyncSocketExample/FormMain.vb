'Copyright ©2017 Copper Mountain Technologies
'
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
' to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
' and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
' MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR
' ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
' THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Imports System.Net.Sockets
Imports System.Text

Public Class FormMain

    Dim ip As String
    Dim port As Integer

    Dim client As TcpClient
    Dim stream As NetworkStream

    Dim command As String
    Dim response As String

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' you can use 'localhost' as the ip address when the vna software is running on the same pc
        ' if the vna software is running on a different pc you will need to enter the ip address of that pc
        ip = "localhost"
        textBoxIP.Text = ip

        ' 5025 is the vna's default tcp server port but can be changed on the vna by clicking system -> network setup
        port = 5025
        textBoxPort.Text = port.ToString

        ' this setting causes the log text box to auto-scroll
        richTextBoxLog.HideSelection = False

    End Sub

    Private Sub buttonTest_Click(sender As Object, e As EventArgs) Handles buttonTest.Click

        Dim textReceived As String = ""

        buttonTest.Enabled = False

        ' :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        ' connect to the vna tcp server
        Try
            client = New TcpClient
            client.Connect(textBoxIP.Text, port)
        Catch
            appendToTextBoxLogGpib("Connection Failed..." & Chr(13) & Chr(10))
            buttonTest.Enabled = True
            Return
        End Try
        appendToTextBoxLogGpib("Connected to Socket" & Chr(13) & Chr(10))

        ' get the client stream for reading and writing
        stream = client.GetStream

        ' -------------------------------------------------------------------------------------------------------------

        ' send command to get id string
        command = "*IDN?"
        send(command)
        appendToTextBoxLogGpib(">> " + command)

        ' get response
        response = receive()
        If Not response = "" Then
            appendToTextBoxLogGpib("<< " + response)
        End If

        ' -------------------------------------------------------------------------------------------------------------

        ' send command to turn on memory trace
        command = "CALCulate1:MATH:MEMorize"
        send(command)
        appendToTextBoxLogGpib(">> " + command)

        ' -------------------------------------------------------------------------------------------------------------

        ' send command select data math
        command = "CALCulate1:MATH:FUNCtion MULTiply"
        send(command)
        appendToTextBoxLogGpib(">> " + command)

        ' -------------------------------------------------------------------------------------------------------------

        ' send command to read selected data math
        command = "CALCulate1:MATH:FUNCtion?"
        send(command)
        appendToTextBoxLogGpib(">> " + command)

        ' get response
        response = receive()
        If Not response = "" Then
            appendToTextBoxLogGpib("<< " + response)
        End If

        ' -------------------------------------------------------------------------------------------------------------

        ' close everything
        stream.Close()
        client.Close()
        appendToTextBoxLogGpib("Disconnected from Socket" & Chr(13) & Chr(10))

        ' :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        buttonTest.Enabled = True

    End Sub

    Private Sub send(data As String)

        Try

            ' append cr and lf
            data = data & Chr(13) & Chr(10)

            ' translate the message into ascii and store it as a byte array
            Dim bytesSent As [Byte]() = Encoding.ASCII.GetBytes(data)

            ' send the message to the connected tcp server
            stream.Write(bytesSent, 0, bytesSent.Length)

        Catch ex As ArgumentNullException

            Console.WriteLine("ArgumentNullException: {0}", ex)

        Catch ex As SocketException

            Console.WriteLine("SocketException: {0}", ex)

        End Try

    End Sub

    Private Function receive()

        Dim data As String = ""

        Try

            ' receive the response
            Dim bytesReceived(1023) As Byte
            Dim numBytesReceived As Integer = stream.Read(bytesReceived, 0, bytesReceived.Length)
            data = Encoding.ASCII.GetString(bytesReceived, 0, numBytesReceived)

        Catch ex As ArgumentNullException

            Console.WriteLine("ArgumentNullException: {0}", ex)

        Catch ex As SocketException

            Console.WriteLine("SocketException: {0}", ex)

        End Try

        Return data

    End Function

    Private Sub appendToTextBoxLogGpib(s As String)

        ' append time stamp, text string, and new line
        s = s.Replace("\r", "")
        s = s.Replace("\n", "")
        richTextBoxLog.AppendText(DateTime.Now.ToString("hh:mm:ss.fff tt") + ": " + s + Environment.NewLine)

    End Sub

End Class