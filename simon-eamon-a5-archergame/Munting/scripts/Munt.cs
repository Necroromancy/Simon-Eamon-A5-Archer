using Godot;
using System;

public partial class Munt : CharacterBody2D
{
	private AnimationPlayer _animationPlayer;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
		_animationPlayer.Play("idle");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	
}
