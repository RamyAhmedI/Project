using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Syringe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.UpArrow)) {
                     transform.eulerAngles = new Vector3(0,0,0);
                 }
                 else if (Input.GetKey (KeyCode.LeftArrow)) {
                     transform.eulerAngles = new Vector3(0,-90,0);
                 }
                 else if (Input.GetKey (KeyCode.DownArrow)) {
                     transform.eulerAngles = new Vector3(0,180,0);
                 }
                 else if (Input.GetKey (KeyCode.RightArrow)) {
                     transform.eulerAngles = new Vector3(0,90,0);
                 }
                  if(Input.GetKeyDown(KeyCode.Space)){
                     Instantiate(Syringe, transform.position, Syringe.transform.rotation);
                 }
         }
}
