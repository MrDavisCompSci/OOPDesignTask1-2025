// Console template
using System;
class Program
{
    static void Main()
    {   
        Fish thisFish = new Fish("little fish");
	    thisFish.SetMaxSize(3);
	    Duck thisDuck = new Duck("little duck");
	    for (int i = 0;i < 3;i++)
		{
			thisDuck.Feed();
			Console.WriteLine(thisDuck.GetState());
			thisFish.Feed();
			Console.WriteLine(thisFish.GetState());
		}
    }
}

class Animal
{
	protected string state;
	protected int size;

	public Animal(string s)
	{
		state = s;
		size = 0;
	}

	public virtual void Feed()
	{
		size++;
		Console.WriteLine($"{state} fed!");
	}

	public string GetState()
	{
		return state;
	}

	public int GetSize()
	{
		return size;
	}
}

class Fish : Animal
{
	private int maxSize;

	public Fish(string s) : base(s)
	{} 

	public void SetMaxSize(int n)
	{
		maxSize = n;
	}

	public override void Feed()
	{
		size += 2;
		Console.WriteLine($"{state} fed!");
		if (size >= maxSize)
		{
			state = "BIG FISH";
		}
	}
}
 
class Duck : Animal
{
	public Duck(string s) : base(s){}
	public override void Feed()
	{
		base.Feed();
		if (size == 5)
		{
			state = "BIG DUCK";
		}
	}
}
 

 
	 
	
