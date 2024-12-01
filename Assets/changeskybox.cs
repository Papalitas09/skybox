using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeskybox : MonoBehaviour
{

    public Material anotherSkybox;
    bool nyala = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && nyala == false)
        {
            RenderSettings.skybox = anotherSkybox;
            nyala = true;
        }
    }
   }

