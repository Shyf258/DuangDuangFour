using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 工具
/// </summary>
public static class Tool 
{
    // Start is called before the first frame update
    
    /// <summary>
    /// 获取当前按钮的游戏对象
    /// </summary>
    /// <returns></returns>
    public static GameObject GetButton()
    {
        var buttonSelf = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        return buttonSelf.gameObject;
    }
    
}
