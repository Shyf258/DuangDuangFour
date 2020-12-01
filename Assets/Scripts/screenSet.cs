using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenSet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        //读场景进入游戏
        
    }
    public void Unclock()
    {
       string buttonName = Tool.GetButton().name;
        Image image = transform.FindChild(buttonName).GetComponent<Image>();
        image.sprite = Resources.Load("HeroPic/Unclocked", typeof(Sprite)) as Sprite;
    }

}
