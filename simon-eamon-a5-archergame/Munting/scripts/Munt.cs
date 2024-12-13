using Godot;
using System;

//
public partial class Munt : CharacterBody2D
{
	private AnimatedSprite2D _animatedSprite;

    public override void _Ready()
    {
        _animatedSprite = GetNode<AnimatedSprite2D>("Munt");

        _animatedSprite.Play("Idle");
    }

   

    // Called every frame. 'delta' is the elapsed time since the previous frame.

}
