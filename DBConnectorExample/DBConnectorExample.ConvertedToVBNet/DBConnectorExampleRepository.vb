﻿'//////////////////////////////////////////////////////////////////////////////
'
' This file was automatically generated by RANOREX.
' DO NOT MODIFY THIS FILE! It is regenerated by the designer.
' All your modifications will be lost!
' http://www.ranorex.com
'
'//////////////////////////////////////////////////////////////////////////////

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports Ranorex
Imports Ranorex.Core
Imports Ranorex.Core.Repository
Imports Ranorex.Core.Testing

Namespace DBConnectorExample
    ''' <summary>
    ''' The class representing the DBConnectorExampleRepository element repository.
    ''' </summary>
    <System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.4"), _
    RepositoryFolder("e0de70b5-dc31-4463-b5aa-5fe475e5b518")> _
    Partial Public Class DBConnectorExampleRepository
        Inherits RepoGenBaseFolder

        Shared _instance As DBConnectorExampleRepository = New DBConnectorExampleRepository()

        ''' <summary>
        ''' Repository class constructor.
        ''' </summary>
        Public Sub New()
            MyBase.New("DBConnectorExampleRepository", "/", Nothing, 0, False,"e0de70b5-dc31-4463-b5aa-5fe475e5b518", ".\RepositoryImages\DBConnectorExampleRepositorye0de70b5.rximgres")
        End Sub

        ''' <summary>
        ''' Gets the singleton class instance representing the DBConnectorExampleRepository element repository.
        ''' </summary>
        <RepositoryFolder("e0de70b5-dc31-4463-b5aa-5fe475e5b518")> _
        Public Shared ReadOnly Property Instance() As DBConnectorExampleRepository
            Get
                Return _instance
            End Get
        End Property

#Region "Variables"
#End Region

        ''' <summary>
        ''' The Self item info.
        ''' </summary>
        <RepositoryItemInfo("e0de70b5-dc31-4463-b5aa-5fe475e5b518")> _
        Public Overridable ReadOnly Property SelfInfo() As RepoItemInfo
            Get
                Return _selfInfo
            End Get
        End Property
    End Class

    ''' <summary>
    ''' Inner folder classes.
    ''' </summary>
    <System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.4")> _
    Partial Public Class DBConnectorExampleRepositoryFolders
    End Class
End Namespace