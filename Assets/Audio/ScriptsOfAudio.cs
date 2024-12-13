using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScriptsOfAudio : MonoBehaviour
{
    private Ray ray;
    public float minTimeBetweenFootsteps = 0f; // Minimum time between footstep sounds
    public float maxTimeBetweenFootsteps = 1f;
    private float timeSinceLastFootstep;
    private RaycastHit hit;
    public AudioSource foot;
    private AudioClip currentSound;
    private bool isMoving = true;
    public float frequency = 8f;
    public float runFrequency = 12f;
    public float normalFrequency = 8f;
    float sin;
    bool isTriggered = false;
    public UnityEvent onFootStep;

    void Start()
    {
        if (foot == null)
        {
            Debug.Log("Нет звука");
        }
        //grassSounds = storage.audioClipForestFx;
    }

    private void Update()
    {
        float inputMagnitude = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).magnitude;
        if (inputMagnitude > 0)
        {
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            {
                frequency = runFrequency;
            }
            else frequency = normalFrequency;
            playSteps();
        }

    }

    private IEnumerator timer()
    {
        yield return new WaitForSeconds(3f);
    }

    private void playSteps()
    {
        sin = Mathf.Sin(Time.time * frequency);

        if (sin > 0.97f && isTriggered == false)
        {
            isTriggered = true;
            onFootStep.Invoke();
        }
        else if (isTriggered == true && sin < 0.97f)
        {
            isTriggered = false;
        }
        //foot.clip = currentSound;              

    }
}
