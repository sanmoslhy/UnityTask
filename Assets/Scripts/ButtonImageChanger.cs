using UnityEngine;
using UnityEngine.UI;

public class ButtonImageChanger : MonoBehaviour
{
    public Button OptionTwoButton; // The button being clicked (Main button)
    public Image OptionTwoImage; // Image of the clicked button
    public Sprite OptionTwoDefault; // Default image
    public Sprite OptionTwoClicked; // Image after clicking

    public Button OptionOneButton; // First extra button
    public Image OptionOneImage;
    public Sprite OptionOneDefault;
    public Sprite OptionOneClicked;

    public Button OptionThreeButton; // Second extra button
    public Image OptionThreeImage;
    public Sprite OptionThreeDefault;
    public Sprite OptionThreeClicked;

    private bool isClicked = false;

    void Start()
    {
        OptionTwoButton.onClick.AddListener(ChangeImages);

    }

    void ChangeImages()
    {
        // Toggle the main button's image (OptionTwoButton)
        OptionTwoImage.sprite = isClicked ? OptionTwoDefault : OptionTwoClicked;

        // Toggle the first extra button's image (OptionOneButton)
        OptionOneImage.sprite = isClicked ? OptionOneDefault : OptionOneClicked;

        // Toggle the second extra button's image (OptionThreeButton)
        OptionThreeImage.sprite = isClicked ? OptionThreeDefault : OptionThreeClicked;

        // Flip the toggle state
        isClicked = !isClicked;
    }
}
