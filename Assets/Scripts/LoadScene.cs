using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string scene;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(scene);
    }
    // Start is called before the first frame update

}