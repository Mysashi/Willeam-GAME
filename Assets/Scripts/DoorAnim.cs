using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class DoorAnim : MonoBehaviour
{
    private bool doorActive = false;
    private Camera cam;
    // Start is called before the first frame update

    private void Start()
    {
        cam = PlayerCamera.Instance.gameObject.GetComponent<Camera>();
    }
    private void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if ( Physics.Raycast(ray, out hit, 3)) 
        {
            if (hit.collider.tag == "Door")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Succ");
                    if (doorActive == false)
                    {
                        GameObject doorParent = hit.collider.gameObject;
                        Animator animator = doorParent.GetComponent<Animator>();
                        AudioSource doorSound = hit.collider.gameObject.GetComponent<AudioSource>();
                        doorSound.Play();
                        animator.SetBool("OpenDoor", true);
                    }
                }
            }
        }
    }

}
