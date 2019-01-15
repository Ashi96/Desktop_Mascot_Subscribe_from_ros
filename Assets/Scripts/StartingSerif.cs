using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartingSerif : MonoBehaviour {

    //inspectorで変更可能にする
    [SerializeField] UnityEngine.UI.Text textbox;


    // Use this for initialization
    void Start () {
        textbox.text = "今日も元気にやってこー";
    }
    void Update()
    {
        
        //もしマウスクリックされたらMenuシーンへ飛ぶ
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Menu");
        }
        
    }
}
