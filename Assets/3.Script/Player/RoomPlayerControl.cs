using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class RoomPlayerControl : NetworkRoomPlayer
{
    public bool isLocal = false;

    private void Update()
    {
        isLocal = isLocalPlayer;
    }
}
