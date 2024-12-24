using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    //Start is called before the first frame update
    void Start() {
        
    }

    //Update is called once per frame
    void Update() {

    }
    //public void 按鈕名稱()
    //SceneManager.LoadScene("要跳轉的場景名稱");
    public void doorA() 
    {
        SceneManager.LoadScene("2");
    }
}