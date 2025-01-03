public partial class Player : RigidBody3D
{
	float acceleration = 20;
	float turnAcceleration = 20;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		float felta = (float)delta;
		if (Input.IsActionPressed("ui_up"))
		{
			LinearVelocity += Transform.Basis.Z * acceleration * felta;
		}
		if (Input.IsActionPressed("ui_down"))
		{
			LinearVelocity -= Transform.Basis.Z * acceleration * felta;
		}
		if (Input.IsActionPressed("ui_left"))
		{
			AngularVelocity -= new Vector3(0, turnAcceleration * felta, 0);
		}
		if (Input.IsActionPressed("ui_right"))
		{
			AngularVelocity += new Vector3(0, turnAcceleration * felta, 0);
		}
	}

	public static Vector3 ClampVector(Vector3 vector, float max)
	{
		return new Vector3(Mathf.Clamp(vector.X, -max, max), Mathf.Clamp(vector.Y, -max, max), Mathf.Clamp(vector.Z, -max, max));
	}
}
