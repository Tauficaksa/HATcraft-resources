using Godot;
using System;

public partial class Game : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// just checking if everything is alright.
		GD.Print("This Is BIZZAR");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
