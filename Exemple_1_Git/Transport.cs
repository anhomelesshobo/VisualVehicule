using System;
public abstract class Transport {
	private double maxSpeed { get; set; }
	public double MaxSpeed {
		get {
			return maxSpeed;
		}
		set {
			maxSpeed = value;
		}
	}
	private double weight = 0;

	public abstract string Move();

}
