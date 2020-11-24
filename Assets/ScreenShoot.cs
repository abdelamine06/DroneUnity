using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShoot : MonoBehaviour
{ 
    public static Camera camera;
    public string screenEve = "EveDetectionScreen.png";
      void Start()
    {
        camera = Camera.main;
        camera.enabled = false;
        ScreenCapture.CaptureScreenshot(screenEve);
       
    }

    // Update is called once per frame
    void Update()
    {
        
           
            
        
    }
}
