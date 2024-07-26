namespace ProgramBootcamp; //using same namespace
public partial class Bootcamp
{
	public string participantName;
	public string address;
	public Bootcamp(string participantName, string address)
	{
		this.participantName = participantName;
		this.address = address;
	}
}