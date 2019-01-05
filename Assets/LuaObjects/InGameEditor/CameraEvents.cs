using UnityEngine;

namespace LuaObjects.InGameEditor
{
    public class CameraEvents : MonoBehaviour
    {

        public delegate void BasicEvent();

        public event BasicEvent onPreRender;
        
        
        
        private void OnPreRender()
        {
            if (onPreRender != null) onPreRender.Invoke();
        }
    }
}