using Mirror;
using UnityEngine;

namespace DapperDino.Multiplayer
{
    public class MyNetworkManager : NetworkManager
    {
        public void OnServerConnect(NetworkConnection conn)
        {
            Debug.Log($"Player {conn.connectionId} has connected");
        }
    }
}
