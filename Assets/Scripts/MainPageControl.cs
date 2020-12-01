using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utilty;
public class MainPageControl : MonoBehaviour 
{
    /// <summary>
    /// 当前页
    /// </summary>
    private GameObject currentPage ;
    /// <summary>
    /// 页面储存
    /// </summary>
    private Dictionary<string, GameObject> Pages;
    
    private GameObject Page;
    //选角页面的游戏对象
    private GameObject change;
    //主页的游戏对象
    private GameObject main;


    private void Awake()
    {
        //加载资源
        change = GameObject.Find("ChangePanel");
        change.gameObject.SetActive(false);
        main = GameObject.Find("MainPanel");
        currentPage = main.gameObject;
        
        
       
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    /// <summary>
    /// 进入商店
    /// </summary>
    public void EnterShop()
    {
        currentPage.SetActive(false);
       GameObject shop =   Tool.GetButton();

    }
    /// <summary>
    /// 进入主页
    /// </summary>
    public void EnterMain()
    {
        if (currentPage != main )
        {
            main.SetActive(true);
            currentPage.SetActive(false);
            //GameObject main = Tool.GetButton();

            currentPage = main.gameObject;
        }
       
       
    } 
    /// <summary>
    /// 进入选择英雄界面
    /// </summary>
    public void EnterChange()
    {
        change.SetActive(true);
        currentPage.SetActive(false);
        //GameObject change = Tool.GetButton();
        
        currentPage = change.gameObject;
    }
    /// <summary>
    /// 进入工会
    /// </summary>
    public void EnterFaction()
    {
        GameObject faction = Tool.GetButton();
    }
    /// <summary>
    /// 进入挑战页面
    /// </summary>
    public void EnterChallenge()
    {
        GameObject challenge = Tool.GetButton();
    }
    
}
