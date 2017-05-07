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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.groupBoxServer = New System.Windows.Forms.GroupBox()
        Me.buttonTest = New System.Windows.Forms.Button()
        Me.textBoxPort = New System.Windows.Forms.TextBox()
        Me.labelIP = New System.Windows.Forms.Label()
        Me.textBoxIP = New System.Windows.Forms.TextBox()
        Me.labelPort = New System.Windows.Forms.Label()
        Me.groupBoxResponse = New System.Windows.Forms.GroupBox()
        Me.richTextBoxLog = New System.Windows.Forms.RichTextBox()
        Me.groupBoxServer.SuspendLayout()
        Me.groupBoxResponse.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBoxServer
        '
        Me.groupBoxServer.Controls.Add(Me.buttonTest)
        Me.groupBoxServer.Controls.Add(Me.textBoxPort)
        Me.groupBoxServer.Controls.Add(Me.labelIP)
        Me.groupBoxServer.Controls.Add(Me.textBoxIP)
        Me.groupBoxServer.Controls.Add(Me.labelPort)
        Me.groupBoxServer.Location = New System.Drawing.Point(13, 14)
        Me.groupBoxServer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupBoxServer.Name = "groupBoxServer"
        Me.groupBoxServer.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupBoxServer.Size = New System.Drawing.Size(692, 92)
        Me.groupBoxServer.TabIndex = 3
        Me.groupBoxServer.TabStop = False
        Me.groupBoxServer.Text = "Server"
        '
        'buttonTest
        '
        Me.buttonTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonTest.Location = New System.Drawing.Point(354, 26)
        Me.buttonTest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.buttonTest.Name = "buttonTest"
        Me.buttonTest.Size = New System.Drawing.Size(330, 54)
        Me.buttonTest.TabIndex = 4
        Me.buttonTest.Text = "&Test"
        Me.buttonTest.UseVisualStyleBackColor = True
        '
        'textBoxPort
        '
        Me.textBoxPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBoxPort.Location = New System.Drawing.Point(170, 49)
        Me.textBoxPort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textBoxPort.Name = "textBoxPort"
        Me.textBoxPort.ReadOnly = True
        Me.textBoxPort.Size = New System.Drawing.Size(66, 26)
        Me.textBoxPort.TabIndex = 2
        Me.textBoxPort.TabStop = False
        '
        'labelIP
        '
        Me.labelIP.AutoSize = True
        Me.labelIP.Location = New System.Drawing.Point(6, 26)
        Me.labelIP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelIP.Name = "labelIP"
        Me.labelIP.Size = New System.Drawing.Size(28, 20)
        Me.labelIP.TabIndex = 0
        Me.labelIP.Text = "&IP:"
        Me.labelIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textBoxIP
        '
        Me.textBoxIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBoxIP.Location = New System.Drawing.Point(10, 49)
        Me.textBoxIP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textBoxIP.Name = "textBoxIP"
        Me.textBoxIP.ReadOnly = True
        Me.textBoxIP.Size = New System.Drawing.Size(149, 26)
        Me.textBoxIP.TabIndex = 1
        Me.textBoxIP.TabStop = False
        '
        'labelPort
        '
        Me.labelPort.AutoSize = True
        Me.labelPort.Location = New System.Drawing.Point(165, 26)
        Me.labelPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelPort.Name = "labelPort"
        Me.labelPort.Size = New System.Drawing.Size(42, 20)
        Me.labelPort.TabIndex = 0
        Me.labelPort.Text = "&Port:"
        Me.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'groupBoxResponse
        '
        Me.groupBoxResponse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxResponse.Controls.Add(Me.richTextBoxLog)
        Me.groupBoxResponse.Location = New System.Drawing.Point(13, 116)
        Me.groupBoxResponse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupBoxResponse.Name = "groupBoxResponse"
        Me.groupBoxResponse.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupBoxResponse.Size = New System.Drawing.Size(690, 614)
        Me.groupBoxResponse.TabIndex = 5
        Me.groupBoxResponse.TabStop = False
        Me.groupBoxResponse.Text = "Response"
        '
        'richTextBoxLog
        '
        Me.richTextBoxLog.BackColor = System.Drawing.SystemColors.Control
        Me.richTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBoxLog.Location = New System.Drawing.Point(9, 29)
        Me.richTextBoxLog.Margin = New System.Windows.Forms.Padding(5)
        Me.richTextBoxLog.Name = "richTextBoxLog"
        Me.richTextBoxLog.ReadOnly = True
        Me.richTextBoxLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.richTextBoxLog.Size = New System.Drawing.Size(672, 575)
        Me.richTextBoxLog.TabIndex = 1
        Me.richTextBoxLog.TabStop = False
        Me.richTextBoxLog.Text = ""
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 744)
        Me.Controls.Add(Me.groupBoxResponse)
        Me.Controls.Add(Me.groupBoxServer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VNA Synchronous Socket Example"
        Me.groupBoxServer.ResumeLayout(False)
        Me.groupBoxServer.PerformLayout()
        Me.groupBoxResponse.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBoxServer As GroupBox
    Private WithEvents buttonTest As Button
    Private WithEvents textBoxPort As TextBox
    Private WithEvents labelIP As Label
    Private WithEvents textBoxIP As TextBox
    Private WithEvents labelPort As Label
    Private WithEvents groupBoxResponse As GroupBox
    Private WithEvents richTextBoxLog As RichTextBox
End Class
