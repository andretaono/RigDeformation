namespace Andre.RigDeformation.Model
{

	/// <summary>
	/// Provides the identifier used to locate the root bone in a skeletal hierarchy.
	/// </summary>
	/// <remarks>
	/// This abstraction decouples root bone discovery from hardcoded naming conventions,
	/// allowing different projects or character rigs to define their own root bone keys.
	/// </remarks>
	public interface IRootBoneKeyProvider
	{
		string RootBoneKey { get; }
	}
}
