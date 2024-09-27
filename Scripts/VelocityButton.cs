using UnityEngine;
using UnityEngine.UI;

public class VelocityButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ForwardMove()
    {
        CarControl.vInput = 1.0f;
    }
    public void CarIdle()
    {
        CarControl.vInput = 0.0f;
    }
    public void BackwardMove()
    {
        CarControl.vInput = -1.0f;
    }

    //public void SteerLeft()
    //{
    //    CarControl.hInput = -1.0f;
    //}
    //public void SteerRight() 
    //{
    //    CarControl.hInput = 1.0f;
    //}
}
