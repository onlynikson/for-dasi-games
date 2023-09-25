using UnityEditor.Animations;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField] private FloatingJoystick joystick;
    [SerializeField] private AnimatorController _animatorController;
    [SerializeField] private float movespeed;
    [SerializeField] private float rotatespeed;
    
    
    

    private Rigidbody rb;
    private Vector3 movevector;

    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Calling MovementFunction

    void Update()
    {
        Move();
        
        
        





    }

    // Player Movement

    private void Move()
    {
        movevector = Vector3.zero;
        movevector.x = joystick.Horizontal * movespeed * Time.deltaTime;
        movevector.z = joystick.Vertical * movespeed * Time.deltaTime;

        if(joystick.Horizontal != 0 ||  joystick.Vertical !=0)
        {
            Vector3 direction = Vector3.RotateTowards(transform.forward, movevector, rotatespeed * Time.deltaTime, 0.0f);
            transform.rotation = Quaternion.LookRotation(direction);

            _animatorController.PlayRun();
        }

        else if(joystick.Horizontal == 0 && joystick.Vertical == 0)
        {
            _animatorController.PlayIdle();
            
        }
        rb.MovePosition(rb.position + movevector);

        
    }

  
    

}
