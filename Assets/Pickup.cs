using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Diagnostics;




public class Pickup : MonoBehaviour
{
    public int count;
    public int maxCount = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }
    void OnTriggerStay(Collider other)
        {
            if (Keyboard.current.eKey.isPressed && other.gameObject.CompareTag("Item"))
            {
                UnityEngine.Debug.Log("ok");

                if (count < 3)
                {
                    Destroy(other.gameObject);
                    count++;
                }
                else { UnityEngine.Debug.Log("max count"); }



            }
            else if (Keyboard.current.eKey.isPressed && other.gameObject.CompareTag("Campfire") && count > 0)
            {
                UnityEngine.Debug.Log("stoked fire");
                count--;
            }
        }
}
