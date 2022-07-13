using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void ChangeToScene()
    {
        SceneManager.LoadScene("OculusLipsyncChat");
    }
    // Start is called before the first frame update
    
}
