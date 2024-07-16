public delegate void MyDelegate();

class Program {
	static void Main() {
		Machine mesin = new();
		Machine mesin2 = new();
		Engine engine = new();
		MyDelegate myDel = mesin.Start;
		myDel += mesin2.Start;
		myDel += engine.TurnOn;
		myDel();
	}
}
class Machine {
	public void Start() {
		Console.WriteLine("Start");
	}
}
class Engine {
	public void TurnOn() {
		Console.WriteLine("On");

	}
}