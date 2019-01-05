using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Boo.Lang;
using MoonSharp.Interpreter;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using Coroutine = UnityEngine.Coroutine;
using System.Threading;
using UnityEngine.UI;
using Console = LuaObjects.InGameEditor.Console;
using Debug = UnityEngine.Debug;

namespace LuaObjects
{
    public class LuaInterface : MonoBehaviour
    {
        private static LuaInterface val;


        public TMP_Text my_console;
        public  TMP_Text my_editor;

        public static TMP_Text Console
        {
            get { return val.my_console; }
        }

        public static TMP_Text Editor
        {
            get { return val.my_editor; }
        }

        public LuaInterface()
        {
            val = this;
        }


        public Script mainScript;

        void Start()
        {
            UserData.RegisterAssembly();
        }
        

        private DynValue coroutine = null;



        void Update()
        {
            if (coroutine != null && coroutine.Coroutine.State != CoroutineState.Dead)
            {
                Debug.Log("next");
                coroutine.Coroutine.Resume();
                if (coroutine.Coroutine.State == CoroutineState.Dead)
                {
                    coroutine = null;
                }
            }
            
        }
        
        
        
        
        public void RunScript()
        {
            coroutine = GamePieces.Player._new(Editor.text).createCoroutine();
        }
        
        
        

    }
}