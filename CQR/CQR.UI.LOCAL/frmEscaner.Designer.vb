﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEscaner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.vspEscaner = New AForge.Controls.VideoSourcePlayer()
        Me.cmbDispositivos = New System.Windows.Forms.ComboBox()
        Me.lblEscaner = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'vspEscaner
        '
        Me.vspEscaner.BackColor = System.Drawing.SystemColors.ControlText
        Me.vspEscaner.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.vspEscaner.Location = New System.Drawing.Point(32, 73)
        Me.vspEscaner.Name = "vspEscaner"
        Me.vspEscaner.Size = New System.Drawing.Size(430, 249)
        Me.vspEscaner.TabIndex = 4
        Me.vspEscaner.Text = "VideoSourcePlayer1"
        Me.vspEscaner.VideoSource = Nothing
        '
        'cmbDispositivos
        '
        Me.cmbDispositivos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbDispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDispositivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDispositivos.ForeColor = System.Drawing.Color.OrangeRed
        Me.cmbDispositivos.FormattingEnabled = True
        Me.cmbDispositivos.Location = New System.Drawing.Point(32, 46)
        Me.cmbDispositivos.Name = "cmbDispositivos"
        Me.cmbDispositivos.Size = New System.Drawing.Size(430, 21)
        Me.cmbDispositivos.TabIndex = 0
        '
        'lblEscaner
        '
        Me.lblEscaner.AutoSize = True
        Me.lblEscaner.BackColor = System.Drawing.Color.Transparent
        Me.lblEscaner.Font = New System.Drawing.Font("Century Gothic", 10.25!)
        Me.lblEscaner.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblEscaner.Location = New System.Drawing.Point(204, 24)
        Me.lblEscaner.Name = "lblEscaner"
        Me.lblEscaner.Size = New System.Drawing.Size(258, 19)
        Me.lblEscaner.TabIndex = 5
        Me.lblEscaner.Text = "Selecciona un dispositivo de lectura"
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.btnIniciar.ForeColor = System.Drawing.Color.White
        Me.btnIniciar.Location = New System.Drawing.Point(170, 308)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(126, 36)
        Me.btnIniciar.TabIndex = 18
        Me.btnIniciar.Text = "Escanear"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'btnDetener
        '
        Me.btnDetener.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetener.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.btnDetener.ForeColor = System.Drawing.Color.White
        Me.btnDetener.Location = New System.Drawing.Point(316, 308)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(126, 36)
        Me.btnDetener.TabIndex = 19
        Me.btnDetener.Text = "Detener"
        Me.btnDetener.UseVisualStyleBackColor = False
        '
        'frmEscaner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(495, 357)
        Me.Controls.Add(Me.btnDetener)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.cmbDispositivos)
        Me.Controls.Add(Me.lblEscaner)
        Me.Controls.Add(Me.vspEscaner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEscaner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEscaner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents vspEscaner As AForge.Controls.VideoSourcePlayer
    Friend WithEvents cmbDispositivos As ComboBox
    Friend WithEvents lblEscaner As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnDetener As Button
End Class
