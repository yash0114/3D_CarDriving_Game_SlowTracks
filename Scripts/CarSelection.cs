using UnityEngine;
using UnityEngine.UI;
public class CarSelection : MonoBehaviour
{

    [SerializeField] private Button nextButton;
    [SerializeField] private Button prevButton;
    private int CurrentCar;


    private void Awake()
    {
        selectCar(0);
    }

    private void selectCar(int _index)
    {
        prevButton.interactable = (_index != 0);
        nextButton.interactable = (_index != transform.childCount-1);
        for (int i = 0; i< transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }
    public void ChangeCar(int _change)
    {
        CurrentCar += _change;
        selectCar(CurrentCar);
    }
}
