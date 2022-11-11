using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPauseManage : MonoBehaviour
{

    public AudioSource as0;
    public AudioSource as1;
    public AudioSource as2;

    bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        as0 = GameObject.Find("Button").GetComponent<AudioSource>();
        as1 = GameObject.Find("BGM").GetComponent<AudioSource>();
        as2 = GameObject.Find("unitychan").GetComponent<AudioSource>();
    }

    private void OnApplicationPause(bool pause)
    {
        if(pause == true)
        {
            isPaused = true;
            return;
        }

        if(pause == false && isPaused == false)
        {
            return;
        }
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(isPaused == true)
        {
            as0.Pause();
            as1.Pause();
            as2.Pause();
        }

        else
        {
            as0.UnPause();
            as1.UnPause();
            as2.UnPause();
        }
    }
}
