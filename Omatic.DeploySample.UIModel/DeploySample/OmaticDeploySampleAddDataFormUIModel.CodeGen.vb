﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  4.0.154.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Omatic Deploy Sample Add Data Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Add, "085c872c-4268-43d8-9bf6-df3a688b7e76", "a7ae64bc-d2d5-42f6-959f-c861233557ed", "Omatic Deploy Sample")>
Partial Public Class [OmaticDeploySampleAddDataFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _name As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _description As Global.Blackbaud.AppFx.UIModeling.Core.StringField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.154.0")> _
    Public Sub New()
        MyBase.New()

        _name = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _description = New Global.Blackbaud.AppFx.UIModeling.Core.StringField

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Add
        MyBase.DataFormTemplateId = New System.Guid("085c872c-4268-43d8-9bf6-df3a688b7e76")
        MyBase.DataFormInstanceId = New System.Guid("a7ae64bc-d2d5-42f6-959f-c861233557ed")
        MyBase.RecordType = "Omatic Deploy Sample"
        MyBase.FORMHEADER.Value = "Add a sample"
        MyBase.UserInterfaceUrl = "browser/htmlforms/OmaticDeploySampleAddDataForm.html"

        '
        '_name
        '
        _name.Name = "NAME"
        _name.Caption = "Name"
        _name.MaxLength = 100
        Me.Fields.Add(_name)
        '
        '_description
        '
        _description.Name = "DESCRIPTION"
        _description.Caption = "Description"
        _description.MaxLength = 4000
        _description.Multiline = True
        Me.Fields.Add(_description)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Name
    ''' </summary>
    <System.ComponentModel.Description("Name")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.154.0")> _
    Public ReadOnly Property [NAME]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _name
        End Get
    End Property
    
    ''' <summary>
    ''' Description
    ''' </summary>
    <System.ComponentModel.Description("Description")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.154.0")> _
    Public ReadOnly Property [DESCRIPTION]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _description
        End Get
    End Property
    
End Class