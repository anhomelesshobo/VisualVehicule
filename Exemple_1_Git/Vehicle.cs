using System;
public class Vehicle : Land {

    public string Brand { get; set; }
    private double _speed;

    public void Accelerate(double vitesse)
    {
        _speed += vitesse;
    }
  
    public virtual string Indicate (bool turnLeft)
    {
        return turnLeft ? "Turning Left" : "Turning right"; 
        // c'est comme un if mais plus rapide d'ecriture.
        //if(condition)
        //{
        //    return true;
        //}
        //else
        //{
        //    return false;
        //}
    }


}
