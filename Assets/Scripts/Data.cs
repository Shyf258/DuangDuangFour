using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data :MonoBehaviour
{ 
    //金币
    public int coin = 0;

    //宝石
    public int gem = 0;
    /// <summary>
    /// 获取金币数量
    /// </summary>
    /// <returns>金币量</returns>
    public string GetCoin()
    {
        string coinNum = coin.ToString();
        return coinNum;
    }
    /// <summary>
    /// 获取宝石数量
    /// </summary>
    /// <returns>宝石数</returns>
    public string GetGem()
    {
        string GemNum = gem.ToString();
        return GemNum;
    }
    public int SetCoin(int number)
    {
        coin += number;
        return coin;
    }
    public int SetGem(int number)
    {
        gem += number;
        return gem;
    }
    private void Update()
    {
        this.transform.FindChild("Coin").GetChild(2).GetComponent<Text>().text = GetCoin();
        this.transform.FindChild("Gem").GetChild(2).GetComponent<Text>().text = GetGem();
    }
    /// <summary>
    /// 充值
    /// </summary>
    public void Pay()
    {
        
    }
 
}


