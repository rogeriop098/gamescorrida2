using UnityEngine;

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    //componentes de fisica do carro
    [SerializeField] private WheelCollider frontLeftWheelTransform;
    [SerializeField] private WheelCollider frontRightWheelTransform;
    [SerializeField] private WheelCollider RearLeftWheelTransform;
    [SerializeField] private WheelCollider RearRightWheelTransform;

    //componentes do carro
    [SerializeField] private Transform frontLeftWheelColider;
    [SerializeField] private Transform frontRightWheelColider;
    [SerializeField] private Transform RearLeftWheelColider;
    [SerializeField] private Transform RearRightWheelColider;


    //componentes de controller
    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSterringAngle;

}
