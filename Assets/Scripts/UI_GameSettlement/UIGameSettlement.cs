using Cofdream.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Survivor
{
    public class UIGameSettlement : MonoBehaviour
    {

        public void Close()
        {
            UIManager.ClosePanel(gameObject);
        }
    }
}
