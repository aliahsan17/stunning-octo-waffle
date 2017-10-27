'
' * Created by Ranorex
' * User: aahsan
' * Date: 10/8/2015
' * Time: 10:59 AM
' * 
' * To change this template use Tools | Options | Coding | Edit Standard Headers.
' 


Imports System.Threading
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports WinForms = System.Windows.Forms

Imports Ranorex
Imports Ranorex.Core
Imports Ranorex.Core.Reporting
Imports Ranorex.Core.Testing

Namespace DBConnectorExample
	Class Program
		<STAThread> _
		Public Shared Function Main(args As String()) As Integer
			' Uncomment the following 2 lines if you want to automate Windows apps
			' by starting the test executable directly
			'if (Util.IsRestartRequiredForWinAppAccess)
			'    return Util.RestartWithUiAccess();

			Keyboard.AbortKey = System.Windows.Forms.Keys.Pause
			Dim [error] As Integer = 0

			Try
				[error] = TestSuiteRunner.Run(GetType(Program), Environment.CommandLine)
			Catch e As Exception
				Report.[Error]("Unexpected exception occurred: " & e.ToString())
				[error] = -1
			End Try
			Return [error]
		End Function
	End Class
End Namespace
