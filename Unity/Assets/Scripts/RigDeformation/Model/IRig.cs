namespace Andre.RigDeformation.Model
{
	public interface IRig
	{
		void AddBone(IBone bone);
		IBone GetBone(string key);

	}
}
