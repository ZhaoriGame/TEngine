using System;
using Mirror;
using UnityEngine;

//[Command] Client Call Server Execute
//[ClientRpc] Server Call Client Execute
namespace GameLogic.GameTest
{
    public class Player : GameNetworkBehaviour
    {
        [SyncVar(hook = nameof(OnClickCountChanged))]
        private int m_ClickCount = 0;

        
        
        private void Update()
        {
            if (isLocalPlayer)
            {
                LocalUpdate();
            }
        }

        private void LocalUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.LogError("Space key Pressed!");
                CmdClick();
            }
        }

        [Command]
        private void CmdClick()
        {
            m_ClickCount++;
        }

        private void OnClickCountChanged(int oldClickCount, int newClickCount)
        {
                
        }
        
        [TargetRpc]
        void TargetShowMessage(NetworkConnection target, string message)
        {
           
        }
        
    }
}