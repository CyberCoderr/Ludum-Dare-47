using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenCyberCoderChannel()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCCHo3boDHDe_VyB5_BPvpxg?view_as=subscriber");
    }

    public void OpenTheUnityNoobChannel()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCVUPxbTJrh0plTdzXjJarsw");
    }

    public void OpenCyberCoderDiscord()
    {
        Application.OpenURL("https://discord.gg/E8XR5fm");
    }
}
