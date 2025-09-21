using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public Text text;
    public int stars;
    public void Click()
    {
        stars++;
        text.text = stars.ToString();
    }
}
