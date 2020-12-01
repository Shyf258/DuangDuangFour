using System.Collections.Generic;
using UnityEngine;

namespace UIFrame
{
    /// <summary>
    /// UI模块基类，需挂载到模块的根对象上
    /// </summary>
    [RequireComponent(typeof(CanvasGroup))]
    public class UIModuleBase : MonoBehaviour
    {
        /// <summary>
        /// 存储当前模块的所有元件
        /// </summary>
        public Dictionary<string, UIWidgetBase> _uiWidgets;
        //UI模块的控制模式
        public UIModuleMode _uiModuleMode = UIModuleMode.SingleControlMode;
        
        protected CanvasGroup _canvasGroup;
        protected GameObject gamePage;

        protected virtual void Awake()
        {
            _uiWidgets = new Dictionary<string, UIWidgetBase>();
            _canvasGroup = GetComponent<CanvasGroup>();
            gamePage = this.gameObject;
        }

        #region Module Callbacks

        /// <summary>
        /// 当打开当前模块
        /// </summary>
        public virtual void OnOpen()
        {
            //当前模块可以和用户交互（打开当前模块）
            //_canvasGroup.blocksRaycasts = true;
            gamePage.SetActive(true);
            ////将当前对象设置为最后一个子对象，使其显示在所有窗口的上面
            //transform.SetSiblingIndex(transform.parent.childCount - 1);
        }
        #region 当前页面打开小窗口
        /// <summary>
        /// 当当前模块被挂起
        /// </summary>
        public virtual void OnPause()
        {
            if (_uiModuleMode == UIModuleMode.SingleControlMode)
            {
                //当前模块不可以和用户交互
                _canvasGroup.blocksRaycasts = false;
            }
        }

        /// <summary>
        /// 当当前模块恢复
        /// </summary>
        public virtual void OnResume()
        {
            if (_uiModuleMode == UIModuleMode.SingleControlMode)
            {
                //当前模块可以和用户交互
                _canvasGroup.blocksRaycasts = true;
            }
        }
        #endregion


        /// <summary>
        /// 当关闭当前模块
        /// </summary>
        public virtual void OnClose()
        {
            //当前模块不可以和用户交互(关掉当前模块)
            gamePage.SetActive(false);
        }
        #endregion

    }
}

