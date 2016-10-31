<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ActiveSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.PortsListBox = New System.Windows.Forms.ListBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ActiveSerialPort
        '
        Me.ActiveSerialPort.PortName = "COM4"
        '
        'PortsListBox
        '
        Me.PortsListBox.FormattingEnabled = True
        Me.PortsListBox.Location = New System.Drawing.Point(46, 30)
        Me.PortsListBox.Name = "PortsListBox"
        Me.PortsListBox.Size = New System.Drawing.Size(198, 186)
        Me.PortsListBox.TabIndex = 0
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(46, 248)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(96, 24)
        Me.ConnectButton.TabIndex = 1
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'StatusTextBox
        '
        Me.StatusTextBox.Location = New System.Drawing.Point(102, 222)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(141, 20)
        Me.StatusTextBox.TabIndex = 2
        Me.StatusTextBox.Text = "Not Connected"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Status:"
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(48, 280)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(194, 22)
        Me.RefreshButton.TabIndex = 4
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(148, 250)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(94, 22)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 399)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.PortsListBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ActiveSerialPort As IO.Ports.SerialPort
    Friend WithEvents PortsListBox As ListBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RefreshButton As Button
    Friend WithEvents CloseButton As Button
End Class
