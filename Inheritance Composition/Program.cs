class Hp
{
	public Memory memory;
	 public Hp(Memory memory)
	 {
		this.memory = memory;
	 }
}

class Memory
{
	public int size;
	public string brand;
}
class internalMemory : Memory{}

class program 
{
	static void Main()
	{
		Memory memory = new Memory();
		Hp hp = new Hp(memory);
		
		internalMemory internalMemory = new internalMemory(); 
		Hp hp2 = new Hp(internalMemory);
	}
}