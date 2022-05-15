using UnityEngine;

public class TankModel 
{   
    private TankController tankController;

    public float rotationSpeed;
    public float movementSpeed;

public TankModel(float _movement, float _rotation)
{
    movementSpeed = _movement;
    rotationSpeed = _rotation;
}

public void SetTankController(TankController _tankcontroller)
{
    tankController = _tankcontroller;
}


}
