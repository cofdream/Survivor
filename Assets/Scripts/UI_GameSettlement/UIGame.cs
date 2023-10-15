using Cofdream.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Survivor
{
    public class UIGame : MonoBehaviour
    {
        public Action Start;

        public void OnStart()
        {
            Start?.Invoke();
            UIManager.ClosePanel(gameObject);
        }
    }
}
