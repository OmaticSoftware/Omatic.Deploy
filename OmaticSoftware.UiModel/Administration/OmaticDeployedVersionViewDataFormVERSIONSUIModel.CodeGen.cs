﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by BBUIModelLibrary
//     Version:  4.0.167.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace OmaticSoftware.UiModel
{

/// <summary>
/// Represents the UI model for the 'OmaticDeployedVersionViewDataFormVERSIONS' data form
/// </summary>
public partial class @OmaticDeployedVersionViewDataFormVERSIONSUIModel : global::Blackbaud.AppFx.UIModeling.Core.UIModel
{

#region "Extensibility methods"

	partial void OnCreated();

#endregion

    private global::Blackbaud.AppFx.UIModeling.Core.StringField _name;
    private global::Blackbaud.AppFx.UIModeling.Core.StringField _version;
    private global::Blackbaud.AppFx.UIModeling.Core.DateField _datemodified;

	[System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")]
	public @OmaticDeployedVersionViewDataFormVERSIONSUIModel() : base()
	{


        _name = new global::Blackbaud.AppFx.UIModeling.Core.StringField();
        _version = new global::Blackbaud.AppFx.UIModeling.Core.StringField();
        _datemodified = new global::Blackbaud.AppFx.UIModeling.Core.DateField();

        //
        //_name
        //
        _name.Name = "NAME";
        _name.Caption = "Filename";
        _name.DBReadOnly = true;
        this.Fields.Add(_name);
        //
        //_version
        //
        _version.Name = "VERSION";
        _version.Caption = "Version";
        _version.DBReadOnly = true;
        this.Fields.Add(_version);
        //
        //_datemodified
        //
        _datemodified.Name = "DATEMODIFIED";
        _datemodified.Caption = "Date modified";
        _datemodified.DBReadOnly = true;
        _datemodified.IncludeTimeOnDate = true;
        this.Fields.Add(_datemodified);

		OnCreated();

	}

    /// <summary>
    /// Filename
    /// </summary>
    [System.ComponentModel.Description("Filename")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")]
	public global::Blackbaud.AppFx.UIModeling.Core.StringField @NAME {
		get { return _name; }
	}

    /// <summary>
    /// Version
    /// </summary>
    [System.ComponentModel.Description("Version")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")]
	public global::Blackbaud.AppFx.UIModeling.Core.StringField @VERSION {
		get { return _version; }
	}

    /// <summary>
    /// Date modified
    /// </summary>
    [System.ComponentModel.Description("Date modified")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")]
	public global::Blackbaud.AppFx.UIModeling.Core.DateField @DATEMODIFIED {
		get { return _datemodified; }
	}

}


}
