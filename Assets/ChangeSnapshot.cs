using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ChangeSnapshot : MonoBehaviour {
    [Header("Snapshots")]
    [SerializeField]
    AudioMixerSnapshot[] snapshots;
    [SerializeField]
    float transitionDuration = 1;

    [Header("Exposed")]
    [SerializeField]
    AudioMixer mixer;
    [SerializeField]
    float[] volumes;
    [SerializeField]
    string parameterName = "TVGS Volume";

    int index = 0;
    int jndex = 0;

    // Update is called once per frame
    void Update () {
        if(Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log("Toggling snapshots");

            // Increment index
            index = index + 1;

            // Make sure index is less than the array size
            if(index >= snapshots.Length)
            {
                index = 0;
            }

            // Change the snapshot
            snapshots[index].TransitionTo(transitionDuration);
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            Debug.Log("Toggling volume");

            // Increment index
            jndex = jndex + 1;

            // Make sure index is less than the array size
            if (jndex >= volumes.Length)
            {
                jndex = 0;
            }

            // Change the volume
            mixer.SetFloat(parameterName, volumes[jndex]);
        }
    }
}
