using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI m_Title;

    [SerializeField]
    private Image m_Icon;

    [SerializeField]
    private string m_Text = "Button";

    [SerializeField]
    private Sprite m_Sprite;

    [SerializeField]
    private Color m_Color = Color.magenta;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Title.text = m_Text;
        m_Icon.sprite = m_Sprite;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChangeIconColor()
    {
        m_Icon.color = m_Color;
    }
}
