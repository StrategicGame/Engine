using UnityEngine;
using System.Collections;

/// <summary>
/// Data about a custom resource type.
/// </summary>
[System.Serializable]
public class ResourceDataType
{
	//uniqe id
	public string id;

	//what is the resource type
	public ResourceKind kind;
	
	/// Human readable name.
	public string name;
	

	
	public ResourceDataType(ResourceKind kind, string name){
		this.name=name;
		this.kind=kind;

	}
}