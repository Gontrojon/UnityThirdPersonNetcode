using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode.Components;

public class ClientNetworkTransform : NetworkTransform
{
    // sobreescritrura del NetworkTransform para que la autoridad sea del cliente
   protected override bool OnIsServerAuthoritative()
    {
        return false;
    }

}
