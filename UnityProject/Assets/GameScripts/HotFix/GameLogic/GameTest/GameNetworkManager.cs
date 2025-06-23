using Mirror;
using UnityEngine;

namespace GameLogic.GameTest
{
    public class GameNetworkManager : NetworkManager
    {
        public override void OnStartServer()
        {
            base.OnStartServer();
        }

        public override void OnStopServer()
        {
            base.OnStopServer();
        }

        public override void OnClientConnect()
        {
            base.OnClientConnect();
        }

        public override void OnClientDisconnect()
        {
            base.OnClientDisconnect();
        }
    }
}