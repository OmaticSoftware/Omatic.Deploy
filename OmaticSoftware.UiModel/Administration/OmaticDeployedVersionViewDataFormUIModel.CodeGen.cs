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
/// Represents the UI model for the 'Omatic Deployed Version View Data Form' data form
/// </summary>
[global::Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(global::Blackbaud.AppFx.UIModeling.Core.DataFormMode.View, "e7b0f7b9-cb35-4af6-b948-566a78d8892e", "c949a245-4f01-4fa8-8368-3e7c0b440347", "")]
public partial class @OmaticDeployedVersionViewDataFormUIModel : global::Blackbaud.AppFx.UIModeling.Core.DataFormUIModel
{

#region "Extensibility methods"

	partial void OnCreated();

#endregion

    private global::Blackbaud.AppFx.UIModeling.Core.CollectionField<OmaticDeployedVersionViewDataFormVERSIONSUIModel> _versions;
    private global::Blackbaud.AppFx.UIModeling.Core.StringField _servername;

	[System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")]
	public @OmaticDeployedVersionViewDataFormUIModel() : base()
	{


        _versions = new global::Blackbaud.AppFx.UIModeling.Core.CollectionField<OmaticDeployedVersionViewDataFormVERSIONSUIModel>();
        _servername = new global::Blackbaud.AppFx.UIModeling.Core.StringField();

        this.Mode = global::Blackbaud.AppFx.UIModeling.Core.DataFormMode.View;
        this.DataFormTemplateId = new System.Guid("e7b0f7b9-cb35-4af6-b948-566a78d8892e");
        this.DataFormInstanceId = new System.Guid("c949a245-4f01-4fa8-8368-3e7c0b440347");
        this.RecordType = "";
        this.UserInterfaceUrl = "browser/htmlforms/custom/omaticsoftware.uimodel/OmaticDeployedVersionViewDataForm.html";

        //
        //_versions
        //
        _versions.Name = "VERSIONS";
        _versions.Caption = "Versions";
        _versions.DBReadOnly = true;
        this.Fields.Add(_versions);
        //
        //_servername
        //
        _servername.Name = "SERVERNAME";
        _servername.Caption = "Server name";
        _servername.DBReadOnly = true;
        this.Fields.Add(_servername);

		OnCreated();

	}

    /// <summary>
    /// Versions
    /// </summary>
    [System.ComponentModel.Description("Versions")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")]
	public global::Blackbaud.AppFx.UIModeling.Core.CollectionField<OmaticDeployedVersionViewDataFormVERSIONSUIModel> @VERSIONS {
		get { return _versions; }
	}

    /// <summary>
    /// Server name
    /// </summary>
    [System.ComponentModel.Description("Server name")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")]
	public global::Blackbaud.AppFx.UIModeling.Core.StringField @SERVERNAME {
		get { return _servername; }
	}

}


}
