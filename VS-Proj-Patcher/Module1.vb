Imports Microsoft.Build.BuildEngine
Module Module1

    Sub Main()
        Dim args = Environment.GetCommandLineArgs
        Dim FullProjectPath As String = args(1)
        Dim eng As New Engine()
        Dim proj As New Project(eng)
        proj.Load(FullProjectPath)
        proj.SetProperty("NoWin32Manifest", "true")
        proj.Save(FullProjectPath)
    End Sub

End Module
