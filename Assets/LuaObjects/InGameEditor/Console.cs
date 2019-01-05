using MoonSharp.Interpreter;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LuaObjects.InGameEditor
{
    [MoonSharpUserData]
    public class Console
    {
        private TMP_Text m_console;

        private void resetHeight()
        {
            var transform = m_console.gameObject.GetComponent<RectTransform>();
            transform.sizeDelta = new Vector2(transform.sizeDelta.x,m_console.renderedHeight);
        }
        
        
        
        public Console(TMP_Text con)
        {
            m_console = con;
        }
        
        
        public void print()
        {
            m_console.text += "\n";
            //Debug.Log(m_console.text);
            resetHeight();
        }

        public void print(object obj)
        {
            m_console.text += obj.ToString() + "\n";
            //Debug.Log(m_console.text);
            resetHeight();
        }

        public void write(object obj)
        {
            m_console.text += obj.ToString();
            resetHeight();
        }

        public void clear()
        {
            m_console.text = "";
            resetHeight();
        }
        
    }
}