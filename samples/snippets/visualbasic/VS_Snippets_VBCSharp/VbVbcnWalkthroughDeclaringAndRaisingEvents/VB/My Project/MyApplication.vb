﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    Partial Class MyApplication
        
        <Global.System.Diagnostics.DebuggerStepThrough()> Public Sub New()
            MyBase.New(ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = false
            Me.EnableVisualStyles = true
            Me.ShutDownStyle = ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub
        
        <Global.System.Diagnostics.DebuggerStepThrough()> Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = My.Forms.Form1
        End Sub
    End Class
End Namespace