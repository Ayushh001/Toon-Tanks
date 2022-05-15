using UnityEngine;

public class TankModel 
{   
    private TankController tankController;

    public float rotationSpeed;
    public float movementSpeed;

    public Material color;

    public TankTypes tankTypes;

public TankModel(float _movement, float _rotation, TankTypes tank, Material _color)
{
    movementSpeed = _movement;
    rotationSpeed = _rotation;
    tankTypes = tank;
    color = _color;
}

public void SetTankController(TankController _tankcontroller)
{
    tankController = _tankcontroller;
}


}
