using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void Openurl(string Urlname)
    {
        Application.OpenURL(Urlname);
    }
}
